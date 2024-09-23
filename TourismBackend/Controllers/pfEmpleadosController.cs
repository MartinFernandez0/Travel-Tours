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
    public class pfEmpleadosController : ControllerBase
    {
        private readonly TourismContext _context;

        public pfEmpleadosController(TourismContext context)
        {
            _context = context;
        }

        // GET: api/pfEmpleados
        [HttpGet]
        public async Task<ActionResult<IEnumerable<pfEmpleado>>> GetpfEmpleados()
        {
            return await _context.pfEmpleados.ToListAsync();
        }

        // GET: api/pfEmpleados/5
        [HttpGet("{id}")]
        public async Task<ActionResult<pfEmpleado>> GetpfEmpleado(int id)
        {
            var pfEmpleado = await _context.pfEmpleados.FindAsync(id);

            if (pfEmpleado == null)
            {
                return NotFound();
            }

            return pfEmpleado;
        }

        // PUT: api/pfEmpleados/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutpfEmpleado(int id, pfEmpleado pfEmpleado)
        {
            if (id != pfEmpleado.ID)
            {
                return BadRequest();
            }

            _context.Entry(pfEmpleado).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!pfEmpleadoExists(id))
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

        // POST: api/pfEmpleados
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<pfEmpleado>> PostpfEmpleado(pfEmpleado pfEmpleado)
        {
            _context.pfEmpleados.Add(pfEmpleado);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetpfEmpleado", new { id = pfEmpleado.ID }, pfEmpleado);
        }

        // DELETE: api/pfEmpleados/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletepfEmpleado(int id)
        {
            var pfEmpleado = await _context.pfEmpleados.FindAsync(id);
            if (pfEmpleado == null)
            {
                return NotFound();
            }

            _context.pfEmpleados.Remove(pfEmpleado);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool pfEmpleadoExists(int id)
        {
            return _context.pfEmpleados.Any(e => e.ID == id);
        }
    }
}
