using System.Collections.Generic;
using Teste.Business.Models;

namespace Orcamento.Models
{
    public class Produto :Entity
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        public IEnumerable<OrcamentoProduto> OrcamentoProdutos { get; set; }
    }
}
