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
        public ActionResult Active()
        {
            return View();
        }

        // GET: Petition
        public ActionResult All()
        {
            return View();
        }

        // GET: Petition
        public ActionResult Show(int id)
        {
            ViewBag.PetitionId = id;
            return View();
        }
    }
}