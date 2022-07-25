using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NetFranco.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]

        public DateTime ReleaseDate { get; set; }

        public DateTime DateJoined { get; set; }

        public byte GenreId { get; set; }

        public GenreDto Genre { get; set; }

        public int Availability { get; set; }

        [Required]
        public int Stock { get; set; }

        [Required]

        public int Price { get; set; }
    }
}