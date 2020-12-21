using Microsoft.EntityFrameworkCore;
using Orcamento.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Teste.Data.Context
{
    public class TesteDbContext : DbContext
    {
        public TesteDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Orcamentos> Orcamentos { get; set; }
        public DbSet<OrcamentoProduto> OrcamentoProdutos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {            
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TesteDbContext).Assembly);

            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.ClientSetNull;
            }

            base.OnModelCreating(modelBuilder);
        }
    }
}
