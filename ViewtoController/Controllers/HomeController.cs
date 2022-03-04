using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViewtoController.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        public ActionResult HomePage()
        {
            return View();
        }

        [HttpPost]
        public ActionResult HomePage(string text1,bool check1,string liste)
        {
           var text=Request.Form["text1"];
           var kontrol = Request.Form.GetValues("check1")[0];
           var cinsiyet = Request.Form["liste"];

            return View();
        }
    
    
    
    }
}