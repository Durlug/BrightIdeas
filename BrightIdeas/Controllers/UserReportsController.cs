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
    public class UserReportsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public UserReportsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/UserReports
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserReport>>> GetUserReports()
        {
            return await _context.UserReports.ToListAsync();
        }

        // GET: api/UserReports/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UserReport>> GetUserReport(int id)
        {
            var userReport = await _context.UserReports.FindAsync(id);

            if (userReport == null)
            {
                return NotFound();
            }

            return userReport;
        }

        // PUT: api/UserReports/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUserReport(int id, UserReport userReport)
        {
            if (id != userReport.UserReportId)
            {
                return BadRequest();
            }

            _context.Entry(userReport).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserReportExists(id))
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

        // POST: api/UserReports
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<UserReport>> PostUserReport(UserReport userReport)
        {
            _context.UserReports.Add(userReport);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetUserReport), new { id = userReport.UserReportId }, userReport);
        }

        // DELETE: api/UserReports/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<UserReport>> DeleteUserReport(int id)
        {
            var userReport = await _context.UserReports.FindAsync(id);
            if (userReport == null)
            {
                return NotFound();
            }

            _context.UserReports.Remove(userReport);
            await _context.SaveChangesAsync();

            return userReport;
        }

        private bool UserReportExists(int id)
        {
            return _context.UserReports.Any(e => e.UserReportId == id);
        }
    }
}
