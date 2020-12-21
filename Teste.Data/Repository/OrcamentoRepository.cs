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
    public class OrcamentoRepository : Repository<Orcamentos>, IorcamentoRepositiry
    {
        public OrcamentoRepository(TesteDbContext context) : base(context) { }

        public async Task<IEnumerable<Orcamentos>> ObterOrcamentoCliente(Guid ClienteID)
        {
            return await Db.Orcamentos.AsNoTracking()
                .Include(p => p.OrcamentoProdutos)
                .Where(w => w.ClienteId == ClienteID)
                .ToListAsync();
        }
        public async Task<Orcamentos> ObterOrcamentoEspecifico(Guid Id)
        {
            return await Db.Orcamentos.AsNoTracking().FirstOrDefaultAsync(p =>p.Id == Id);
        }
    }
}
