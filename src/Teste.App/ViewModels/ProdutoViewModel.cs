using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Teste.App.ViewModels
{
    public class ProdutoViewModel
    {
        [Key]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "o campo {0} é Obrigatório")]
        [StringLength(200, ErrorMessage = "OCampo {0} précisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "o campo {0} é Obrigatório")]
        public decimal Preco { get; set; }

       // public IEnumerable<OrcamentoProdutoViewModel> OrcamentoProdutos { get; set; }
    }
}
