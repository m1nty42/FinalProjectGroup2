using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FinalProjectGroup2.Data;
using FinalProjectGroup2.Models;

namespace FinalProjectGroup2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VidGameXMsController : ControllerBase
    {
        private readonly AppDbContextXM _context;

        public VidGameXMsController(AppDbContextXM context)
        {
            _context = context;
        }

        // GET: api/VidGameXMs
        [HttpGet("{id?}")]
        public async Task<ActionResult<IEnumerable<VidGameXM>>> GetVidGameXM(int? id)
        {
            if (id == null || id == 0)
            {
                // Return the first 5 results when id is null or zero
                return await _context.VideoGames.Take(5).ToListAsync();
            }

            // Fetch a specific video game by id
            var vidGameXM = await _context.VideoGames.FindAsync(id);

            if (vidGameXM == null)
            {
                return NotFound();
            }

            return new List<VidGameXM> { vidGameXM };
        }


        // PUT: api/VidGameXMs/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVidGameXM(int id, VidGameXM vidGameXM)
        {
            if (id != vidGameXM.Id)
            {
                return BadRequest();
            }

            _context.Entry(vidGameXM).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VidGameXMExists(id))
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

        // POST: api/VidGameXMs
        [HttpPost]
        public async Task<ActionResult<VidGameXM>> PostVidGameXM(VidGameXM vidGameXM)
        {
            _context.VideoGames.Add(vidGameXM);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetVidGameXM), new { id = vidGameXM.Id }, vidGameXM);
        }

        // DELETE: api/VidGameXMs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVidGameXM(int id)
        {
            var vidGameXM = await _context.VideoGames.FindAsync(id);
            if (vidGameXM == null)
            {
                return NotFound();
            }

            _context.VideoGames.Remove(vidGameXM);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool VidGameXMExists(int id)
        {
            return _context.VideoGames.Any(e => e.Id == id);
        }
    }
}
