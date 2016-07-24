using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BoletoMVC.Controllers
{
    public class BoletoController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Exibir1()
        {
            ViewBag.Message = "Exemplo de exebição";

            return View();
        }

        public ActionResult Exibir2()
        {
            ViewBag.Message = "Exemplo de exebição";

            return View();
        }

        public ActionResult Remessa()
        {
            ViewBag.Message = "Exemplo de remessa";

            return View();
        }
    }
}