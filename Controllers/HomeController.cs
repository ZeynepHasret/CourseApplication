using System;
using Microsoft.AspNetCore.Mvc;

namespace MVCproject.Controllers
{
    //localhost:5000/home
    public class HomeController : Controller
    {

//localhost:5000/home/index => home/index/.cshtml
  public IActionResult Index()
        {
            int hour = DateTime.Now.Hour;
            int saat = hour;
            
            ViewBag.Greeting = saat > 12 ? "İyi günler" : "Günaydın";
            ViewBag.UserName = "Zeynep Hasret";
            return View();
        }

 //localhost:5000/home/about => home/abaout.cshtml
        public IActionResult About()
        {
            return View();
        }

        //localhost:5000/home/delete => home/delete.cshtml
        public IActionResult Delete(){
            // Sılme ışlemlerı yapıldı kodları yazıldı return degerı donderdı
            return View();
                 
        }
    }
}