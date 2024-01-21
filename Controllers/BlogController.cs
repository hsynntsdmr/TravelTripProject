using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models;

namespace TravelTripProject.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        Context context = new Context();
        BlogYorum by = new BlogYorum();
        public ActionResult Index()
        {
            by.blogList = context.Blogs.ToList();

            by.sonBlogList = context.Blogs.OrderByDescending(x=> x.ID).Take(3).ToList();

            return View(by);
        }
       
        public ActionResult BlogDetay(int id)
        {                            

            by.blogList = context.Blogs.Where(x => x.ID == id).ToList();

            by.yorumList = context.Yorums.Where(y => y.Blogid == id).ToList();    

            return View(by);
        }

        [HttpGet]
        public PartialViewResult YorumYap(int id)
        {
            ViewBag.deger = id;
          
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult YorumYap(Yorum p)
        {
            context.Yorums.Add(p);
            context.SaveChanges();

            return PartialView();
        }
    }
}