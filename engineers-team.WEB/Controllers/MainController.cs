using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace engineers_team.WEB.Controllers
{
    public class MainController : Controller
    {
        //
        // GET: /Main/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Team()
        {
            return View();
        }       
        public ActionResult IT()
        {
            return View();
        }
    }
}
