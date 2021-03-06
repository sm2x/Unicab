﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Unicab.Api.Contexts;
using Unicab.Api.Models;

namespace Unicab.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PassengersController : ControllerBase
    {
        private readonly UnicabContext _context;

        public PassengersController(UnicabContext context)
        {
            _context = context;
        }

        // GET: api/Passengers
        [HttpGet]
        public IEnumerable<Passenger> GetPassengers()
        {
            return _context.Passengers;
        }

        // GET: api/Passengers/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPassenger([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var passenger = await _context.Passengers.FindAsync(id);

            if (passenger == null)
            {
                return NotFound();
            }

            return Ok(passenger);
        }

        // GET: api/Passengers/5
        [HttpGet("{emailAddress}/{password}")]
        public async Task<IActionResult> GetPassenger([FromRoute] string emailAddress, string password)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var passenger = await _context.Passengers.SingleOrDefaultAsync(b => b.EmailAddress == emailAddress && b.Password == password);

            if (passenger == null)
            {
                return NotFound();
            }

            return Ok(passenger);
        }

        // PUT: api/Passengers/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPassenger([FromRoute] int id, [FromBody] Passenger passenger)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != passenger.PassengerId)
            {
                return BadRequest();
            }

            _context.Entry(passenger).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PassengerExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Passengers
        [HttpPost]
        public async Task<IActionResult> PostPassenger([FromBody] Passenger passenger)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Passengers.Add(passenger);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPassenger", new { id = passenger.PassengerId }, passenger);
        }

        // DELETE: api/Passengers/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeletePassenger([FromRoute] int id)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    var passenger = await _context.Passengers.FindAsync(id);
        //    if (passenger == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Passengers.Remove(passenger);
        //    await _context.SaveChangesAsync();

        //    return Ok(passenger);
        //}

        private bool PassengerExists(int id)
        {
            return _context.Passengers.Any(e => e.PassengerId == id);
        }
    }
}