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
    public class pfReservationsController : ControllerBase
    {
        private readonly TourismContext _context;

        public pfReservationsController(TourismContext context)
        {
            _context = context;
        }

        // GET: api/pfReservations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<pfReservation>>> GetpfReservations()
        {
            return await _context.pfReservations.ToListAsync();
        }

        // GET: api/pfReservations/5
        [HttpGet("{id}")]
        public async Task<ActionResult<pfReservation>> GetpfReservation(int id)
        {
            var pfReservation = await _context.pfReservations.FindAsync(id);

            if (pfReservation == null)
            {
                return NotFound();
            }

            return pfReservation;
        }

        // PUT: api/pfReservations/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutpfReservation(int id, pfReservation pfReservation)
        {
            if (id != pfReservation.ID)
            {
                return BadRequest();
            }

            _context.Entry(pfReservation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!pfReservationExists(id))
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

        // POST: api/pfReservations
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<pfReservation>> PostpfReservation(pfReservation pfReservation)
        {
            _context.pfReservations.Add(pfReservation);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetpfReservation", new { id = pfReservation.ID }, pfReservation);
        }

        // DELETE: api/pfReservations/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletepfReservation(int id)
        {
            var pfReservation = await _context.pfReservations.FindAsync(id);
            if (pfReservation == null)
            {
                return NotFound();
            }

            _context.pfReservations.Remove(pfReservation);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool pfReservationExists(int id)
        {
            return _context.pfReservations.Any(e => e.ID == id);
        }
    }
}
