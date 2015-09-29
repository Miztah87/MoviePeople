using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProxy.Context;
using TestProxy.DomainModel;

namespace TestProxy.Repository
{
   public class MovieRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Movie> ReadAll()
        {
            using (var ctx = new ShopContextConnection())
            {
                return ctx.Movies.ToList();
            }
        }
        public void Add(Movie movie)
        {
            using (var ctx = new ShopContextConnection())
            {
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

        
        public void Edit(Movie movie)
<<<<<<< HEAD
        {             
=======
        {
            using (var ctx = new ShopContextConnection())
            {
                var thisMovie = ctx.Movies.Where(x => x.Id == movie.Id).FirstOrDefault();
                var entry = ctx.Entry(thisMovie);
                entry.Property(e => e.Title).IsModified = true;
                entry.Property(e => e.Price).IsModified = true;
                // Problem with DateTime2 ?!? whut?!?
                entry.Property(e => e.Year).IsModified = true;

                ctx.SaveChanges();
>>>>>>> 719926eefb853e766abef769b11ce4c0cdf00f29

           
        }

      
    }
}
