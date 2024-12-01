using System;
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
    public class SpaceShuttleControllerZB : ControllerBase
    {
        private readonly AppDbContext _context;
        public SpaceShuttleControllerZB(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet("{id?}")]
        public async Task<ActionResult<IEnumerable<SpaceShuttleZB>>> GetSpaceShuttleZB(int? id)
        {
            if (id == null || id == 0)
            {
                // Returns first 5 results if id is null or zero
                return await _context.SpaceShuttle.Take(5).ToListAsync();
            }

            // Returns specific Shuttle by id
            var spaceShuttleZB = await _context.SpaceShuttle.FindAsync(id);

            if (spaceShuttleZB == null)
            {
                return NotFound();
            }

            return new List<SpaceShuttleZB> { spaceShuttleZB };
        }
         // PUT: api/SpaceShuttleZB/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSpaceShuttleZB(int id, SpaceShuttleZB spaceShuttleZB)
        {
            if (id != spaceShuttleZB.Id)
            {
                return BadRequest();
            }

            _context.Entry(spaceShuttleZB).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SpaceShuttleZBExists(id))
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

        // POST: api/SpaceShuttleZB
        [HttpPost]
        public async Task<ActionResult<SpaceShuttleZB>> PostSpaceShuttleZB(SpaceShuttleZB spaceShuttleZB)
        {
            _context.SpaceShuttle.Add(spaceShuttleZB);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetSpaceShuttleZB), new { id = spaceShuttleZB.Id }, spaceShuttleZB);
        }

        // DELETE: api/SpaceShuttleZB/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSpaceShuttleZB(int id)
        {
            var spaceShuttleZB = await _context.SpaceShuttle.FindAsync(id);
            if (spaceShuttleZB == null)
            {
                return NotFound();
            }

            _context.SpaceShuttle.Remove(spaceShuttleZB);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SpaceShuttleZBExists(int id)
        {
            return _context.SpaceShuttle.Any(e => e.Id == id);
        }
    }
}
