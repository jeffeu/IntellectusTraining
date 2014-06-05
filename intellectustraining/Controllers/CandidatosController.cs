using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace intellectustraining.Controllers
{
    public class CandidatosController : Controller
    {
        //
        // GET: /Candidates/
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Novo()
        {
            return View();
        }

	}
}