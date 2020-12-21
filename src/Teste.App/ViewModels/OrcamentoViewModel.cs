using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Teste.App.ViewModels
{
    public class OrcamentoViewModel
    {
        public OrcamentoViewModel()
        {
            Data = DateTime.Now;
        }

        [Key]
        public Guid Id { get; set; }
        public ClienteViewModel Cliente { get; set; }

        [ScaffoldColumn(false)]
        public DateTime Data { get; set; }


        public IEnumerable<OrcamentoProdutoViewModel> OrcamentoProdutos { get; set; }
    }
}
