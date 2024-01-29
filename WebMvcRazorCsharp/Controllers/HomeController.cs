using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMvcRazorCsharp.Models;

namespace WebMvcRazorCsharp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Veiculo()
        {
            ViewBag.Title = "Loja de Vendas de Automóveis!";
            ViewBag.Message = "Compre agora sem taxas!";
            
            var lista = Veiculos.GetCarros();
            ViewBag.Carros = lista;
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}