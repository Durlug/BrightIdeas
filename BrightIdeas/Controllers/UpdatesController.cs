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
    public class UpdatesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public UpdatesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Updates
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Update>>> GetUpdates()
        {
            return await _context.Updates.ToListAsync();
        }

        // GET: api/Updates/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Update>> GetUpdate(int id)
        {
            var update = await _context.Updates.FindAsync(id);

            if (update == null)
            {
                return NotFound();
            }

            return update;
        }

        // PUT: api/Updates/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUpdate(int id, Update update)
        {
            if (id != update.UpdateId)
            {
                return BadRequest();
            }

            _context.Entry(update).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UpdateExists(id))
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

        // POST: api/Updates
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Update>> PostUpdate(Update update)
        {
            _context.Updates.Add(update);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetUpdate), new { id = update.UpdateId }, update);
        }

        // DELETE: api/Updates/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Update>> DeleteUpdate(int id)
        {
            var update = await _context.Updates.FindAsync(id);
            if (update == null)
            {
                return NotFound();
            }

            _context.Updates.Remove(update);
            await _context.SaveChangesAsync();

            return update;
        }

        private bool UpdateExists(int id)
        {
            return _context.Updates.Any(e => e.UpdateId == id);
        }
    }
}
