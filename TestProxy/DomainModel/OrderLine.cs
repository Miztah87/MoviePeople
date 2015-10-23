using System.ComponentModel.DataAnnotations.Schema;
using TestProxy.DomainModel;

namespace TestProxy.DomainModel
{
    public class OrderLine
    {
        public Movie movie;

        public int Amount { get; set; }
        public Movie Movie { get; set; }
    }
}