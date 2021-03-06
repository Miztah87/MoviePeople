﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProxy.DomainModel;

namespace TestProxy.Context
{
   public class ShopContextConnection : DbContext
    {
        public ShopContextConnection(): 
            base("name=MovieShopDBConnectionString") { }

        public DbSet<Movie> Movies { get; set; }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<Order> Orders { get; set; }
    }
}
