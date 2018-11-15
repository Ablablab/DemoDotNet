using Comments.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Comments.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Risultato di chiamate a dll:  ";
            ViewBag.Message += ReflectionProvider.getInstance().callMetodoByName("ClassLibrary1", "Class1", "prova");
            ViewBag.Message += ReflectionProvider.getInstance().callMetodoByName("ClassLibrary2", "Class1", "prova");
            return View();
            //return Redirect("default.htm");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Risultato di chiamate a dll:  ";
            ViewBag.Message += ReflectionProvider.getInstance().callMetodoByName("ClassLibrary1", "Class1", "prova");
            ViewBag.Message += ReflectionProvider.getInstance().callMetodoByName("ClassLibrary2", "Class2", "prova");

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
