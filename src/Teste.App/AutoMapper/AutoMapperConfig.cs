using AutoMapper;
using Orcamento.Models;
using Teste.App.ViewModels;

namespace Teste.App.AutoMapper
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Cliente, ClienteViewModel>().ReverseMap();
            CreateMap<Produto, ProdutoViewModel>().ReverseMap();
            CreateMap<Orcamentos, OrcamentoViewModel>().ReverseMap();
            CreateMap<OrcamentoProduto, OrcamentoProdutoViewModel>().ReverseMap();
        }
    }
}
