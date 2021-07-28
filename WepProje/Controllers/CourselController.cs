using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PagedList;
using PagedList.Mvc;
using System.Web.Mvc;
using WepProje.Models;

namespace WepProje.Controllers
{
    public class CourselController : Controller
    {
        private BlogContext db = new BlogContext();
        // GET: Coursel
        

        // GET: Blog
        public ActionResult Index()
        {
            var bloglar = db.Bloglar.Select(i => new BlogModel()
            {
                Id = i.Id,
                Baslik = i.Baslik.Length > 10 ? i.Baslik.Substring(0, 10) + "..." : i.Baslik,
                Aciklama = i.Aciklama.Length > 10 ? i.Aciklama.Substring(0, 10) + "..." : i.Aciklama,
                EklenmeTarihi = i.EklenmeTarihi,
                Anasayfa = i.Anasayfa,
                Onay = i.Onay,
                Resim = i.Resim,
                Video = i.Video

            });
            return View(bloglar.ToList());
        }
    }
}