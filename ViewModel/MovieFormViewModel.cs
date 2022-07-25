using NetFranco.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NetFranco.ViewModel
{
    public class MovieFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }

        public int? Id { get; set; }

        [Required(ErrorMessage = "Please enter movie's name.")]
        [StringLength(255)]
        public string Name { get; set; }

        [Display(Name = "Release Date")]
        [Required]
        public DateTime? ReleaseDate { get; set; }


        [Display(Name = "Genre")]
        public byte? GenreId { get; set; }

        [Display(Name = "Number in stock")]
        [Range(1, 20, ErrorMessage = "Please enter a number between 1 to 20")]
        [Required]
        public int Stock { get; set; }

        [Range(10, 40, ErrorMessage = "Please entere a number between 10 to 40")]
        [Required]
        public int Price { get; set; }

        public string FormType {
            get
            {
                return Id != 0 ? "Edit Movie" : "New Movie";
            }
                
        }

        public MovieFormViewModel()
        {
            Id = 0;
        }

        public MovieFormViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            ReleaseDate = movie.ReleaseDate;
            Price = movie.Price;
            Stock = movie.Stock;
            GenreId = movie.GenreId;
        }
    }
}