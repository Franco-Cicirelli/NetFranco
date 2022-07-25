using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NetFranco.Dtos
{
    public class NewRentalDto
    {
        public int CustomerId { get; set; }
        public List<int> MovieIds { get; set; }

        public CustomerDto Customer { get; set; }

        public MovieDto Movie{ get; set; }

        public DateTime DateRented { get; set; }
    }
}