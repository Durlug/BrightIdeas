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
    public class IdeaFollowersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public IdeaFollowersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/IdeaFollowers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<IdeaFollower>>> GetIdeaFollowers()
        {
            return await _context.IdeaFollowers.ToListAsync();
        }

        // GET: api/IdeaFollowers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<IdeaFollower>> GetIdeaFollower(int id)
        {
            var ideaFollower = await _context.IdeaFollowers.FindAsync(id);

            if (ideaFollower == null)
            {
                return NotFound();
            }

            return ideaFollower;
        }

        // PUT: api/IdeaFollowers/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutIdeaFollower(int id, IdeaFollower ideaFollower)
        {
            if (id != ideaFollower.IdeaFollowerId)
            {
                return BadRequest();
            }

            _context.Entry(ideaFollower).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IdeaFollowerExists(id))
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

        // POST: api/IdeaFollowers
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<IdeaFollower>> PostIdeaFollower(IdeaFollower ideaFollower)
        {
            _context.IdeaFollowers.Add(ideaFollower);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetIdeaFollower), new { id = ideaFollower.IdeaFollowerId }, ideaFollower);
        }

        // DELETE: api/IdeaFollowers/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<IdeaFollower>> DeleteIdeaFollower(int id)
        {
            var ideaFollower = await _context.IdeaFollowers.FindAsync(id);
            if (ideaFollower == null)
            {
                return NotFound();
            }

            _context.IdeaFollowers.Remove(ideaFollower);
            await _context.SaveChangesAsync();

            return ideaFollower;
        }

        private bool IdeaFollowerExists(int id)
        {
            return _context.IdeaFollowers.Any(e => e.IdeaFollowerId == id);
        }
    }
}
