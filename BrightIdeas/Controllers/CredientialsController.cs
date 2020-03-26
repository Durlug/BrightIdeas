using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BrightIdeas.Data;
using BrightIdeas.Models;

namespace BrightIdeas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CredientialsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CredientialsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Credientials
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Crediential>>> GetCredientials()
        {
            return await _context.Credientials.ToListAsync();
        }

        // GET: api/Credientials/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Crediential>> GetCrediential(int id)
        {
            var crediential = await _context.Credientials.FindAsync(id);

            if (crediential == null)
            {
                return NotFound();
            }

            return crediential;
        }

        // PUT: api/Credientials/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCrediential(int id, Crediential crediential)
        {
            if (id != crediential.CredientialId)
            {
                return BadRequest();
            }

            _context.Entry(crediential).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CredientialExists(id))
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

        // POST: api/Credientials
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Crediential>> PostCrediential(Crediential crediential)
        {
            _context.Credientials.Add(crediential);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetCrediential), new { id = crediential.CredientialId }, crediential);
        }

        // DELETE: api/Credientials/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Crediential>> DeleteCrediential(int id)
        {
            var crediential = await _context.Credientials.FindAsync(id);
            if (crediential == null)
            {
                return NotFound();
            }

            _context.Credientials.Remove(crediential);
            await _context.SaveChangesAsync();

            return crediential;
        }

        private bool CredientialExists(int id)
        {
            return _context.Credientials.Any(e => e.CredientialId == id);
        }
    }
}
