using ClassLibrary.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;



namespace Quiron.LojaVirtual.Web.Controllers
{
    public class ProdutoController : Controller
    {
        private ProdutosRepositorio _repositorio;
        // GET: Produto
        public ActionResult Index()
        {
            _repositorio = new ProdutosRepositorio();
            var produtos = _repositorio.Produtos.ToList();

            return View(produtos);
        }
    }
}