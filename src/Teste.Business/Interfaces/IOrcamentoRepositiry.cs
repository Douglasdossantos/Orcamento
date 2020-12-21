using Orcamento.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Teste.Business.Interfaces
{
    public interface IorcamentoRepositiry : IRepository<Orcamentos>
    {
        Task<IEnumerable<Orcamentos>> ObterOrcamentoCliente(Guid ClienteID);
        Task<Orcamentos> ObterOrcamentoEspecifico(Guid Id);
    }
}
