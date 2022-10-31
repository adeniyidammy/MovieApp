using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace MovieApp.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [StringLength(50, MinimumLength = 3, ErrorMessage = "The title must have a minimum length of 3 and a maximum length of 50.")]
        [Required(ErrorMessage = "Provide Title")]
        public string? Title { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$", ErrorMessage = "Must Include alphabets and space only")]
        [Required]
        [StringLength(30)]
        public string? Genre { get; set; }

        [Range(1, 1000)]
        [Column(TypeName = "decimal(18, 2)")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$", ErrorMessage = "Must Include alphabhets, numbers and special characters")]
        [Required]
        [StringLength(15)]
        public string? Rating { get; set; }
    }
}
