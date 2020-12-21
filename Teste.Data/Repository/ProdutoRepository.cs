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
    public class ProdutoRepository : Repository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(TesteDbContext context) : base(context) { }
        public  async Task<Produto> ObterProdutoNome(string Nome)
        {
            return await Db.Produtos.AsNoTracking().FirstOrDefaultAsync(p => p.Nome == Nome);
        }

        public async Task<Produto> ObterProdutosID(Guid id)
        {
            return await Db.Produtos.AsNoTracking().FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<IEnumerable<Produto>> ObterTodosProduto()
        {
            return await Db.Produtos.AsNoTracking().OrderBy(p => p.Nome).ToListAsync();
        }
    }
}
