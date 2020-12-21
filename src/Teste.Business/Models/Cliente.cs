using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Teste.Business.Models;

namespace Orcamento.Models
{
    public class Cliente : Entity
    {
        public string  Nome { get; set; }
     
        public string Telefone{ get; set; }

        public IEnumerable<Orcamentos> Orcamentos { get; set; }

    }
}
