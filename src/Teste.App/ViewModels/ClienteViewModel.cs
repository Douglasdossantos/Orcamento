using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Teste.App.ViewModels
{
    public class ClienteViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage ="o campo {0} é OBrigatório")]
        [StringLength(200, ErrorMessage ="OCampo {0} précisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "o campo {0} é OBrigatório")]
        [StringLength(20, ErrorMessage = "OCampo {0} précisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Telefone { get; set; }

        public IEnumerable<OrcamentoViewModel> Orcamentos { get; set; }
    }
}
