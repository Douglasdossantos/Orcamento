using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Teste.App.ViewModels
{
    public class OrcamentoProdutoViewModel
    {
        public Guid OrcamentoId { get; set; }
        public Guid ProdutoId { get; set; }
        public ProdutoViewModel Produto { get; set; }
        public OrcamentoViewModel Orcamento { get; set; }
    }
}
