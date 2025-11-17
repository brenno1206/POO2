namespace Fintech.Entities
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public string Login { get; set; }
        public string Senha { get; set; }

        // Relacionamento: 1 x n
        public virtual ICollection<Conta> Contas { get; set; }
        
        // 1 x 1
        public int BancoId { get; set; }
        public virtual Banco Banco { get; set; }

        public Cliente()
        {
            Contas = new HashSet<Conta>();
        }
    }
}
