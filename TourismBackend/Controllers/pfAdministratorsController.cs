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
    public class pfAdministratorsController : ControllerBase
    {
        private readonly TourismContext _context;

        public pfAdministratorsController(TourismContext context)
        {
            _context = context;
        }

        // GET: api/pfAdministrators
        [HttpGet]
        public async Task<ActionResult<IEnumerable<pfAdministrator>>> GetpfAdministrators()
        {
            return await _context.pfAdministrators.ToListAsync();
        }

        // GET: api/pfAdministrators/5
        [HttpGet("{id}")]
        public async Task<ActionResult<pfAdministrator>> GetpfAdministrator(int id)
        {
            var pfAdministrator = await _context.pfAdministrators.FindAsync(id);

            if (pfAdministrator == null)
            {
                return NotFound();
            }

            return pfAdministrator;
        }

        // PUT: api/pfAdministrators/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutpfAdministrator(int id, pfAdministrator pfAdministrator)
        {
            if (id != pfAdministrator.ID)
            {
                return BadRequest();
            }

            _context.Entry(pfAdministrator).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!pfAdministratorExists(id))
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

        // POST: api/pfAdministrators
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<pfAdministrator>> PostpfAdministrator(pfAdministrator pfAdministrator)
        {
            _context.pfAdministrators.Add(pfAdministrator);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetpfAdministrator", new { id = pfAdministrator.ID }, pfAdministrator);
        }

        // DELETE: api/pfAdministrators/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletepfAdministrator(int id)
        {
            var pfAdministrator = await _context.pfAdministrators.FindAsync(id);
            if (pfAdministrator == null)
            {
                return NotFound();
            }

            _context.pfAdministrators.Remove(pfAdministrator);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool pfAdministratorExists(int id)
        {
            return _context.pfAdministrators.Any(e => e.ID == id);
        }
    }
}
