﻿using NetFranco.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NetFranco.Controllers
{
    [Authorize(Roles = RoleName.CanManageMovies)]
    public class RentalsController : Controller
    {
        
        public ActionResult New()
        {
            return View();
        }

        
        public ViewResult MoviesRented()
        {

            return View("MoviesRented");

        }
    }
}