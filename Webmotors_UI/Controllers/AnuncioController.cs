using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webmotors.Application.Aplication;
using Webmotors.Application.Interfaces;
using Webmotors.Application.Model;
using Webmotors.ioc;

namespace Webmotors_UI.Controllers
{
    public class AnuncioController : Controller
    {
        MarcaApplication marcaApplication;
        ModeloApplication modeloApplication;
        VersaoApplication versaoAplication;

        IAnuncioApplication _anuncioApplication;

        public AnuncioController()
        {
            marcaApplication = new MarcaApplication();
            modeloApplication = new ModeloApplication();
            versaoAplication = new VersaoApplication();

            _anuncioApplication = SimpleInjectorContainer.Container.GetInstance<IAnuncioApplication>();
        }

        // GET: Anuncio
        public ActionResult Index()
        {
            var anuncios = _anuncioApplication.listAnuncios();
            return View(anuncios);
        }

        public ActionResult Create()
        {
            ViewBag.Marca = marcaApplication.GetMarcas();
            return View();
        }

        [HttpPost]
        public ActionResult Create(AnuncioModel anuncio)
        {
            if (ModelState.IsValid)
            {
                _anuncioApplication.CreateAnuncio(anuncio);
            }
            else
            {

            }
            return View();
        }

        public ActionResult DeleteAnuncio(string id)
        {
            return View();
        }

        public ActionResult ConfirmDeleteAnuncio(string id)
        {
            return View();
        }

        public ActionResult DetailsAnuncio(string id) {


            return View();
        }

        public ActionResult EditAnuncio(string id)
        {
            return View();
        }
        public ActionResult ConfirmEdition()
        {
            return View();
        }

        public string GetModelo(string id)
        {
            var modelos = modeloApplication.GetModelosString(id);

            return modelos;
        }

        public string GetVersao(string id)
        {
            var versoes = versaoAplication.GetVersoesString(id);

            return versoes;
        }

        public string GetMarcas()
        {
            return marcaApplication.GetMarcasString();
        }
    }
}