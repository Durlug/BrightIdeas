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
    public class IdeaReportsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public IdeaReportsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/IdeaReports
        [HttpGet]
        public async Task<ActionResult<IEnumerable<IdeaReport>>> GetIdeaReports()
        {
            return await _context.IdeaReports.ToListAsync();
        }

        // GET: api/IdeaReports/5
        [HttpGet("{id}")]
        public async Task<ActionResult<IdeaReport>> GetIdeaReport(int id)
        {
            var ideaReport = await _context.IdeaReports.FindAsync(id);

            if (ideaReport == null)
            {
                return NotFound();
            }

            return ideaReport;
        }

        // PUT: api/IdeaReports/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutIdeaReport(int id, IdeaReport ideaReport)
        {
            if (id != ideaReport.IdeaReportId)
            {
                return BadRequest();
            }

            _context.Entry(ideaReport).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IdeaReportExists(id))
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

        // POST: api/IdeaReports
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<IdeaReport>> PostIdeaReport(IdeaReport ideaReport)
        {
            _context.IdeaReports.Add(ideaReport);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetIdeaReport), new { id = ideaReport.IdeaReportId }, ideaReport);
        }

        // DELETE: api/IdeaReports/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<IdeaReport>> DeleteIdeaReport(int id)
        {
            var ideaReport = await _context.IdeaReports.FindAsync(id);
            if (ideaReport == null)
            {
                return NotFound();
            }

            _context.IdeaReports.Remove(ideaReport);
            await _context.SaveChangesAsync();

            return ideaReport;
        }

        private bool IdeaReportExists(int id)
        {
            return _context.IdeaReports.Any(e => e.IdeaReportId == id);
        }
    }
}
