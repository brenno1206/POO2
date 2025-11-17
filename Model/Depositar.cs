using Fintech.Entities;
namespace Fintech.Model
{
    internal class Depositar : ITransacao
    {
        decimal Valor;
        Conta Proprietario;
        public Depositar(decimal valor, Conta proprietario)
        {
            Valor = valor;
            Proprietario = proprietario;
        }
        public bool RealizarTransacao()
        {
            if (Valor <= 0) return false;
            Proprietario.Saldo += Valor;
            return true;
        }
    }
}
