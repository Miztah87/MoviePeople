﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProxy.Repository;

namespace TestProxy
{
   public class Facade
    {
        private MovieRepository movieRepo;
        private GenreRepository genresRepo;
        private OrderRepository ordersRepo;

        public MovieRepository GetMovieRepository()
        {
            if (movieRepo == null)
            {
                movieRepo = new MovieRepository();
            }
            return movieRepo;
        }
        public GenreRepository GetGenresRepository()
        {
            if (genresRepo == null)
            {
                genresRepo = new GenreRepository();
            }
            return genresRepo;
        }

        public OrderRepository GetOrderRepository()
        {
            if (ordersRepo == null)
            {
                ordersRepo = new OrderRepository();
            }
            return ordersRepo;
        }
    }
}
