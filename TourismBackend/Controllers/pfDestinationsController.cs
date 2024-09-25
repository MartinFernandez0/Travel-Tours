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
    public class pfDestinationsController : ControllerBase
    {
        private readonly TourismContext _context;

        public pfDestinationsController(TourismContext context)
        {
            _context = context;
        }

        // GET: api/pfDestinations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<pfDestination>>> GetpfDestinations()
        {
            return await _context.pfDestinations.ToListAsync();
        }

        // GET: api/pfDestinations/5
        [HttpGet("{id}")]
        public async Task<ActionResult<pfDestination>> GetpfDestination(int id)
        {
            var pfDestination = await _context.pfDestinations.FindAsync(id);

            if (pfDestination == null)
            {
                return NotFound();
            }

            return pfDestination;
        }

        // PUT: api/pfDestinations/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutpfDestination(int id, pfDestination pfDestination)
        {
            if (id != pfDestination.ID)
            {
                return BadRequest();
            }

            _context.Entry(pfDestination).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!pfDestinationExists(id))
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

        // POST: api/pfDestinations
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<pfDestination>> PostpfDestination(pfDestination pfDestination)
        {
            _context.pfDestinations.Add(pfDestination);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetpfDestination", new { id = pfDestination.ID }, pfDestination);
        }

        // DELETE: api/pfDestinations/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletepfDestination(int id)
        {
            var pfDestination = await _context.pfDestinations.FindAsync(id);
            if (pfDestination == null)
            {
                return NotFound();
            }

            _context.pfDestinations.Remove(pfDestination);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool pfDestinationExists(int id)
        {
            return _context.pfDestinations.Any(e => e.ID == id);
        }
    }
}
