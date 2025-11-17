namespace Fintech.Entities
{
    public abstract class Conta
    {
        public int Id { get; set; }
        public decimal Saldo { get; set; }
        
        public int BancoId { get; set; }
        public virtual Banco Banco { get; set; }

        public int ClienteId { get; set; }
        public virtual Cliente Cliente { get; set; }

    }
}
