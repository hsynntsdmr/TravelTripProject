using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models;
namespace TravelTripProject.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context context = new Context();
        [Authorize]
        public ActionResult Index()
        {
            var degerler = context.Blogs.ToList();

            return View(degerler);
        }
        [Authorize]
        [HttpGet]
        public ActionResult YeniBlog()
        {
           

            return View();
        }
       
        [HttpPost]
        public ActionResult YeniBlog(Blog p)
        {
          context.Blogs.Add(p);
          context.SaveChanges();

            return Redirect("/Admin/Index");
        }

        [Authorize]
        public ActionResult BlogGetir(int id)
        {
            var degerler = context.Blogs.Find(id);


            return View("BlogGetir", degerler);
        }
       
        [HttpPost]
        public ActionResult BlogGuncelle(Blog b)
        {
            var blg  = context.Blogs.Find(b.ID);
            blg.Aciklama = b.Aciklama;
            blg.Baslik = b.Baslik;
            blg.BlogImage = b.BlogImage;
            blg.Tarih = b.Tarih;

            context.SaveChanges();

            return RedirectToAction("Index");
        }

        [Authorize]
        public ActionResult BlogSil(int id)
        {
            var degerler = context.Blogs.Find(id);
            context.Blogs.Remove(degerler);
            context.SaveChanges();

            return Redirect("/Admin/Index");
        }
        [Authorize]
        public ActionResult YorumListesi()
        {
            var degerler = context.Yorums.ToList();

            return View(degerler);
        }
        [Authorize]
        public ActionResult YorumSil(int id)
        {
            var degerler = context.Yorums.Find(id);
            context.Yorums.Remove(degerler);
            context.SaveChanges();

            return Redirect("/Admin/YorumListesi");
        }
        [Authorize]
        public ActionResult YorumGetir(int id)
        {
            var degerler = context.Yorums.Find(id);


            return View("YorumGetir", degerler);
        }
        [Authorize]
        [HttpPost]
        public ActionResult YorumGuncelle(Yorum y)
        {
            var yrm = context.Yorums.Find(y.Id);
            yrm.KullaniciAdi = y.KullaniciAdi;
            yrm.Mail = y.Mail;
            yrm.BlogYorum = y.BlogYorum;
           
            context.SaveChanges();

            return RedirectToAction("YorumListesi");
        }
    }
}