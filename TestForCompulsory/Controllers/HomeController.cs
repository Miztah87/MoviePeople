using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestProxy;
using TestProxy.Context;
using TestProxy.DomainModel;

namespace TestForCompulsory.Controllers
{
    public class HomeController : Controller
    {

        private Facade facade = new Facade();
        private ShopContextConnection db = new ShopContextConnection();
        public ActionResult Index()
        {
            List<Movie> movies = facade.GetMovieRepository().ReadAll();
            return View(movies);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}