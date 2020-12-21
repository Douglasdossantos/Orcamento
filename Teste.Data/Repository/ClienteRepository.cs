using Microsoft.EntityFrameworkCore;
using Orcamento.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste.Business.Interfaces;
using Teste.Data.Context;

namespace Teste.Data.Repository
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        public ClienteRepository(TesteDbContext context) :base(context) {}
        public async Task<Cliente> ObterClientePorNome(string Nome)
        {
            return await Db.Clientes.AsNoTracking()
                .FirstOrDefaultAsync(p => p.Nome == Nome);
        }

        public async Task<IEnumerable<Cliente>> ObterOrcamentoClientes(Guid Id)
        {
            return await Db.Clientes.AsNoTracking()
                .Include(o => o.Orcamentos)
                .Where(p => p.Id == Id)
                .ToListAsync();
        }
    }
}
