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
    public class HomeController : Controller
    {
       
        private readonly BlogContext context = new BlogContext();
        /*public async Task<ActionResult> Search(string Empsearch)
        {
            ViewData["Getemployeedetails"] = Empsearch;
            IQueryable<Category> empquery = from x in context.Kategoriler select x;
            if (!string.IsNullOrEmpty(Empsearch))
            {
                empquery = empquery.Where(x => x.KategoriAdi.Contains(Empsearch));

            }

            return View(await empquery.AsNoTracking().ToListAsync());
        }*/
        // GET: Home
        public ActionResult Index(int? sayfaNo)
        {
            int _sayfaNo = sayfaNo ?? 1;
            var bloglar = context.Bloglar
                .Select(i=> new BlogModel()
                {
                    Id=i.Id,
                    Baslik=i.Baslik.Length>10? i.Baslik.Substring(0,10) + "...":i.Baslik,
                    Aciklama = i.Aciklama.Length>10? i.Aciklama.Substring(0,10)+"...":i.Aciklama,
                    EklenmeTarihi=i.EklenmeTarihi,
                    Anasayfa =i.Anasayfa,
                    Onay=i.Onay,
                    Resim=i.Resim,
                    Video=i.Video

                })
                .Where(i => i.Onay == true && i.Anasayfa == true).ToList().ToPagedList(_sayfaNo, 12);
            return View(bloglar);
        }
       
        
    }
}