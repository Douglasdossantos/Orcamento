using Orcamento.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Teste.Business.Interfaces
{
    public interface IProdutoRepository : IRepository<Produto>
    {
        Task<IEnumerable<Produto>> ObterTodosProduto();
        Task<Produto> ObterProdutoNome(string Nome);
        Task<Produto> ObterProdutosID(Guid id);
    }
}
