using ModelBinding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ModelBinding.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult HomePage()
        {
            Kisi k = new Kisi();
            k.Ad = "Elif";
            k.Soyad = "Cengiz";
            k.Yas = 25;

            Adres a = new Adres();
            a.AdresTanim = "Kadıköy";
            a.Sehir = "İstanbul";

            ViewModel vm = new ViewModel();
            vm.Kisi = k;
            vm.Adres = a;

            return View(vm);
        }

        [HttpPost]
        public ActionResult HomePage(ViewModel vm)
        {
           
            return View(vm);
        }
    }
}