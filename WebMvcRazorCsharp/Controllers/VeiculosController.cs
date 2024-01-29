using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMvcRazorCsharp.Models;

namespace WebMvcRazorCsharp.Controllers
{
    public class VeiculosController : Controller
    {
        // GET: Veiculos
        public ActionResult Adicionar()
        {
            ViewBag.Title = "Cadastro";
            ViewBag.Message = "Cadastro veículos";
            return View();
        }
        public ActionResult Excluir(int id)
        {
            ViewBag.Title = "Excluir";
            ViewBag.Message = "Excluir veículos" + id;

            var veiculo = new Veiculos();
            veiculo.Id = Convert.ToInt32(Request["0" + "id"]);
            veiculo.GetVeiculos(id);
            ViewBag.Veiculo = veiculo;
            return View();
        }

        public ActionResult Alterar(int id)
        {
            ViewBag.Title = "Alterar";
            ViewBag.Message = "Alterar veículos" + id;

            var veiculo = new Veiculos();
            veiculo.Id = Convert.ToInt32(Request["id"]);
            veiculo.GetVeiculos(id);
            ViewBag.Veiculo = veiculo;
            return View();
        }

        [HttpPost]
        public void Salvar()
        {
            var veiculo = new Veiculos();
            veiculo.Id = Convert.ToInt32("0" + Request["id"]);
            veiculo.Nome = Request["nome"];
            veiculo.Modelo = Request["Modelo"];
            veiculo.Ano = Convert.ToInt16(Request["fabricacao"]);
            veiculo.Fabricacao = Convert.ToInt16(Request["fabricacao"]);
            veiculo.Cor = Request["cor"];
            veiculo.Combustivel = Convert.ToByte(Request["combustivel"]);
            veiculo.Automatico = false;
            veiculo.Valor = Convert.ToDecimal(Request["valor"]);
            veiculo.Ativo = true;

            veiculo.Salvar();
            Response.Redirect("/Home/Veiculo");
        }

        [HttpPost]
        public void Excluir()
        {
            var veiculo = new Veiculos();
            veiculo.Id = Convert.ToInt32("0" + Request["id"]);
            veiculo.Excluir();
            Response.Redirect("/Home/Veiculo");
        }
    }
}