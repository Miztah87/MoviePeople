using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProxy.DomainModel;

namespace TestProxy.Context
{
    class MovieShopDbInitializer : DropCreateDatabaseAlways<SeedDbContext>
    {
        protected override void Seed(SeedDbContext context)
        {
            IList<Movie> movies = new List<Movie>();

            movies.Add(new Movie() { Id = 1, Title = "Die HArd", Year = DateTime.Now.AddYears(-3), Price = 2345 });
            movies.Add(new Movie() { Id = 2, Title = "Die HArd 2", Year = DateTime.Now.AddYears(-2), Price = 2355 });
            movies.Add(new Movie() { Id = 3, Title = "Die HArd 3", Year = DateTime.Now.AddYears(-1), Price = 2445 });

            foreach (Movie std in movies)
                context.Movies.Add(std);

            base.Seed(context);
        }
    }
}
