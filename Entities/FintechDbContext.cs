using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Fintech.Entities
{
    public class FintechDbContext : DbContext
    {
        public DbSet<Conta> Contas { get; set; } = null!;
        public DbSet<Banco> Bancos { get; set; } = null!;
        public DbSet<Cliente> Clientes { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Fintech;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Conta>()
                .Property(c => c.Saldo);

            modelBuilder.Entity<ContaPoupanca>()
                .Property(cp => cp.TaxaRendimento);


            modelBuilder.Entity<ContaCorrente>()
                .Property(cc => cc.LimiteChequeEspecial);

            modelBuilder.Entity<Cliente>()
                .HasMany(c => c.Contas)
                .WithOne(co => co.Cliente)
                .HasForeignKey(co => co.ClienteId)
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();

            modelBuilder.Entity<Banco>()
                .HasMany(b => b.Contas)
                .WithOne(c => c.Banco)
                .HasForeignKey(c => c.BancoId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Banco>()
                .HasMany(b => b.Clientes)
                .WithOne(c => c.Banco)
                .HasForeignKey(c => c.BancoId)
                .OnDelete(DeleteBehavior.Restrict);
        }

    }
}