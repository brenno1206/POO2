using Fintech.Entities;

namespace Fintech.Model
{
    internal class Sacar : ITransacao
    {
        decimal Valor;
        Conta Proprietario;
        public Sacar(decimal valor, Conta proprietario)
        {
            Valor = valor;
            Proprietario = proprietario;
        }
        public bool RealizarTransacao()
        {
            decimal max = Proprietario.Saldo;

            if (Proprietario is ContaCorrente contaCorrente)
            { max += contaCorrente.LimiteChequeEspecial; }

            if (Valor > max)
            { return false; }

            Proprietario.Saldo -= Valor;
            return true;
        }
    }
}
