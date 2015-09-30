using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProxy.Context;
using TestProxy.DomainModel;

namespace TestProxy.Repository
{
   public class GenreRepository
    {
        public List<Genre> ReadAll()
        {
            using (var ctx = new ShopContextConnection())
            {
                return ctx.Genres.ToList();
            }
        }

        public void Add(Genre genre)
        {
            using (var ctx = new ShopContextConnection())
            {
                //Create the queries
                ctx.Genres.Add(genre);
                //Execute the queries
                ctx.SaveChanges();
            }
        }
    }
}
