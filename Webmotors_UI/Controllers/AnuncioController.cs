using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webmotors.Application.Aplication;

namespace Webmotors_UI.Controllers
{
    public class AnuncioController : Controller
    {
        // GET: Anuncio
        public ActionResult Index()
        {
            RequestWS req = new RequestWS();
            req.SendGetRequest("http://desafioonline.webmotors.com.br/api/OnlineChallenge/Make");
            return View();
        }
    }
}