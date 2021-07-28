using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WepProje.Models;
using PagedList;
using PagedList.Mvc;
namespace WepProje.Controllers
{
    public class SearchController : Controller
    {
        private readonly BlogContext db = new BlogContext();
        // GET: Search
        public ActionResult Index(string search,int? sayfaNo)
        {
            int _sayfaNo = sayfaNo ?? 1;

            var empquery = db.Bloglar.Select(i => new BlogModel()
            {
                Id = i.Id,
                Baslik = i.Baslik.Length > 10 ? i.Baslik.Substring(0, 10) + "..." : i.Baslik,
                Aciklama = i.Aciklama.Length > 10 ? i.Aciklama.Substring(0, 10) + "..." : i.Aciklama,
                Icerik=i.Icerik.Length > 10 ? i.Icerik.Substring(0, 10) + "..." : i.Icerik,
                EklenmeTarihi = i.EklenmeTarihi,
                Anasayfa = i.Anasayfa,
                Onay = i.Onay,
                Resim = i.Resim
            })
                .Where(x => x.Baslik.Contains(search) && x.Onay == true && x.Anasayfa == true || search == null || x.Icerik== search).ToList().ToPagedList(_sayfaNo, 12);

            return View(empquery);
        }
    }
}