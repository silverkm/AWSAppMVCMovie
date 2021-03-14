using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AWSAppMVCMovie.Models
{
    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Publication Date")]
        public DateTime PublicationDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }

    }
}
