using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TourismBackend.DataContext;
using TourismServices.Models;

namespace TourismBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class pfItinerariesController : ControllerBase
    {
        private readonly TourismContext _context;

        public pfItinerariesController(TourismContext context)
        {
            _context = context;
        }

        // GET: api/pfItineraries
        [HttpGet]
        public async Task<ActionResult<IEnumerable<pfItinerary>>> GetpfItineraries()
        {
            return await _context.pfItineraries.ToListAsync();
        }

        // GET: api/pfItineraries/5
        [HttpGet("{id}")]
        public async Task<ActionResult<pfItinerary>> GetpfItinerary(int id)
        {
            var pfItinerary = await _context.pfItineraries.FindAsync(id);

            if (pfItinerary == null)
            {
                return NotFound();
            }

            return pfItinerary;
        }

        // PUT: api/pfItineraries/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutpfItinerary(int id, pfItinerary pfItinerary)
        {
            if (id != pfItinerary.ID)
            {
                return BadRequest();
            }

            _context.Entry(pfItinerary).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!pfItineraryExists(id))
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

        // POST: api/pfItineraries
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<pfItinerary>> PostpfItinerary(pfItinerary pfItinerary)
        {
            _context.pfItineraries.Add(pfItinerary);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetpfItinerary", new { id = pfItinerary.ID }, pfItinerary);
        }

        // DELETE: api/pfItineraries/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletepfItinerary(int id)
        {
            var pfItinerary = await _context.pfItineraries.FindAsync(id);
            if (pfItinerary == null)
            {
                return NotFound();
            }

            _context.pfItineraries.Remove(pfItinerary);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool pfItineraryExists(int id)
        {
            return _context.pfItineraries.Any(e => e.ID == id);
        }
    }
}
