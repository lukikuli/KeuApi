using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using KeuAPI.Models;
using KeuAPI.Repositories;
using Microsoft.AspNetCore.Authorization;

namespace KeuAPI.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class AgamasController : ControllerBase
    {
        //private readonly KeuApiContext _context;
        private readonly IAgamaRepository _repository;
        public AgamasController(IAgamaRepository repository)
        {
            _repository = repository;
        }

        // GET: api/Agamas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Agama>>> GetAgama()
        {
            return await _repository.GetAllAgamaAsync();
        }

        // GET: api/Agamas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Agama>> GetAgama(Guid id)
        {
            return await _repository.GetAgamaByIdAsync(id);
        }

        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutAgama(Guid? id, Agama agama)
        //{
        //    if (id != agama.AgamaId)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(agama).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!AgamaExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //[HttpPost]
        //public async Task<ActionResult<Agama>> PostAgama(Agama agama)
        //{
        //    _context.Agama.Add(agama);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetAgama", new { id = agama.AgamaId }, agama);
        //}

        //[HttpDelete("{id}")]
        //public async Task<ActionResult<Agama>> DeleteAgama(Guid? id)
        //{
        //    var agama = await _context.Agama.FindAsync(id);
        //    if (agama == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Agama.Remove(agama);
        //    await _context.SaveChangesAsync();

        //    return agama;
        //}

        //private bool AgamaExists(Guid? id)
        //{
        //    return _context.Agama.Any(e => e.AgamaId == id);
        //}
    }
}
