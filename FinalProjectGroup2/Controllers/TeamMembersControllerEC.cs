using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FinalProjectGroup2.Data;
using FinalProjectGroup2.Models;

namespace FinalProjectGroup2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamMembersControllerEC : ControllerBase
    {
        private readonly AppDbContextEC _context;

        public TeamMembersControllerEC(AppDbContextEC context)
        {
            _context = context;
        }

        // GET: api/TeamMembers/{id?}
        [HttpGet("{id?}")]
        public async Task<ActionResult<IEnumerable<TeamMemberEC>>> GetTeamMemberEC(int? id)
        {
            if (id == null || id == 0)
            {
                // Return the first 5 results when id is null/zero
                return await _context.TeamMembers.Take(5).ToListAsync();
            }

            // Fetch a specific team member by id
            var teamMember = await _context.TeamMembers.FindAsync(id);

            if (teamMember == null)
            {
                return NotFound();
            }

            return new List<TeamMemberEC> { teamMember };
        }

        // PUT: api/TeamMembers/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTeamMemberEC(int id, TeamMemberEC teamMember)
        {
            if (id != teamMember.Id)
            {
                return BadRequest();
            }

            _context.Entry(teamMember).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TeamMemberECExists(id))
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

        // POST: api/TeamMembers
        [HttpPost]
        public async Task<ActionResult<TeamMemberEC>> PostTeamMemberEC(TeamMemberEC teamMember)
        {
            _context.TeamMembers.Add(teamMember);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetTeamMemberEC), new { id = teamMember.Id }, teamMember);
        }

        // DELETE: api/TeamMembers/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTeamMemberEC(int id)
        {
            var teamMember = await _context.TeamMembers.FindAsync(id);
            if (teamMember == null)
            {
                return NotFound();
            }

            _context.TeamMembers.Remove(teamMember);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TeamMemberECExists(int id)
        {
            return _context.TeamMembers.Any(e => e.Id == id);
        }
    }
}
