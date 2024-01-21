using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models;

namespace TravelTripProject.Controllers
{
    public class HomeController : Controller
    {
        Context context = new Context();
        public ActionResult Index()
        {
            var degerler = context.Blogs.OrderByDescending(i=> i.ID).Take(5).ToList();

            return View(degerler);
        }

        public PartialViewResult Partial1()
        {
            var degerler = context.Blogs.OrderByDescending(x => x.ID).Take(3).ToList();

            return PartialView(degerler);
        }

        public PartialViewResult Partial2()
        {
            var degerler = context.Blogs.Take(10).ToList();

            return PartialView(degerler);
        }

        public PartialViewResult Partial3()
        {
            var degerler = context.Blogs.Take(3).ToList();

            return PartialView(degerler);
        }


        public PartialViewResult Partial4()
        {
            var degerler = context.Blogs.OrderByDescending(x => x.ID).Take(3).ToList();

            return PartialView(degerler);
        }

        public ActionResult About()
        {
           

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

     
    }
}