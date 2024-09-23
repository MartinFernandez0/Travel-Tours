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
    public class pfActividadesController : ControllerBase
    {
        private readonly TourismContext _context;

        public pfActividadesController(TourismContext context)
        {
            _context = context;
        }

        // GET: api/pfActividades
        [HttpGet]
        public async Task<ActionResult<IEnumerable<pfActividad>>> GetpfActividades()
        {
            return await _context.pfActividades.ToListAsync();
        }

        // GET: api/pfActividades/5
        [HttpGet("{id}")]
        public async Task<ActionResult<pfActividad>> GetpfActividad(int id)
        {
            var pfActividad = await _context.pfActividades.FindAsync(id);

            if (pfActividad == null)
            {
                return NotFound();
            }

            return pfActividad;
        }

        // PUT: api/pfActividades/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutpfActividad(int id, pfActividad pfActividad)
        {
            if (id != pfActividad.ID)
            {
                return BadRequest();
            }

            _context.Entry(pfActividad).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!pfActividadExists(id))
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

        // POST: api/pfActividades
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<pfActividad>> PostpfActividad(pfActividad pfActividad)
        {
            _context.pfActividades.Add(pfActividad);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetpfActividad", new { id = pfActividad.ID }, pfActividad);
        }

        // DELETE: api/pfActividades/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletepfActividad(int id)
        {
            var pfActividad = await _context.pfActividades.FindAsync(id);
            if (pfActividad == null)
            {
                return NotFound();
            }

            _context.pfActividades.Remove(pfActividad);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool pfActividadExists(int id)
        {
            return _context.pfActividades.Any(e => e.ID == id);
        }
    }
}
