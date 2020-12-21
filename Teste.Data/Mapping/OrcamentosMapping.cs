using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Orcamento.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Teste.Data.Mapping
{
    public class OrcamentosMapping : IEntityTypeConfiguration<Orcamentos>
    {
        public void Configure(EntityTypeBuilder<Orcamentos> builder)
        {
            builder.ToTable("Orcamentos");
            builder.Property(p => p.Data).HasColumnType("datetime");
           
        }
    }
}
