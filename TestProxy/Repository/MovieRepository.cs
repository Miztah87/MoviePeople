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


        //public void Edit([Bind(Include = "Id,Title,Year,Price")] Movie movie)
        //{

        //    if (ModelState.IsValid)
        //    {
        //        ctx.Entry(movie).State = EntityState.Modified;
        //        ctx.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //}
    }
}
