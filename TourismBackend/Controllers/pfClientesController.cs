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
    public class pfClientesController : ControllerBase
    {
        private readonly TourismContext _context;

        public pfClientesController(TourismContext context)
        {
            _context = context;
        }

        // GET: api/pfClientes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<pfCliente>>> GetpfClientes()
        {
            return await _context.pfClientes.ToListAsync();
        }

        // GET: api/pfClientes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<pfCliente>> GetpfCliente(int id)
        {
            var pfCliente = await _context.pfClientes.FindAsync(id);

            if (pfCliente == null)
            {
                return NotFound();
            }

            return pfCliente;
        }

        // PUT: api/pfClientes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutpfCliente(int id, pfCliente pfCliente)
        {
            if (id != pfCliente.ID)
            {
                return BadRequest();
            }

            _context.Entry(pfCliente).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!pfClienteExists(id))
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

        // POST: api/pfClientes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<pfCliente>> PostpfCliente(pfCliente pfCliente)
        {
            _context.pfClientes.Add(pfCliente);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetpfCliente", new { id = pfCliente.ID }, pfCliente);
        }

        // DELETE: api/pfClientes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletepfCliente(int id)
        {
            var pfCliente = await _context.pfClientes.FindAsync(id);
            if (pfCliente == null)
            {
                return NotFound();
            }

            _context.pfClientes.Remove(pfCliente);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool pfClienteExists(int id)
        {
            return _context.pfClientes.Any(e => e.ID == id);
        }
    }
}
