using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
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
       
        public ActionResult Index(string genre)
        {
            List<Movie> movies = facade.GetMovieRepository().ReadAll();
            if(genre != null)
            {
                movies = movies.Where(x => x.Genre.Name.Equals(genre)).ToList();
            }
            return View(movies);
        }
        [HttpPost]
        public ActionResult SortByGenre(string genre)
        {
            ViewBag.SortByGenres = new SelectList(db.Genres, "Id", "Name");
            // selectedName = genre.Name;

            //List<Movie> sortedMovies =new List<Movie>();
            //List<Movie> movies = facade.GetMovieRepository().ReadAll();
            //for(int i =0; i< movies.Count(); ++i)
            //{
            //    if (movies[i].Genre.Id == genre.Id)
            //    {
            //        sortedMovies.Add(movies[i]);
            //    }
            //}
            return View();
        }
        [Authorize(Roles ="Admin")]
        public ActionResult Create()
        {
            ShopContextConnection db = new ShopContextConnection();
            ViewBag.Genres = new SelectList(db.Genres, "Id", "Name");
            return View();
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public ActionResult Create(Movie movie, HttpPostedFileBase file)
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
        }
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id,Title,Year,Price,url,Description,MovieCoverUrl,Genre")] Movie movie)
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

        public ActionResult Details(int? id)
        {
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
        }

        public ActionResult Upload(HttpPostedFileBase file)
        {
            string path = Server.MapPath("~/Images/" + file.FileName);
            file.SaveAs(path);
            ViewBag.Path = path;
            return View();
        }


    }
}