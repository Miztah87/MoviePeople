using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProxy.DomainModel
{
    [Table("Movie")]
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Tinkywinky")]
        [StringLength(15)]
        public string Title { get; set; }
        [DataType("Date")]
        public DateTime Year { get; set; }
        public double Price { get; set; }
    }
}
