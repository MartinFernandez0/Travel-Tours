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
    public class pfTransaccionesController : ControllerBase
    {
        private readonly TourismContext _context;

        public pfTransaccionesController(TourismContext context)
        {
            _context = context;
        }

        // GET: api/pfTransacciones
        [HttpGet]
        public async Task<ActionResult<IEnumerable<pfTransaccion>>> GetpfTransacciones()
        {
            return await _context.pfTransacciones.ToListAsync();
        }

        // GET: api/pfTransacciones/5
        [HttpGet("{id}")]
        public async Task<ActionResult<pfTransaccion>> GetpfTransaccion(int id)
        {
            var pfTransaccion = await _context.pfTransacciones.FindAsync(id);

            if (pfTransaccion == null)
            {
                return NotFound();
            }

            return pfTransaccion;
        }

        // PUT: api/pfTransacciones/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutpfTransaccion(int id, pfTransaccion pfTransaccion)
        {
            if (id != pfTransaccion.ID)
            {
                return BadRequest();
            }

            _context.Entry(pfTransaccion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!pfTransaccionExists(id))
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

        // POST: api/pfTransacciones
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<pfTransaccion>> PostpfTransaccion(pfTransaccion pfTransaccion)
        {
            _context.pfTransacciones.Add(pfTransaccion);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetpfTransaccion", new { id = pfTransaccion.ID }, pfTransaccion);
        }

        // DELETE: api/pfTransacciones/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletepfTransaccion(int id)
        {
            var pfTransaccion = await _context.pfTransacciones.FindAsync(id);
            if (pfTransaccion == null)
            {
                return NotFound();
            }

            _context.pfTransacciones.Remove(pfTransaccion);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool pfTransaccionExists(int id)
        {
            return _context.pfTransacciones.Any(e => e.ID == id);
        }
    }
}
