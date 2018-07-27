using HelperMethods.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelperMethods.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Sugestao()
        {
            return View(new Sugestao());
        }

        [HttpPost]
        public ActionResult Sugestao(Sugestao s)
        {
            return View(s);
        }

        public ActionResult Produto()
        {
            Produto p1 = new Produto()
            {
                Id = 0,
                Valor = 45.00,
                Nome = "Câmera",
                Descricao = "Câmera HD com 12.5 MP"
            };

            Produto p2 = new Produto()
            {
                Id = 1,
                Valor = 12.00,
                Nome = "Caderno",
                Descricao = "Caderno 10 matérias"
            };
            List<Produto> lista = new List<Produto>
            {
                p1,
                p2
            };
            ViewBag.Dados = lista;

            return View();
        }
    }
}