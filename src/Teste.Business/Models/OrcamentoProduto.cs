using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teste.Business.Models;

namespace Orcamento.Models
{
    public class OrcamentoProduto:Entity
    {
        public Guid OrcamentoId { get; set; }
        public Guid ProdutoId { get; set; }
        public Produto Produto { get; set; }
        public Orcamentos Orcamento { get; set; }
    }
}
