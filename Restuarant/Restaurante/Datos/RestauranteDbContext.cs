using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Restaurante.Datos.Entidades;
namespace Restaurante.Datos
{
    public class RestauranteDbContext:DbContext
    {

        public DbSet<Producto> Productos { get; set; }
        public DbSet<Categorias> Categorias { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;uid=sa;pwd=123;database=restaurnte;" +
                "Trusted_Connection=true;TrustServerCertificate=true");
        }
    }
}
