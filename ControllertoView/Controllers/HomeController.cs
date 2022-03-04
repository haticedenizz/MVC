using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControllertoView.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult HomePage()
        {
            ViewData["text1"] = "Elif Cengiz";
            ViewData["check"] = true;

            ViewBag.isim = "Elif Cengiz";
            ViewBag.kontrol = true;

            TempData["text2"] = "Elif Cengiz";
            TempData["check"] = true;

            return View();
        }

        public ActionResult Hakkında()
        {

            ViewBag.isim = "Elif Cengiz";
            ViewBag.kontrol = true;
            ViewBag.liste = new SelectListItem[]
            {
                new SelectListItem() {Text="bir", Value="1"},
                new SelectListItem(){Text="iki",Value="2"},
                new SelectListItem(){Text="üç",Value="3"}
            };

            TempData["t1"] = ViewBag.isim;
            TempData["t2"] = ViewBag.kontrol;
            return View();
        }

        public ActionResult iletisim()
        {
            ViewBag.text2 = TempData["t1"];
            ViewBag.kontrol2 = TempData["t2"];
            TempData["t3"] = TempData["t1"];
            TempData["t4"] = TempData["t2"];
            return View();        
        }

        public ActionResult blog()
        {
            ViewBag.text3 = TempData["t3"];
            ViewBag.kontrol3 = TempData["t4"];
            return View();
        }
    }
}