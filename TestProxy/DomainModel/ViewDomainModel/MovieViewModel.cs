using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProxy.DomainModel.ViewDomainModel
{
   public class MovieViewModel
    {
        public MovieViewModel()
        {
            Genres = new List<Genre>();
        }
        public Movie Movie { get; set; }
        public List<Genre> Genres { get; set; }
    }
}
