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
    public class pfActivitiesController : ControllerBase
    {
        private readonly TourismContext _context;

        public pfActivitiesController(TourismContext context)
        {
            _context = context;
        }

        // GET: api/pfActivities
        [HttpGet]
        public async Task<ActionResult<IEnumerable<pfActivity>>> GetpfActivities()
        {
            return await _context.pfActivities.ToListAsync();
        }

        // GET: api/pfActivities/5
        [HttpGet("{id}")]
        public async Task<ActionResult<pfActivity>> GetpfActivity(int id)
        {
            var pfActivity = await _context.pfActivities.FindAsync(id);

            if (pfActivity == null)
            {
                return NotFound();
            }

            return pfActivity;
        }

        // PUT: api/pfActivities/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutpfActivity(int id, pfActivity pfActivity)
        {
            if (id != pfActivity.ID)
            {
                return BadRequest();
            }

            _context.Entry(pfActivity).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!pfActivityExists(id))
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

        // POST: api/pfActivities
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<pfActivity>> PostpfActivity(pfActivity pfActivity)
        {
            _context.pfActivities.Add(pfActivity);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetpfActivity", new { id = pfActivity.ID }, pfActivity);
        }

        // DELETE: api/pfActivities/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletepfActivity(int id)
        {
            var pfActivity = await _context.pfActivities.FindAsync(id);
            if (pfActivity == null)
            {
                return NotFound();
            }

            _context.pfActivities.Remove(pfActivity);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool pfActivityExists(int id)
        {
            return _context.pfActivities.Any(e => e.ID == id);
        }
    }
}
