using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models;

namespace TravelTripProject.Controllers
{
    public class AboutController : Controller
    {
        Context context = new Context();
        // GET: About
        public ActionResult Index()
        {
            var degerler = context.Hakkimizdas.ToList();
            return View(degerler);
        }
    }
}