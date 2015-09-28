using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProxy.DomainModel;

namespace TestProxy.Context
{
    class SeedDbContext : DbContext
    {
        public SeedDbContext(): base("MovieShopDBConnectionString") 
        {
            Database.SetInitializer(new MovieShopDbInitializer());

        }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }
    }
}
