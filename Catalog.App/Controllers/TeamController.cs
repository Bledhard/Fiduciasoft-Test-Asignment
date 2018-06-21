using Catalog.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Catalog.App.Controllers
{
    public class TeamController : Controller
    {

        public ActionResult TeamDetails(string teamName)
        {
            ViewBag.Title = "Team Detail";

            ViewData["team"] = DataService.Teams.Where(t => t.Name == teamName).FirstOrDefault();
            ViewData["members"] = DataService.People.Where(p => p.Team != null && p.Team.Name == teamName).ToList();
            ViewData["peopleWithoutTeam"] = DataService.People.Where(p => p.Team == null).ToList();

            return View();
        }
    }
}
