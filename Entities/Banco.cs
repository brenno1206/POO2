namespace Fintech.Entities
{
    public class Banco
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        // 1 X N
        public virtual ICollection<Conta> Contas { get; set; }
        
        // 1 X N
        public virtual ICollection<Cliente> Clientes { get; set; }

        public Banco()
        {
            Contas = new HashSet<Conta>();
            Clientes = new HashSet<Cliente>();
        }
    }
}
