using mo_apps.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mo_apps.Controllers
{
    public class HomeController : Controller
    {
        public Context _context { get; set; }
        public HomeController()
        {
            this._context = new Context();
        }

        public ActionResult Index()
        {
            
            return View();
        }
        
    }
}