﻿using ClassLibrary.Repositorio;
using Quiron.LojaVirtual.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Quiron.LojaVirtual.Web.Controllers
{
    public class VitrineController : Controller
    {

        private ProdutosRepositorio _repositorio;

        public int ProdutosPorPagina = 10;
        // GET: Vitrine
        public ActionResult ListaProdutos(int pagina = 1)
        {
            _repositorio = new ProdutosRepositorio();

            ProdutosViewModel model = new ProdutosViewModel()
            {
                Produtos = _repositorio.Produtos.OrderBy(p => p.ProdutoNome)
            .Skip((pagina - 1) * ProdutosPorPagina)
            .Take(ProdutosPorPagina),

                Paginacao = new Paginacao
                {
                    PaginaAtual = pagina,
                    ItensPorPagina = ProdutosPorPagina,
                    ItensTotal = _repositorio.Produtos.Count()

                    //var produtos = _repositorio.Produtos.OrderBy(p => p.ProdutoNome)
                    //.Skip((pagina - 1) * ProdutosPorPagina)
                    //.Take(ProdutosPorPagina);

                }


            };
            return View(model);
        }
    }
}