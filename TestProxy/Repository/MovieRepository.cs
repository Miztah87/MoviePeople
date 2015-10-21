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

                //1.try
                //var thisMovie = ctx.Movies.Attach(movie);


                //var entry = ctx.Entry(thisMovie);
                //entry.Property(e => e.Title).IsModified = true;
                //entry.Property(e => e.Price).IsModified = true;
                //// Problem with DateTime2 ?!? whut?!?
                //entry.Property(e => e.Year).IsModified = true;
                //entry.Property(e => e.Description).IsModified = true;
                //entry.Property(e => e.url).IsModified = true;
                //entry.Property(e => e.MovieCoverUrl).IsModified = true;
                //entry.Property(e => e.Genre).IsModified = true;
                ////

                //ctx.SaveChanges();

                //2.try
                //var dbMovie = FindMovie(movie.Id);
                //dbMovie.Title = movie.Title;
                //dbMovie.Price = movie.Price;
                //dbMovie.Year = movie.Year;
                //dbMovie.Description = movie.Description;
                //dbMovie.url = movie.url;
                //dbMovie.MovieCoverUrl = movie.MovieCoverUrl;
                //dbMovie.Genre = movie.Genre;
                ctx.Movies.Attach(movie);
                ctx.Entry(movie).State = EntityState.Modified;
                
                ctx.SaveChanges();


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
