using Microsoft.EntityFrameworkCore;

using modalmais_a.Models;
namespace modalmais_a.Data
{
    public class DataContext : DbContext
    {
        //estou usando bd em memória.se fosse um banco mesmo ficaria aqui a string de conexão
        public DataContext(DbContextOptions<DataContext> options)
        : base(options)
        {

        }
        //Aqui são informados as tabelas que serão usada na api. No nosso exemplo apenas teremos a tabela de clientes
        public DbSet<Clientes> Clientes { get; set; }
    }

}


