using APIALmoxarifado.Properties.Models;
using Microsoft.EntityFrameworkCore;

namespace APIALmoxarifado.Infraestrutura
{
    public class ConexaoSQL : DbContext 
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
            =>
              optionBuilder.UseSqlServer(@"Server=sql.bsite.net\MSSQL2016;" +"Database=dbAlmoxarifado;" +"User id=sa;" + "Password=senai.123" );

        public DbSet<Produto> Produto { get; set; }
    }
}
