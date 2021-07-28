using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WepProje.Models;
using PagedList;
using PagedList.Mvc;

namespace WepProje.Controllers
{
    public class CategoriyBlogController : Controller
    {
        private  BlogContext db = new BlogContext();
        private readonly BlogContext context = new BlogContext();
        // GET: CategoriyBlog
        public ActionResult Index()
        {
            var kategoriler = db.Kategoriler.Select(i => new KtgBlogModel()
            {

                Id = i.Id,
                CategoriAdi = i.KategoriAdi,
                KategoriResim=i.KategoriResim,

            });
            return View(kategoriler.ToList());
        }
        public ActionResult KategoriBlog(int? id , int? sayfaNo)
        {

            int _sayfaNo = sayfaNo ?? 1;
            var bloglar = context.Bloglar.Where(i => i.Onay== true  && i.Anasayfa == true && i.CategoryId == id).ToList().ToPagedList(_sayfaNo, 12);
            return View(bloglar);

        }
    }
}