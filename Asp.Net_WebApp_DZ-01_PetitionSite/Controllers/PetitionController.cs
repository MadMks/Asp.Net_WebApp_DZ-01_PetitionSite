using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Asp.Net_WebApp_DZ_01_PetitionSite.Controllers
{
    public class PetitionController : Controller
    {
        // GET: Petition
        public ActionResult Index()
        {
            return View();
        }

        // GET: Petition
        public ActionResult All()
        {
            return View();
        }
    }
}