﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.Controllers.Api
{
    public class NewRentalsController : ApiController
    {
        ApplicationDbContext _context;
        public NewRentalsController()
        {
            _context = new ApplicationDbContext();
        }
        [HttpPost]
        public IHttpActionResult NewRental(NewRentalDto newRentalDto)
        {
            var rentalCustomer = _context.Customers.SingleOrDefault(c => c.Id == newRentalDto.CustomerId);
            var movies = _context.Movies.Where(
                m => newRentalDto.MovieIds.Contains(m.Id));
            foreach (var movie in movies)
            {   if (movie.NumberAvailable != 0)
                {
                    movie.NumberAvailable--;
                    var rental = new Rental
                    {
                        Customer = rentalCustomer,
                        Movie = movie,
                        DateRented = DateTime.Now
                    };
                    _context.Rentals.Add(rental);
                }
                else
                    return BadRequest("Movie not available");

            }
            _context.SaveChanges();
            return Ok();
        }
    }
}
