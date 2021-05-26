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

        public DbSet<Category> Categories { get; set; }
    }

}