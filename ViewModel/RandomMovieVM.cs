﻿using NetFranco.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NetFranco.ViewModel
{
    public class RandomMovieVM
    {
        public List<Movie> Movies { get; set; }

        public List<Customer> Customers { get; set; }
    }
}