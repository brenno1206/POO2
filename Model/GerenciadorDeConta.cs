using Fintech.Entities;
using Fintech.View;
using Microsoft.EntityFrameworkCore;

namespace Fintech.Model
{
    public class GerenciadorDeConta
    {
        FintechDbContext Contexto;

        public GerenciadorDeConta(FintechDbContext contexto)
        {
            Contexto = contexto;
        }
        
        public bool SalvarConta(Conta conta)
        {
            if (conta == null) return false;

            Contexto.Contas.Add(conta);
            Contexto.SaveChanges();
            return true;
        }

        public Conta? SelecionarConta(int contaId, int clienteId)
        {
            return Contexto.Contas.FirstOrDefault(c =>
                c.Id == contaId &&
                c.ClienteId == clienteId);
        }

        public Conta? SelecionarConta(int contaId) {
            return Contexto.Contas.Find(contaId);
        }

        public List<Conta> SelecionarTodasContas()
        {
            return Contexto.Contas.ToList();
        }

        public List<Conta> ObterContasCliente(int clienteId, int bancoId) {
            return Contexto.Contas
                .Where(c => c.ClienteId == clienteId && c.BancoId == bancoId)
                .ToList();
        }

        public bool AtualizarConta(Conta conta)
        {
            if (conta == null) return false;
            Contexto.Contas.Update(conta);
            Contexto.SaveChanges();
            return true;
        }

        public bool RemoverConta(int id)
        {
            Conta? conta = SelecionarConta(id);
            if (conta == null) return false;

            Contexto.Contas.Remove(conta);
            Contexto.SaveChanges();
            return true;
        }

        public bool ContaCorrenteExiste(int ClienteId, int BancoId) { 
            return Contexto.Contas.Any(c =>
                c.ClienteId == ClienteId &&
                c.BancoId == BancoId &&
                c is ContaCorrente);
        }

        public bool ContaPopuancaExiste(int ClienteId, int BancoId)
        {
            return Contexto.Contas.Any(c =>
                c.ClienteId == ClienteId &&
                c.BancoId == BancoId &&
                c is ContaPoupanca);
        }

    }
}
