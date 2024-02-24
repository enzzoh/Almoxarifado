using APIALmoxarifado.Properties.Models;
using Microsoft.EntityFrameworkCore;

namespace APIALmoxarifado
{
    public class AlmoxarifadoDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("");
        }

        public DbSet<Produto> Produtos { get; set; }
    }
}
