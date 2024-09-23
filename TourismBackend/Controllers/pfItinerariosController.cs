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
    public class pfItinerariosController : ControllerBase
    {
        private readonly TourismContext _context;

        public pfItinerariosController(TourismContext context)
        {
            _context = context;
        }

        // GET: api/pfItinerarios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<pfItinerario>>> GetpfItinerarios()
        {
            return await _context.pfItinerarios.ToListAsync();
        }

        // GET: api/pfItinerarios/5
        [HttpGet("{id}")]
        public async Task<ActionResult<pfItinerario>> GetpfItinerario(int id)
        {
            var pfItinerario = await _context.pfItinerarios.FindAsync(id);

            if (pfItinerario == null)
            {
                return NotFound();
            }

            return pfItinerario;
        }

        // PUT: api/pfItinerarios/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutpfItinerario(int id, pfItinerario pfItinerario)
        {
            if (id != pfItinerario.ID)
            {
                return BadRequest();
            }

            _context.Entry(pfItinerario).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!pfItinerarioExists(id))
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

        // POST: api/pfItinerarios
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<pfItinerario>> PostpfItinerario(pfItinerario pfItinerario)
        {
            _context.pfItinerarios.Add(pfItinerario);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetpfItinerario", new { id = pfItinerario.ID }, pfItinerario);
        }

        // DELETE: api/pfItinerarios/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletepfItinerario(int id)
        {
            var pfItinerario = await _context.pfItinerarios.FindAsync(id);
            if (pfItinerario == null)
            {
                return NotFound();
            }

            _context.pfItinerarios.Remove(pfItinerario);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool pfItinerarioExists(int id)
        {
            return _context.pfItinerarios.Any(e => e.ID == id);
        }
    }
}
