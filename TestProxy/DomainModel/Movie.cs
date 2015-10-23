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

       
        [StringLength(50)]
        public string Title { get; set; }
        [DataType("Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
       
        //[Range(1, 9000)]
        public DateTime Year { get; set; } 
               
        public double Price { get; set; }

        public virtual Genre Genre { get; set; }

        public String url { get; set;  }
        public String Description { get; set; }

        public string MovieCoverUrl { get; set; }
    }
}
