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
    public class pfAdministradoresController : ControllerBase
    {
        private readonly TourismContext _context;

        public pfAdministradoresController(TourismContext context)
        {
            _context = context;
        }

        // GET: api/pfAdministradores
        [HttpGet]
        public async Task<ActionResult<IEnumerable<pfAdministrador>>> GetpfAdministradores()
        {
            return await _context.pfAdministradores.ToListAsync();
        }

        // GET: api/pfAdministradores/5
        [HttpGet("{id}")]
        public async Task<ActionResult<pfAdministrador>> GetpfAdministrador(int id)
        {
            var pfAdministrador = await _context.pfAdministradores.FindAsync(id);

            if (pfAdministrador == null)
            {
                return NotFound();
            }

            return pfAdministrador;
        }

        // PUT: api/pfAdministradores/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutpfAdministrador(int id, pfAdministrador pfAdministrador)
        {
            if (id != pfAdministrador.ID)
            {
                return BadRequest();
            }

            _context.Entry(pfAdministrador).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!pfAdministradorExists(id))
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

        // POST: api/pfAdministradores
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<pfAdministrador>> PostpfAdministrador(pfAdministrador pfAdministrador)
        {
            _context.pfAdministradores.Add(pfAdministrador);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetpfAdministrador", new { id = pfAdministrador.ID }, pfAdministrador);
        }

        // DELETE: api/pfAdministradores/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletepfAdministrador(int id)
        {
            var pfAdministrador = await _context.pfAdministradores.FindAsync(id);
            if (pfAdministrador == null)
            {
                return NotFound();
            }

            _context.pfAdministradores.Remove(pfAdministrador);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool pfAdministradorExists(int id)
        {
            return _context.pfAdministradores.Any(e => e.ID == id);
        }
    }
}
