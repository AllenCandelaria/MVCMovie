using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCmovie.Models
{
    public class Movie
    {
        

        public int ID { get; set; }
        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string Title { get; set; }
        [Display(Name = "Release Date")]
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [StringLength(30)]
        public string Genre { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [Required]
        [DataType(DataType.Currency)]
        public Decimal Price { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$",ErrorMessage = "Please enter only alpha characters.")]
        [StringLength(6)]
        public string Rating { get; set; }

    }
}
