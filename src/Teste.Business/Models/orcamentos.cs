using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Teste.Business.Models;

namespace Orcamento.Models
{
    public class Orcamentos :Entity
    {
        public Guid ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime Data { get; set; }


        public IEnumerable<OrcamentoProduto> OrcamentoProdutos { get; set; }
    }
}
