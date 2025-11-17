using Fintech.Entities;

namespace Fintech.Model
{
    internal class Transferir : ITransacao
    {
        decimal Valor;
        Conta Proprietario;
        Conta Recebedor;
        public Transferir(decimal valor, Conta proprietario, Conta recebedor)
        {
            Valor = valor;
            Proprietario = proprietario;
            Recebedor = recebedor;
        }

        public bool RealizarTransacao()
        {
            Sacar sacar = new(Valor, Proprietario);
            if (sacar.RealizarTransacao())
            {
                Depositar depositar = new(Valor, Recebedor);
                depositar.RealizarTransacao();
                return true;
            }
            return false;
        }
    }
}
