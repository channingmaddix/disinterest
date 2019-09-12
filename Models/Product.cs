using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace disinterest.Models
{
    public class Product
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Name { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [StringLength(30)]
        [Required]
        public string Category { get; set; }

        [DataType(DataType.Url)]
        [Required]
        public string ProductPage { get; set; }

        [DataType(DataType.ImageUrl)]
        [Required]
        public string ImageURL { get; set; }

        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [StringLength(300)]
        [Required]
        public string Description { get; set; }
    }
}
