using Catalog.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Catalog.App.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            ViewData["teams"] = DataService.Teams;
            ViewData["people"] = DataService.People;

            return View();
        }
    }
}
