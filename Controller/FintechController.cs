using System;
using Fintech.Entities;
using Fintech.Model;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Fintech.Controller
{
    public class FintechController
    {
        private readonly FintechDbContext _contexto;
        public Cliente? ClienteLogado { get; private set; }
        public Banco? BancoDaSessao { get; private set; }
        public Conta? ContaSelecionada { get; private set; }
        public GerenciadorDeConta gerenciadorDeConta;
        public GerenciadorDeCliente gerenciadorDeCliente;
        public GerenciadorDeTransacao gerenciadorDeTransacao;

        public FintechController()
        {
            _contexto = new();
            GerarBancos();
            gerenciadorDeConta = new(_contexto);
            gerenciadorDeCliente = new(_contexto);
            gerenciadorDeTransacao = new(_contexto);
        }

        private void GerarBancos()
        {
            var nomesDosBancos = new[] { "Bradesco", "Nubank", "Banestes", "Banco do Brasil" };
            var bancosExistentes = _contexto.Bancos
                                           .Select(b => b.Nome)
                                           .ToHashSet();

            bool adicionouNovoBanco = false;

            foreach (var nome in nomesDosBancos)
            {
                if (!bancosExistentes.Contains(nome))
                {
                    _contexto.Bancos.Add(new Banco { Nome = nome });
                    adicionouNovoBanco = true;
                }
            }

            if (adicionouNovoBanco)
            {
                _contexto.SaveChanges();
            }
        }
        public (bool Sucesso, string Mensagem) CadastrarCliente(string nome, string login, string senha, int bancoId)
        {
            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(senha))
            {
                return (false, "Nome, login e senha são obrigatórios.");
            }

            var banco = _contexto.Bancos.Find(bancoId);
            if (banco == null)
            {
                return (false, "Banco não encontrado.");
            }

            if (gerenciadorDeCliente.loginExiste(login, bancoId))
            {
                return (false, $"O login '{login}' já está em uso neste banco.");
            }

            var novoCliente = new Cliente
            {
                Nome = nome,
                Login = login,
                Senha = senha,
                BancoId = bancoId
            };

           gerenciadorDeCliente.SalvarCliente(novoCliente);

            return (true, $"Cliente '{nome}' cadastrado com sucesso no banco '{banco.Nome}'!");
        }
       
        public bool Login(string login, string senha, int bancoId)
        {
            
            (BancoDaSessao, ClienteLogado) = gerenciadorDeCliente.realizarLogin(login, senha, bancoId);
            ContaSelecionada = null;
            if (BancoDaSessao != null && ClienteLogado != null) {
                return true;
            }
            return false;
        }

        public Banco? ObterBancoPorNome(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
                return null;

            return _contexto.Bancos.FirstOrDefault(b => b.Nome == nome);
        } 


        public void Deslogar()
        {
            ClienteLogado = null;
            BancoDaSessao = null;
            ContaSelecionada = null;
        }

        private bool EstaLogado() => ClienteLogado != null && BancoDaSessao != null;

        public (ContaCorrente? cc, ContaPoupanca? cp) ObterContasDoCliente()
        {
            if (!EstaLogado())
            {
                return (null, null);
            }

            var contas = gerenciadorDeConta.ObterContasCliente(ClienteLogado!.Id, BancoDaSessao!.Id);

            var cc = contas.OfType<ContaCorrente>().FirstOrDefault();
            var cp = contas.OfType<ContaPoupanca>().FirstOrDefault();

            return (cc, cp);
        }

        public (bool Sucesso, string Mensagem) CriarContaCorrente(decimal limiteChequeEspecial = 100.0m)
        {
            if (!EstaLogado()) return (false, "Usuário não está logado.");

            if (limiteChequeEspecial < 0)
                return (false, "O limite não pode ser negativo.");

            bool jaPossui = gerenciadorDeConta.ContaCorrenteExiste(ClienteLogado!.Id, BancoDaSessao!.Id);

            if (jaPossui)
            {
                return (false, "Este cliente já possui uma Conta Corrente neste banco.");
            }

            var novaConta = new ContaCorrente
            {
                Saldo = 0,
                LimiteChequeEspecial = limiteChequeEspecial,
                ClienteId = ClienteLogado!.Id,
                BancoId = BancoDaSessao!.Id
            };

            gerenciadorDeConta.SalvarConta(novaConta);

            return (true, "Conta Corrente criada com sucesso!");
        }

        public (bool Sucesso, string Mensagem) CriarContaPoupanca(decimal taxaRendimento = 0.005m)
        {
            if (!EstaLogado()) return (false, "Usuário não está logado.");

            if (taxaRendimento <= 0)
                return (false, "A taxa de rendimento deve ser positiva.");

            bool jaPossui = gerenciadorDeConta.ContaPopuancaExiste(ClienteLogado!.Id, BancoDaSessao!.Id);

            if (jaPossui)
            {
                return (false, "Este cliente já possui uma Conta Poupança neste banco.");
            }

            var novaConta = new ContaPoupanca
            {
                Saldo = 0,
                TaxaRendimento = taxaRendimento,
                ClienteId = ClienteLogado!.Id,
                BancoId = BancoDaSessao!.Id
            };

            gerenciadorDeConta.SalvarConta(novaConta);

            return (true, "Conta Poupança criada com sucesso!");
        }

        public (bool Sucesso, string Mensagem) RemoverConta(int contaId)
        {
            if (!EstaLogado()) return (false, "Usuário não está logado.");

            var conta = gerenciadorDeConta.SelecionarConta(contaId);

            if (conta == null)
            {
                return (false, "Conta não encontrada ou não pertence a este cliente.");
            }

            if (conta.Saldo != 0)
            {
                return (false, "Não é possível remover a conta. O saldo deve ser R$ 0,00.");
            }

            gerenciadorDeConta.RemoverConta(contaId);
            
            if (ContaSelecionada?.Id == contaId)
            {
                ContaSelecionada = null;
            }

            return (true, "Conta removida com sucesso.");
        }

        public bool SelecionarConta(int contaId)
        {
            if (!EstaLogado()) return false;

            var conta = gerenciadorDeConta.SelecionarConta(contaId, ClienteLogado!.Id);
            
            if (conta != null)
            {
                ContaSelecionada = conta;
                return true;
            }

            return false;
        }


        private bool ContaEstaSelecionada() => ContaSelecionada != null;
        public (bool Sucesso, string Mensagem) RealizarDeposito(decimal valor)
        {
            if (!ContaEstaSelecionada())
                return (false, "Nenhuma conta selecionada.");

            if (valor <= 0)
                return (false, "O valor do depósito deve ser positivo.");

            var transacao = new Depositar(valor, ContaSelecionada!);
            return gerenciadorDeTransacao.ExecutarTransacao(transacao, "Depósito");
        }

        public (bool Sucesso, string Mensagem) RealizarSaque(decimal valor)
        {
            if (!ContaEstaSelecionada())
                return (false, "Nenhuma conta selecionada.");

            if (valor <= 0)
                return (false, "O valor do saque deve ser positivo.");

            var transacao = new Sacar(valor, ContaSelecionada!);
            return gerenciadorDeTransacao.ExecutarTransacao(transacao, "Saque");
        }

        public (bool Sucesso, string Mensagem) RealizarTransferencia(int idContaDestino, decimal valor)
        {
            if (!ContaEstaSelecionada())
                return (false, "Nenhuma conta de origem selecionada.");

            if (valor <= 0)
                return (false, "O valor da transferência deve ser positivo.");

            if (idContaDestino == ContaSelecionada!.Id)
                return (false, "Não é possível transferir para a mesma conta.");

            var contaDestino = gerenciadorDeConta.SelecionarConta(idContaDestino);
            if (contaDestino == null)
            {
                return (false, "A conta de destino não foi encontrada.");
            }

            var transacao = new Transferir(valor, ContaSelecionada!, contaDestino);
            return gerenciadorDeTransacao.ExecutarTransacao(transacao, "Transferência");
        }
        
    }
}