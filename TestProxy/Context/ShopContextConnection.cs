using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProxy.DomainModel;

namespace TestProxy.Context
{
    class ShopContextConnection : DbContext
    {
        public ShopContextConnection(): 
            base("name=MovieShopDBConnectionString") { }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> genres { get; set; }
    }
}
