using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WepProje.Models;

namespace WepProje.Controllers
{
    public class CategoryController : Controller
    {
        private readonly BlogContext db = new BlogContext();

  

     /* public async Task<ActionResult> Index(string Empsearch)
        {
            ViewData["Getemployeedetails"] = Empsearch;
            IQueryable<Category> empquery = from x in db.Kategoriler select x;
            if(!string.IsNullOrEmpty(Empsearch))
            {
                empquery = empquery.Where(x => x.KategoriAdi.Contains(Empsearch));
                
            }
   
            return View(await empquery.AsNoTracking().ToListAsync());
        }
      */

            // GET: Category
          public ActionResult Index()
            {
                var kategoriler = db.Kategoriler.Select(i => new CategoryModels()
                {
                    Id=i.Id,
                    CategoriAdi = i.KategoriAdi,
                    KategoriResim=i.KategoriResim,
                    BlogSayisi = i.Bloglar.Count(),
                });
            return View(kategoriler.ToList());
            }
     
        // GET: Category/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Category category = db.Kategoriler.Find(id);
            if (category == null)
            {
                return HttpNotFound();
            }
            return View(category);
        }

        // GET: Category/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Category/Create
        // Aşırı gönderim saldırılarından korunmak için bağlamak istediğiniz belirli özellikleri etkinleştirin. 
        // Daha fazla bilgi için bkz. https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,KategoriAdi,KategoriResim")] Category category)
        {
            if (ModelState.IsValid)
            {
                db.Kategoriler.Add(category);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(category);
        }

        // GET: Category/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Category category = db.Kategoriler.Find(id);
            if (category == null)
            {
                return HttpNotFound();
            }
            return View(category);
        }

        // POST: Category/Edit/5
        // Aşırı gönderim saldırılarından korunmak için bağlamak istediğiniz belirli özellikleri etkinleştirin. 
        // Daha fazla bilgi için bkz. https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,KategoriAdi,KategoriResim")] Category category)
        {
            if (ModelState.IsValid)
            {
                db.Entry(category).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(category);
        }

        // GET: Category/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Category category = db.Kategoriler.Find(id);
            if (category == null)
            {
                return HttpNotFound();
            }
            return View(category);
        }

        // POST: Category/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Category category = db.Kategoriler.Find(id);
            db.Kategoriler.Remove(category);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
