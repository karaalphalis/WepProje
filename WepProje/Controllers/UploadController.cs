using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WepProje.Controllers
{
    public class UploadController : Controller
    {
        // GET: Upload
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(HttpPostedFileBase file)
        {
            


            if ( file !=null  &&file.ContentLength>0)
            {
                var extensition = Path.GetExtension(file.FileName);
                if (extensition == "jpg" || extensition == "png")
                {
                    var filename = Path.GetFileName(file.FileName);
                    var path = Path.Combine(Server.MapPath("/Upload"), filename);
                    file.SaveAs(path);
                }
                else
                {
                    ViewData["message"] = "Resim dosyası seçiniz.";
                }
            }
            else
            {
                ViewData["message"] = "Bir dosya Seçiniz.";
            }
            return View();
        }
    }
}