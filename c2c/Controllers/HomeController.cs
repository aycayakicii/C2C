using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace c2c.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            BlogContext db = new BlogContext();

            ///////////////////////////////////////
            //Blog b2 = new Blog();
            //b2.Baslik = "Merhaba";
            //b2.Görsel = "#";
            //b2.Tarih = "09/07/2018";


            //BlogContext context = new BlogContext();
            //context.Bloglar.Add(b2);
            //context.SaveChanges();

            ////////////////////////////////////////////////////



            //Blog b1 = new Blog();
            //b1.
            //db.BlogEntry.Add(u1);
            //db.SaveChanges();

            /////////////////////
            //Blog b1 = new Blog();
            //b1.Baslik = "Java";
            //b1.Yazi = "jskhhıashıdjfısjfıhgskhhıashıdjfısjfıhgı hsgıhf odıskhhıash ıdjfısjfıhg ıhsgıhf odıskhhı ashıdjfı sjfıhgıh sgıhfodı skhhıashıdjfısjfıhg ıhsgıhfodııhsgıhfodıfh";
            //b1.Tarih = "14.06.2018";
            


            //BlogContext context = new BlogContext();
            //context.Bloglar.Add(b1);
            //context.SaveChanges();
            ///////////////////////////


            //BlogContext db = new BlogContext();
            var yazi = db.Bloglar.Find(2);

            if (yazi != null) 
            {
                db.Bloglar.Remove(yazi);
            }
            db.SaveChanges();

            var blog = from t in db.Bloglar
                           //where t.Id == 2
                       select t;


            return View(blog.ToList());

         
        }

        public ActionResult Hakkimizda()
        {
            return View();
        }

        public ActionResult Iletisim()
        {
            return View();
        }

        [HttpGet]
        public ActionResult BlogEkle()
         {
            return View();
        }
        [HttpPost]
        public ActionResult BlogEkle(string Baslik, string Görsel, string Yazi, string Tarih)
        {
            Blog b1 = new Blog();
            b1.Baslik = Baslik;
            b1.Yazi = Yazi;
            b1.Tarih = Tarih;



            BlogContext context = new BlogContext();
            context.Bloglar.Add(b1);
            context.SaveChanges();
            return View();
        }


        public ActionResult BlogOku(int Id)
        {
            
            BlogContext db = new BlogContext();
            
            var blog = from t in db.Bloglar
                           where t.Id == Id
                       select t;
            

            return View(blog.ToList());

        }
    }


   


}