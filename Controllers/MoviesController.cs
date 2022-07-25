using NetFranco.Models;
using NetFranco.ViewModel;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NetFranco.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Movies/Random
        public ViewResult Random()
        {
            if (User.IsInRole(RoleName.CanManageMovies))
                return View("Random");
            
            return View("ReadOnlyList");

        }

        

        public ActionResult Details(int id)
        {
            var movie = _context.Movies.Include(m => m.Genre).SingleOrDefault(x => x.Id == id);

            if (movie == null)
                return HttpNotFound();

            return View(movie);
        }

        [Authorize(Roles = RoleName.CanManageMovies)]
        
        public ActionResult Add()
        {
            var genres = _context.Genres.ToList();

            var viewModel = new MovieFormViewModel(new Movie())
            {
                
                Genres = genres
            };

            return View("MovieForm",viewModel);
        }

        [Authorize(Roles = RoleName.CanManageMovies)]
        public ActionResult Edit(int id)
        {
            var movie = _context.Movies.SingleOrDefault(x => x.Id == id);

            if (movie == null)
                return HttpNotFound();

            var viewModel = new MovieFormViewModel(movie)
            {
                
                Genres = _context.Genres.ToList()
            };

            return View("MovieForm", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = RoleName.CanManageMovies)]
        public ActionResult Save(Movie movie)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new MovieFormViewModel(movie)
                {
                    Genres = _context.Genres.ToList()
                };

                return View("MovieForm", viewModel);
            }
                

            if (movie.Id == 0)
            {
                movie.DateJoined = DateTime.Now;
                movie.Availability = movie.Stock;
                
                _context.Movies.Add(movie);
            }
            else
            {
                var movieInDb = _context.Movies.Single(c => c.Id == movie.Id);
                movieInDb.Name = movie.Name;
                movieInDb.ReleaseDate = movie.ReleaseDate;
                movieInDb.GenreId = movie.GenreId;
                movieInDb.Stock = movie.Stock;
                movieInDb.Price = movie.Price;


            }

            _context.SaveChanges();

            return RedirectToAction("Random", "Movies");
        }

        //[Route("movies/released/{year}/{month:regex(\\d{4}):range(1,}")]
        //public ActionResult ByReleaseYear (int year, int month)
        //{
        //    return Content(year + "/" + month);
        //}
    }
}