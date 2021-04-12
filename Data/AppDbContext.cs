using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiProdutos.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        { 
        }

        public DbSet<Produtos> Produtos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produtos>()
                .Property(p => p.Nome)
                .HasMaxLength(80);
         
            modelBuilder.Entity<Produtos>()
                .Property(p => p.Preco);
               HasPrecision(10, 2);          
               
            modelBuilder.Entity<Produtos>()
                .HasData(
               new Produtos { Id = 1, Nome = "Caderno", Preco = 7.95M, Estoque = 10 },
               new Produtos { Id = 1, Nome = "Borracha", Preco = 2.45M, Estoque = 30 },
               new Produtos { Id = 1, Nome = "Estojo", Preco = 6.25M, Estoque = 15 });
                           
        }

        private void HasPrecision(int v1, int v2)
        {
            throw new NotImplementedException();
        }
    }
}
