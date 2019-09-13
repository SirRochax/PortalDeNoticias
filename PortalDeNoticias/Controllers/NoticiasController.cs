using PortalDeNoticias.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortalDeNoticias.Controllers
{
    public class NoticiasController : Controller
    {
        public ActionResult Index()
        {
            return View(RepositorioNoticias.Noticias);
        }

        public ActionResult Detalhes(int id)
        {
            var noticias = RepositorioNoticias.Noticias.FirstOrDefault(n => n.ID == id);
            return View(noticias);
        }

        public ActionResult Buscar(string texto)
        {
            var noticias = RepositorioNoticias.Noticias.Where(n => n.Titulo.Contains(texto) || n.Titulo.Contains(texto));
            return View(noticias);
        }
    }
}
