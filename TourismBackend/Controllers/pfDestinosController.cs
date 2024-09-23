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
    public class pfDestinosController : ControllerBase
    {
        private readonly TourismContext _context;

        public pfDestinosController(TourismContext context)
        {
            _context = context;
        }

        // GET: api/pfDestinos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<pfDestino>>> GetpfDestinos()
        {
            return await _context.pfDestinos.ToListAsync();
        }

        // GET: api/pfDestinos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<pfDestino>> GetpfDestino(int id)
        {
            var pfDestino = await _context.pfDestinos.FindAsync(id);

            if (pfDestino == null)
            {
                return NotFound();
            }

            return pfDestino;
        }

        // PUT: api/pfDestinos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutpfDestino(int id, pfDestino pfDestino)
        {
            if (id != pfDestino.ID)
            {
                return BadRequest();
            }

            _context.Entry(pfDestino).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!pfDestinoExists(id))
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

        // POST: api/pfDestinos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<pfDestino>> PostpfDestino(pfDestino pfDestino)
        {
            _context.pfDestinos.Add(pfDestino);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetpfDestino", new { id = pfDestino.ID }, pfDestino);
        }

        // DELETE: api/pfDestinos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletepfDestino(int id)
        {
            var pfDestino = await _context.pfDestinos.FindAsync(id);
            if (pfDestino == null)
            {
                return NotFound();
            }

            _context.pfDestinos.Remove(pfDestino);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool pfDestinoExists(int id)
        {
            return _context.pfDestinos.Any(e => e.ID == id);
        }
    }
}
