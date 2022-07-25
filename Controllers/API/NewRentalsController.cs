using NetFranco.Dtos;
using NetFranco.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;

namespace NetFranco.Controllers.API
{
    public class NewRentalsController : ApiController
    {
        private ApplicationDbContext _context;
        public NewRentalsController()
        {
            _context = new ApplicationDbContext();


        }

        //GET /api/newRentals
        public IHttpActionResult GetNewRentals()
        {
            var rentals = _context.Rentals
                .Include(c => c.Customer)
                .Include(m => m.Movie).ToList();
            
    
            var rentalsQuery = rentals
                .ToList()
                .Select(Mapper.Map<Rental, NewRentalDto>);

            return Ok(rentalsQuery);
        }


        [HttpPost]
        public IHttpActionResult CreateNewRentals(NewRentalDto newRental)
        {
            var customer = _context.Customers
                .Include (c => c.MembershipType)
                .Single(
                c => c.Id == newRental.CustomerId);

            var movies = _context.Movies.Where(
                m => newRental.MovieIds.Contains(m.Id));

            var moviesPrice = 0;

            foreach (var movie in movies)
            {
                if (movie.Availability == 0)
                    return BadRequest("Movie is not available.");

                

                movie.Availability--;

                var rental = new Rental
                {
                    Customer = customer,
                    Movie = movie,
                    DateRented = DateTime.Now
                };

                moviesPrice += movie.Price;

                _context.Rentals.Add(rental);
            }

            if(moviesPrice > customer.Balance)
            {
                return BadRequest("The customer " + customer.Name + " doesn't have enough money.");
            }
            customer.Balance = customer.Balance - moviesPrice;

            _context.SaveChanges();

            return Ok();
        }
    }
}
