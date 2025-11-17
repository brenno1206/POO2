using Fintech.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Fintech.Model
{
    public class GerenciadorDeCliente
    {
        FintechDbContext Contexto;

        public GerenciadorDeCliente(FintechDbContext contexto)
        {
            Contexto = contexto;
        }

        public bool SalvarCliente(Cliente cliente) {
            if ( cliente == null ) return false;

            Contexto.Clientes.Add( cliente );
            Contexto.SaveChanges();
            return true;
        }
        public Cliente? SelecionarCliente(int id)
        {
            Cliente? cliente = Contexto.Clientes
                .Include(c => c.Contas)
                .Include(c => c.Banco)
                .FirstOrDefault(c => c.Id == id);
            return cliente;
        }

        public bool loginExiste(string login, int bancoId) {
            return Contexto.Clientes
                .Any(c => c.Login == login && c.BancoId == bancoId);
        }

        public (Banco? banco, Cliente? cliente) realizarLogin(string login, string senha, int bancoId) {
            string connectionString = Contexto.Database.GetConnectionString();

            if (string.IsNullOrEmpty(connectionString))
            {
                throw new InvalidOperationException("Não foi possível obter a string de conexão do DbContext.");
            }
            Cliente? cliente = null;
            Banco? banco = null;
            string query = @"
                SELECT 
                    c.Id AS ClienteId, c.Nome AS ClienteNome, c.Login, c.Senha, c.BancoId,
                    b.Nome AS BancoNome 
                FROM 
                    Clientes c
                INNER JOIN 
                    Bancos b ON c.BancoId = b.Id
                WHERE 
                    c.Login = @login 
                    AND c.Senha = @senha 
                    AND c.BancoId = @bancoId;";

            using (var connection = new SqlConnection(connectionString))
            {
                using var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@login", login);
                command.Parameters.AddWithValue("@senha", senha);
                command.Parameters.AddWithValue("@bancoId", bancoId);

                try
                {
                    connection.Open();

                    using var reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        banco = new Banco
                        {
                            Id = bancoId,
                            Nome = reader["BancoNome"].ToString(),
                            Contas = new HashSet<Conta>(),
                            Clientes = new HashSet<Cliente>()
                        };

                        cliente = new Cliente
                        {
                            Id = (int)reader["ClienteId"],
                            Nome = reader["ClienteNome"].ToString(),
                            Login = reader["Login"].ToString(),
                            Senha = reader["Senha"].ToString(),
                            BancoId = (int)reader["BancoId"],
                            Banco = banco,
                            Contas = new HashSet<Conta>()
                        };
                        banco.Clientes.Add(cliente);
                    }
                }
                catch (SqlException ex)
                {
                    return (null, null);
                }
            }

            if (cliente == null)
            {
                return (null, null);
            }
            return (banco, cliente);
        }

        public List<Cliente> SelecionarTodosClientes()
        {
            return Contexto.Clientes.ToList();
        }

        public bool AtualizarCliente(Cliente cliente)
        {
            if (cliente == null) return false;

            Contexto.Clientes.Update(cliente);
            Contexto.SaveChanges();
            return true;
        }

        public bool RemoverCliente(int id)
        {
            Cliente? cliente = SelecionarCliente(id);
            if (cliente == null) return false;

            Contexto.Clientes.Remove(cliente);
            Contexto.SaveChanges();
            return true;
        }
    }
}
