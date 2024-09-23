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
    public class pfReservasController : ControllerBase
    {
        private readonly TourismContext _context;

        public pfReservasController(TourismContext context)
        {
            _context = context;
        }

        // GET: api/pfReservas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<pfReserva>>> GetpfReservas()
        {
            return await _context.pfReservas.ToListAsync();
        }

        // GET: api/pfReservas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<pfReserva>> GetpfReserva(int id)
        {
            var pfReserva = await _context.pfReservas.FindAsync(id);

            if (pfReserva == null)
            {
                return NotFound();
            }

            return pfReserva;
        }

        // PUT: api/pfReservas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutpfReserva(int id, pfReserva pfReserva)
        {
            if (id != pfReserva.ID)
            {
                return BadRequest();
            }

            _context.Entry(pfReserva).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!pfReservaExists(id))
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

        // POST: api/pfReservas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<pfReserva>> PostpfReserva(pfReserva pfReserva)
        {
            _context.pfReservas.Add(pfReserva);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetpfReserva", new { id = pfReserva.ID }, pfReserva);
        }

        // DELETE: api/pfReservas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletepfReserva(int id)
        {
            var pfReserva = await _context.pfReservas.FindAsync(id);
            if (pfReserva == null)
            {
                return NotFound();
            }

            _context.pfReservas.Remove(pfReserva);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool pfReservaExists(int id)
        {
            return _context.pfReservas.Any(e => e.ID == id);
        }
    }
}
