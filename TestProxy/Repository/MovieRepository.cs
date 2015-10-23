using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProxy.Context;
using TestProxy.DomainModel;

namespace TestProxy.Repository
{
    public class MovieRepository
    {
        private List<Movie> movies;
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Movie> ReadAll()
        {
            using (var ctx = new ShopContextConnection())
            {
                return ctx.Movies.Include("Genre").ToList();
            }
        }
        public void Add(Movie movie)
        {
            using (var ctx = new ShopContextConnection())
            {
                ctx.Movies.Attach(movie);
                ctx.Movies.Add(movie);
                ctx.SaveChanges();
            }
        }

        public void Delete(Movie movie)
        {
            using (var ctx = new ShopContextConnection())
            {
                ctx.Movies.Attach(movie);
                //var thisMovie =  ctx.Movies.Where(x => x.Id == movie.Id).FirstOrDefault();
                ctx.Movies.Remove(movie);
                ctx.SaveChanges();
            }
        }



        //public void Edit([Bind(Include = "Id,Title,Year,Price")] Movie movie)
        //{

        //    if (ModelState.IsValid)
        //    {
        //        ctx.Entry(movie).State = EntityState.Modified;
        //        ctx.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //}

        public void Edit(Movie movie)
        {
            using (var ctx = new ShopContextConnection())
            {



                //A gift to Lars from KBTZ team. Enjoy!
                var movieDB = ctx.Movies.FirstOrDefault(x => x.Id == movie.Id);
                movieDB.Genre = ctx.Genres.FirstOrDefault(x => x.Id == movie.Genre.Id);
                movieDB.Title = movie.Title;
                movieDB.Price = movie.Price;
                movieDB.Year = movie.Year;
                movieDB.Description = movie.Description;
                movieDB.url = movie.url;
                movieDB.MovieCoverUrl = movie.MovieCoverUrl;



                ctx.SaveChanges();

                //ctx.SaveChanges();


            }
        }

        internal Movie FindMovie(int movieId)
        {
            movies = ReadAll();
            /*foreach (var item in employees)
            {
                if (item.Id == employeeId) {
                    return item;
                }
            }
            return null;
            */
            return movies.FirstOrDefault(item => item.Id == movieId);
        }

    }
}
