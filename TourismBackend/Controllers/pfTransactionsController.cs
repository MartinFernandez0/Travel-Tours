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
    public class pfTransactionsController : ControllerBase
    {
        private readonly TourismContext _context;

        public pfTransactionsController(TourismContext context)
        {
            _context = context;
        }

        // GET: api/pfTransactions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<pfTransaction>>> GetpfTransactions()
        {
            return await _context.pfTransactions.ToListAsync();
        }

        // GET: api/pfTransactions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<pfTransaction>> GetpfTransaction(int id)
        {
            var pfTransaction = await _context.pfTransactions.FindAsync(id);

            if (pfTransaction == null)
            {
                return NotFound();
            }

            return pfTransaction;
        }

        // PUT: api/pfTransactions/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutpfTransaction(int id, pfTransaction pfTransaction)
        {
            if (id != pfTransaction.ID)
            {
                return BadRequest();
            }

            _context.Entry(pfTransaction).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!pfTransactionExists(id))
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

        // POST: api/pfTransactions
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<pfTransaction>> PostpfTransaction(pfTransaction pfTransaction)
        {
            _context.pfTransactions.Add(pfTransaction);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetpfTransaction", new { id = pfTransaction.ID }, pfTransaction);
        }

        // DELETE: api/pfTransactions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletepfTransaction(int id)
        {
            var pfTransaction = await _context.pfTransactions.FindAsync(id);
            if (pfTransaction == null)
            {
                return NotFound();
            }

            _context.pfTransactions.Remove(pfTransaction);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool pfTransactionExists(int id)
        {
            return _context.pfTransactions.Any(e => e.ID == id);
        }
    }
}
