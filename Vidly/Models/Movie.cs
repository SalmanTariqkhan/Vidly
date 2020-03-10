
using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public Genre Genre { get; set; }
        [Display(Name = "Genre")]
        public byte GenreId { get; set; }
        [Display(Name = "Released Date")]
        public DateTime ReleasedDate { get; set; }
        public DateTime AddedDate { get; set; }
        [Display(Name = "Number In Stock")]
        [Range(1,20)]
        public int NumberInStock { get; set; }
        public int NumberAvailable { get; set; }
    }
}