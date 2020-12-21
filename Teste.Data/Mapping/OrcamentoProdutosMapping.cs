using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Orcamento.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Teste.Data.Mapping
{
    class OrcamentoProdutosMapping : IEntityTypeConfiguration<OrcamentoProduto>
    {
        public void Configure(EntityTypeBuilder<OrcamentoProduto> builder)
        {
            throw new NotImplementedException();
        }
    }
}
