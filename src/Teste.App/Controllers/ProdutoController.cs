using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Orcamento.Models;
using Teste.App.ViewModels;
using Teste.Business.Interfaces;

namespace Teste.App.Controllers
{
    public class ProdutoController : BaseController
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly IMapper _mapper;

        public ProdutoController(IProdutoRepository produtoRepository, IMapper mapper)
        {
            _produtoRepository = produtoRepository;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            return View(_mapper.Map<IEnumerable<ProdutoViewModel>> (await _produtoRepository.ObterTodosProduto()));
        }

        public async Task<IActionResult> Details(Guid? id)
        {
            var produto = _mapper.Map<IEnumerable<ProdutoViewModel>>(await _produtoRepository.ObterProdutosID(Guid.Parse(id.ToString())));
            if (produto == null)
            {
                return NotFound();
            }
            return View(produto);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProdutoViewModel produtoViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(produtoViewModel);
            }
            var produto = _mapper.Map<Produto>(produtoViewModel);
            await _produtoRepository.Adicionar(produto);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(Guid? id)
        {
            var produto = ObterProdutosId(Guid.Parse(id.ToString()));
            if (produto == null)
            {
                return NotFound();
            }

            return View(produto);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, ProdutoViewModel produtoViewModel)
        {
            if (id != produtoViewModel.Id)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                return View(produtoViewModel);
            }
            var produto = _mapper.Map<Produto>(produtoViewModel);
            await _produtoRepository.Atualizar(produto);

            return RedirectToAction("Index");
        }

        // GET: Produto/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            var produto = await ObterProdutosId(Guid.Parse(id.ToString()));
            if (produto == null)
            {
                return NotFound();
            }

            return View(produto);
        }

        // POST: Produto/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var produto = await ObterProdutosId(Guid.Parse(id.ToString()));
            if (produto == null)
            {
                return NotFound();
            }
            await _produtoRepository.Remover(id);
            return RedirectToAction(nameof(Index));
        }

        private async Task<ProdutoViewModel> ObterProdutosId(Guid Id)
        {
            return (ProdutoViewModel)_mapper.Map<IEnumerable<ProdutoViewModel>>( await _produtoRepository.ObterProdutosID(Guid.Parse(Id.ToString())));
        }
    }
}
