using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FinalProjectGroup2.Data;
using FinalProjectGroup2.Models;

namespace FinalProjectGroup2.Controllers

    //Marian Muntean
{
    [Route("api/[controller]")]
    [ApiController]
    public class CollegeTeamControllerMM : ControllerBase
    {
        private readonly CollegeTeamDbContext _context;

        public CollegeTeamControllerMM(CollegeTeamDbContext context)
        {
            _context = context;
        }

        // GET: College Team ID
        [HttpGet("{id?}")]
        public async Task<ActionResult<IEnumerable<CollegeTeamMM>>> GetCollegeTeamMM(int? id)
        {
            if (id == null || id == 0)
            {
                // Return the first 5 results when id is null/zero
                return await _context.CollegeTeam.Take(5).ToListAsync();
            }

            // Get a specific team member by id
            var collegeTeam = await _context.CollegeTeam.FindAsync(id);

            if (collegeTeam == null)
            {
                return NotFound();
            }

            return new List<CollegeTeamMM> { collegeTeam };
        }

        // PUT: College Team ID
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCollegeTeamMM(int id, CollegeTeamMM collegeTeam)
        {
            if (id != collegeTeam.Id)
            {
                return BadRequest();
            }

            _context.Entry(collegeTeam).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CollegeTeamMMExists(id))
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

        // POST: College Team
        [HttpPost]
        public async Task<ActionResult<CollegeTeamMM>> PostTeamMemberEC(CollegeTeamMM collegeTeam)
        {
            _context.CollegeTeam.Add(collegeTeam);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetCollegeTeamMM), new { id = collegeTeam.Id }, collegeTeam);
        }

        // DELETE: College Team
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCollegeTeamMM(int id)
        {
            var collegeTeam = await _context.CollegeTeam.FindAsync(id);
            if (collegeTeam == null)
            {
                return NotFound();
            }

            _context.CollegeTeam.Remove(collegeTeam);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CollegeTeamMMExists(int id)
        {
            return _context.CollegeTeam.Any(e => e.Id == id);
        }
    }
}
