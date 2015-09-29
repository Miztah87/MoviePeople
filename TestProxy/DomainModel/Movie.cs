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
<<<<<<< HEAD

        [Display(Name = "Tinkywinky")]
        [StringLength(15)]
        public string Title { get; set; }
        [DataType("Date")]
=======
        [StringLength(15)]
        public string Title { get; set; }
        [DataType("date")]
>>>>>>> 719926eefb853e766abef769b11ce4c0cdf00f29
        public DateTime Year { get; set; }
        [Range(1, 9000)]
        public double Price { get; set; }
    }
}
