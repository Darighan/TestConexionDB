using Microsoft.EntityFrameworkCore;
using MySql.EntityFrameworkCore;
namespace TestConexionDB.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string nombreCliente { get; set; }

    }

    public class ClienteContext : DbContext 
    {
        public DbSet<Cliente> Cliente { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseMySQL("server=localhost;database=testcanchas;user=root;password=");
        }


    }


}
