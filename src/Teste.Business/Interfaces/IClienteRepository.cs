using Orcamento.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Teste.Business.Interfaces
{
    public interface IClienteRepository : IRepository<Cliente>
    {
        Task<Cliente> ObterClientePorNome(string Nome);
        Task<IEnumerable<Cliente>> ObterOrcamentoClientes(Guid Id);
    }
}
