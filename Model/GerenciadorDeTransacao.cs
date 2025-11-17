using Fintech.Entities;
using Microsoft.EntityFrameworkCore;

namespace Fintech.Model
{
    public class GerenciadorDeTransacao
    {
        FintechDbContext Contexto;

        public GerenciadorDeTransacao(FintechDbContext contexto)
        {
            Contexto = contexto;
        }
        public (bool Sucesso, string Mensagem) ExecutarTransacao(ITransacao transacao, string nomeOperacao)
        {
            try
            {
                if (transacao.RealizarTransacao())
                {
                    Contexto.SaveChanges();
                    return (true, $"Transação de {nomeOperacao} realizada com sucesso.");
                }
                else
                {
                    return (false, $"Falha ao realizar {nomeOperacao}. Saldo ou limite insuficiente.");
                }
            }
            catch (Exception ex)
            {
                return (false, $"Ocorreu um erro inesperado no banco ao tentar {nomeOperacao} {ex.Message}.");
            }
        }
    }
}