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
        private IMarcaApplication _marcaApplication;
        private IModeloApplication _modeloApplication;
        private IVersaoApplication _versaoAplication;

        private IAnuncioApplication _anuncioApplication;

        public AnuncioController()
        {
            _marcaApplication = SimpleInjectorContainer.Container.GetInstance<IMarcaApplication>();
            _modeloApplication = SimpleInjectorContainer.Container.GetInstance<IModeloApplication>();
            _versaoAplication = SimpleInjectorContainer.Container.GetInstance<IVersaoApplication>();

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
            return View();
        }

        [HttpPost]
        public ActionResult Create(AnuncioModel anuncio)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _anuncioApplication.CreateAnuncio(anuncio);
                }
                else
                {
                    return View(anuncio);
                }

                return RedirectToAction("Index");
            }
            catch (Exception)
            {

                return View();
            }
        }

        public ActionResult DeleteAnuncio(string id)
        {
            _anuncioApplication.DeleteAnuncio(Convert.ToInt32(id));

            return RedirectToAction("Index");
        }

        public ActionResult DetailsAnuncio(string id) {

            var anuncio = _anuncioApplication.GetById(Convert.ToInt32(id));
            return View(anuncio);
        }

        public ActionResult EditAnuncio(string id)
        {
            AnuncioModel anuncio;
            try
            {
                anuncio = _anuncioApplication.GetById(Convert.ToInt32(id));
            }
            catch (Exception e)
            {

                throw;
            }

            return View(anuncio);
        }
        [HttpPost]
        public ActionResult EditAnuncio(AnuncioModel anuncio)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _anuncioApplication.EditAnuncio(anuncio);
                }
                else
                {
                    return View(anuncio);
                }
                return RedirectToAction("index");
            }
            catch (Exception e)
            {
                return View();
            }
        }

        public string GetModelo(string id)
        {
            var modelos = _modeloApplication.GetModelosString(id);

            return modelos;
        }

        public string GetVersao(string id)
        {
            var versoes = _versaoAplication.GetVersoesString(id);

            return versoes;
        }

        public string GetMarcas()
        {
            return _marcaApplication.GetMarcasString();
        }
    }
}