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
    public class pfGastosController : ControllerBase
    {
        private readonly TourismContext _context;

        public pfGastosController(TourismContext context)
        {
            _context = context;
        }

        // GET: api/pfGastos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<pfGasto>>> GetpfGastos()
        {
            return await _context.pfGastos.ToListAsync();
        }

        // GET: api/pfGastos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<pfGasto>> GetpfGasto(int id)
        {
            var pfGasto = await _context.pfGastos.FindAsync(id);

            if (pfGasto == null)
            {
                return NotFound();
            }

            return pfGasto;
        }

        // PUT: api/pfGastos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutpfGasto(int id, pfGasto pfGasto)
        {
            if (id != pfGasto.ID)
            {
                return BadRequest();
            }

            _context.Entry(pfGasto).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!pfGastoExists(id))
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

        // POST: api/pfGastos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<pfGasto>> PostpfGasto(pfGasto pfGasto)
        {
            _context.pfGastos.Add(pfGasto);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetpfGasto", new { id = pfGasto.ID }, pfGasto);
        }

        // DELETE: api/pfGastos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletepfGasto(int id)
        {
            var pfGasto = await _context.pfGastos.FindAsync(id);
            if (pfGasto == null)
            {
                return NotFound();
            }

            _context.pfGastos.Remove(pfGasto);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool pfGastoExists(int id)
        {
            return _context.pfGastos.Any(e => e.ID == id);
        }
    }
}
