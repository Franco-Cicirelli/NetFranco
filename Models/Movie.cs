using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NetFranco.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter movie's name.")]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        
        public DateTime ReleaseDate { get; set; }

        public DateTime DateJoined { get; set; }

        public Genre Genre { get; set; }

        [Display(Name = "Genre")]
        public byte GenreId { get; set; }

        [Required]
        [Range(1, 20, ErrorMessage = "Please enter a number between 1 to 20")]
        public int Stock { get; set; }
    }
}