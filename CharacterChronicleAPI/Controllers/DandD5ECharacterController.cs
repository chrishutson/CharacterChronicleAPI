using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CharacterChronicleAPI.Models;

namespace CharacterChronicleAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DandD5ECharacterController : ControllerBase
    {
        private readonly DandD5ECharacterContext _context;

        public DandD5ECharacterController(DandD5ECharacterContext context)
        {
            _context = context;
        }

        // GET: api/DandD5ECharacter
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DandD5ECharacter>>> GetDandD5ECharacterItems()
        {
            return await _context.DandD5ECharacterItems.ToListAsync();
        }

        // GET: api/DandD5ECharacter/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DandD5ECharacter>> GetDandD5ECharacter(long id)
        {
            var dandD5ECharacter = await _context.DandD5ECharacterItems.FindAsync(id);

            if (dandD5ECharacter == null)
            {
                return NotFound();
            }

            return dandD5ECharacter;
        }

        // PUT: api/DandD5ECharacter/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDandD5ECharacter(long id, DandD5ECharacter dandD5ECharacter)
        {
            if (id != dandD5ECharacter.Id)
            {
                return BadRequest();
            }

            _context.Entry(dandD5ECharacter).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DandD5ECharacterExists(id))
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

        // POST: api/DandD5ECharacter
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DandD5ECharacter>> PostDandD5ECharacter(DandD5ECharacter dandD5ECharacter)
        {
            _context.DandD5ECharacterItems.Add(dandD5ECharacter);
            await _context.SaveChangesAsync();

            //return CreatedAtAction("GetDandD5ECharacter", new { id = dandD5ECharacter.Id }, dandD5ECharacter);
            return CreatedAtAction(nameof(GetDandD5ECharacter), new { id = dandD5ECharacter.Id }, dandD5ECharacter);
        }

        // DELETE: api/DandD5ECharacter/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDandD5ECharacter(long id)
        {
            var dandD5ECharacter = await _context.DandD5ECharacterItems.FindAsync(id);
            if (dandD5ECharacter == null)
            {
                return NotFound();
            }

            _context.DandD5ECharacterItems.Remove(dandD5ECharacter);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DandD5ECharacterExists(long id)
        {
            return _context.DandD5ECharacterItems.Any(e => e.Id == id);
        }
    }
}
