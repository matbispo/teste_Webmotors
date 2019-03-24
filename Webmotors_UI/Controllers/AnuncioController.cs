using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webmotors.Application.Aplication;
using Webmotors.Application.Model;

namespace Webmotors_UI.Controllers
{
    public class AnuncioController : Controller
    {
        MarcaApplication marcarApplication;
        public AnuncioController()
        {
            marcarApplication = new MarcaApplication();
        }
        // GET: Anuncio
        public ActionResult Index()
        {
            // listar todos os anuncios
            // validar se o objeto nao esta vazio

            var anuncios = new List<AnuncioModel>();
            return View(anuncios);
        }

        public ActionResult Create()
        {
            ViewData["Marcas"] = marcarApplication.GetMarcas();
            return View();
        }
    }
}