using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TestProxy;
using TestProxy.Context;
using TestProxy.DomainModel;

namespace TestForCompulsory.Controllers
{
    public class MovieController : Controller
    {
        private Facade facade = new Facade();
        private ShopContextConnection db = new ShopContextConnection();
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

        [HttpGet]
        public ActionResult Edit(int? id)
        {
<<<<<<< HEAD

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movie movie = db.Movies.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);


            
=======
            return View();
>>>>>>> MovieController ConnectionString
        }
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id,Title,Year,Price")] Movie movie)
        {

            if (ModelState.IsValid)
            {
                db.Entry(movie).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(movie);


            //facade.GetMovieRepository().Edit(movie);
            //return Redirect("Index");

        }
    }
}