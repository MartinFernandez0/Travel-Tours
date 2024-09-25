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
    public class pfExpensesController : ControllerBase
    {
        private readonly TourismContext _context;

        public pfExpensesController(TourismContext context)
        {
            _context = context;
        }

        // GET: api/pfExpenses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<pfExpense>>> GetpfExpenses()
        {
            return await _context.pfExpenses.ToListAsync();
        }

        // GET: api/pfExpenses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<pfExpense>> GetpfExpense(int id)
        {
            var pfExpense = await _context.pfExpenses.FindAsync(id);

            if (pfExpense == null)
            {
                return NotFound();
            }

            return pfExpense;
        }

        // PUT: api/pfExpenses/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutpfExpense(int id, pfExpense pfExpense)
        {
            if (id != pfExpense.ID)
            {
                return BadRequest();
            }

            _context.Entry(pfExpense).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!pfExpenseExists(id))
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

        // POST: api/pfExpenses
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<pfExpense>> PostpfExpense(pfExpense pfExpense)
        {
            _context.pfExpenses.Add(pfExpense);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetpfExpense", new { id = pfExpense.ID }, pfExpense);
        }

        // DELETE: api/pfExpenses/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletepfExpense(int id)
        {
            var pfExpense = await _context.pfExpenses.FindAsync(id);
            if (pfExpense == null)
            {
                return NotFound();
            }

            _context.pfExpenses.Remove(pfExpense);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool pfExpenseExists(int id)
        {
            return _context.pfExpenses.Any(e => e.ID == id);
        }
    }
}
