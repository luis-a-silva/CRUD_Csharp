using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebMvcRazorCsharp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "VeiculosSalvar",//nome da rota
                "Veiculos/Salvar",//rota em si
                new {controller = "Veiculos", action = "Salvar"});//controler e ActionResult
           
            routes.MapRoute(
                "VeiculosAlterar",
                "Veiculos/Alterar/:id",
                new { controller = "Veiculos", action = "Alterar", id = 0 });

            routes.MapRoute(
                "VeiculosExcluir",
                "Veiculos/Excluir/:id",
                new { controller = "Veiculos", action = "Excluir", id = 0 });

            routes.MapRoute(
                "Veiculos",
                "veiculos/adicionar",
                new { controller = "Veiculos", action = "Adicionar", id = UrlParameter.Optional });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
