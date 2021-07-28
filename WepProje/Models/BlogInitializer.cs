using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WepProje.Models
{
    public class BlogInitializer:DropCreateDatabaseIfModelChanges<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {
           

            List<Category> kategoriler = new List<Category>()
            {
                new Category(){KategoriAdi="C#", KategoriResim="11.jpg" },
                new Category(){KategoriAdi="Asp.Net", KategoriResim="11.jpg"},
                new Category(){KategoriAdi="C++", KategoriResim="11.jpg"},
                new Category(){KategoriAdi="Java", KategoriResim="11.jpg"},
            };
            foreach(var item in kategoriler)
            {
                context.Kategoriler.Add(item);
            }
            context.SaveChanges();

            List<Blog> bloglar = new List<Blog>()
            {
                new Blog(){ Baslik="C# Delegates Hakkında", Aciklama="C# Delegates Hakkında C# Delegates Hakkında " , EklenmeTarihi=DateTime.Now.AddDays(-10), Anasayfa=true , Onay=true, Icerik="C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında" ,Resim="11.jpg",Video="https://www.youtube.com/embed/GTPnhwf-VAY" ,CategoryId=1 },
                new Blog(){ Baslik="C# Delegates Hakkında", Aciklama="C# Delegates Hakkında C# Delegates Hakkında " , EklenmeTarihi=DateTime.Now.AddDays(-10), Anasayfa=true , Onay=true, Icerik="C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında" ,Resim="11.jpg",Video="https://www.youtube.com/embed/GTPnhwf-VAY", CategoryId=2 },
                new Blog(){ Baslik="C# Delegates Hakkında", Aciklama="C# Delegates Hakkında C# Delegates Hakkında " , EklenmeTarihi=DateTime.Now.AddDays(-10), Anasayfa=true , Onay=true, Icerik="C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında" ,Resim="11.jpg",Video="https://www.youtube.com/embed/GTPnhwf-VAY", CategoryId=1 },
                new Blog(){ Baslik="C# Delegates Hakkında", Aciklama="C# Delegates Hakkında C# Delegates Hakkında " , EklenmeTarihi=DateTime.Now.AddDays(-10), Anasayfa=true , Onay=true, Icerik="C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında" ,Resim="11.jpg",Video="https://www.youtube.com/embed/GTPnhwf-VAY", CategoryId=3 },
                new Blog(){ Baslik="C# Delegates Hakkında", Aciklama="C# Delegates Hakkında C# Delegates Hakkında " , EklenmeTarihi=DateTime.Now.AddDays(-10), Anasayfa=true , Onay=true, Icerik="C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında" ,Resim="11.jpg",Video="https://www.youtube.com/embed/GTPnhwf-VAY", CategoryId=2 },
                new Blog(){ Baslik="C# Delegates Hakkında", Aciklama="C# Delegates Hakkında C# Delegates Hakkında " , EklenmeTarihi=DateTime.Now.AddDays(-10), Anasayfa=true , Onay=true, Icerik="C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında" ,Resim="11.jpg",Video="https://www.youtube.com/embed/GTPnhwf-VAY", CategoryId=1 },
                new Blog(){ Baslik="C# Delegates Hakkında", Aciklama="C# Delegates Hakkında C# Delegates Hakkında " , EklenmeTarihi=DateTime.Now.AddDays(-10), Anasayfa=true , Onay=true, Icerik="C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında" ,Resim="11.jpg",Video="https://www.youtube.com/embed/GTPnhwf-VAY", CategoryId=2 },
                new Blog(){ Baslik="C# Delegates Hakkında", Aciklama="C# Delegates Hakkında C# Delegates Hakkında " , EklenmeTarihi=DateTime.Now.AddDays(-10), Anasayfa=true , Onay=true, Icerik="C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında" ,Resim="11.jpg",Video="https://www.youtube.com/embed/GTPnhwf-VAY", CategoryId=1 },
                new Blog(){ Baslik="C# Delegates Hakkında", Aciklama="C# Delegates Hakkında C# Delegates Hakkında " , EklenmeTarihi=DateTime.Now.AddDays(-10), Anasayfa=true , Onay=true, Icerik="C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında" ,Resim="11.jpg",Video="https://www.youtube.com/embed/GTPnhwf-VAY", CategoryId=2 },
                new Blog(){ Baslik="C# Delegates Hakkında", Aciklama="C# Delegates Hakkında C# Delegates Hakkında " , EklenmeTarihi=DateTime.Now.AddDays(-10), Anasayfa=true , Onay=true, Icerik="C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında" ,Resim="11.jpg",Video="https://www.youtube.com/embed/GTPnhwf-VAY", CategoryId=3 },
            };
             foreach(var item in bloglar)
            {
                context.Bloglar.Add(item);
            }
            context.SaveChanges();


            base.Seed(context);
        }
    }
}