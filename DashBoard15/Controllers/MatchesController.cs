using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DashBoard15.DAL;
using DashBoard15.Models;

namespace DashBoard15.Controllers
{
    public class MatchesController : Controller
    {
        //
        // GET: /Matches/
        
        AppContext db = new AppContext();

        public ActionResult NewMatch()
        {
            return PartialView();
        }

        [HttpPost]
       
        public ActionResult NewMatch(NewMatch match)
        {
            if (ModelState.IsValid)
            {
                db.Matches.Add(match);
                db.SaveChanges();                
            }
            return PartialView();
        }
        public ActionResult ListMatch()
        {
            return PartialView();
        }

    }
}
