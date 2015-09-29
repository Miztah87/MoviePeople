using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestProxy;
using TestProxy.DomainModel;

namespace TestForCompulsory.Controllers
{
    public class MovieController : Controller
    {
        private Facade facade = new Facade();
        // GET: Movie
        public ActionResult Index()
        {
            List<Movie> movies = facade.GetMovieRepository().ReadAll();
            return View(movies);
        }

        public ActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Create(Movie movie)
        {
            facade.GetMovieRepository().Add(movie);
            return Redirect("Index");
        }

     
        public ActionResult Delete(Movie movie)
        {
            facade.GetMovieRepository().Delete(movie);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return RedirectToAction("Index", "Movie");

        }

    }
}