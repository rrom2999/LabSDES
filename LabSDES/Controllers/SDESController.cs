using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LabSDES.Models;

namespace LabSDES.Controllers
{
    public class SDESController : Controller
    {
        // GET: SDES
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CargaParaCifrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CargaParaCifrar(HttpPostedFileBase ACifrar, string Clave)
        {
            SDES NSDES = new SDES();

            return View();
        }

        public ActionResult CargaParaDescifrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CargaParaDescifrar(HttpPostedFileBase ADescifrar, string Clave)
        {
            return View();
        }
    }
}