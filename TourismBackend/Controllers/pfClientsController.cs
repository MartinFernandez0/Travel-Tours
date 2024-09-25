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
    public class pfClientsController : ControllerBase
    {
        private readonly TourismContext _context;

        public pfClientsController(TourismContext context)
        {
            _context = context;
        }

        // GET: api/pfClients
        [HttpGet]
        public async Task<ActionResult<IEnumerable<pfClient>>> GetpfClients()
        {
            return await _context.pfClients.ToListAsync();
        }

        // GET: api/pfClients/5
        [HttpGet("{id}")]
        public async Task<ActionResult<pfClient>> GetpfClient(int id)
        {
            var pfClient = await _context.pfClients.FindAsync(id);

            if (pfClient == null)
            {
                return NotFound();
            }

            return pfClient;
        }

        // PUT: api/pfClients/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutpfClient(int id, pfClient pfClient)
        {
            if (id != pfClient.ID)
            {
                return BadRequest();
            }

            _context.Entry(pfClient).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!pfClientExists(id))
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

        // POST: api/pfClients
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<pfClient>> PostpfClient(pfClient pfClient)
        {
            _context.pfClients.Add(pfClient);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetpfClient", new { id = pfClient.ID }, pfClient);
        }

        // DELETE: api/pfClients/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletepfClient(int id)
        {
            var pfClient = await _context.pfClients.FindAsync(id);
            if (pfClient == null)
            {
                return NotFound();
            }

            _context.pfClients.Remove(pfClient);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool pfClientExists(int id)
        {
            return _context.pfClients.Any(e => e.ID == id);
        }
    }
}
