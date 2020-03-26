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
    public class PostingsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PostingsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Postings
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Posting>>> GetPostings()
        {
            return await _context.Postings.ToListAsync();
        }

        // GET: api/Postings/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Posting>> GetPosting(int id)
        {
            var posting = await _context.Postings.FindAsync(id);

            if (posting == null)
            {
                return NotFound();
            }

            return posting;
        }

        // PUT: api/Postings/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPosting(int id, Posting posting)
        {
            if (id != posting.PostingId)
            {
                return BadRequest();
            }

            _context.Entry(posting).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PostingExists(id))
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

        // POST: api/Postings
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Posting>> PostPosting(Posting posting)
        {
            _context.Postings.Add(posting);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetPosting), new { id = posting.PostingId }, posting);
        }

        // DELETE: api/Postings/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Posting>> DeletePosting(int id)
        {
            var posting = await _context.Postings.FindAsync(id);
            if (posting == null)
            {
                return NotFound();
            }

            _context.Postings.Remove(posting);
            await _context.SaveChangesAsync();

            return posting;
        }

        private bool PostingExists(int id)
        {
            return _context.Postings.Any(e => e.PostingId == id);
        }
    }
}
