
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SkateRate.Models;

namespace SkateRate.Controllers
{

  [Route("api/[controller]")]
  [Produces("application/json")]
  [ApiController]
  public class ParksController : ControllerBase
  {
    private readonly SkateRateContext _db;

    public ParksController(SkateRateContext db)
    {
      _db = db;
    }

    // GET api/Parks
    [HttpGet]
    public async Task<List<Park>> Get(string location, string nickname, string name, int rating)
    {
      IQueryable<Park> query = _db.Parks.AsQueryable();

      if (location != null)
      {
        query = query.Where(entry => entry.Location == location);
      }

      if (nickname != null)
      {
        query = query.Where(entry => entry.Nickname == nickname);
      }

      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }

      if (rating > 0)
      {
        query = query.Where(entry => entry.Rating >= rating);
      }

      return await query.ToListAsync();
    }


    /// <summary>
    /// Creates a Park.
    /// </summary>
    /// <param name="park"></param>
    /// <returns>A newly created Park</returns>
    /// <remarks>
    /// Sample request:
    ///
    ///     POST /Park
    ///     {
    ///        "ParkId": 1,
    ///        "Name": "Garage #1",
    ///        "Location": "Portland",
    ///        "Rating": 5,
    ///        "Nickname": "the spot"
    ///     }
    ///
    /// </remarks>
    /// <response code="201">Returns the newly created park</response>
    /// <response code="400">If the park is null</response>
    // POST api/Parks
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Park>> Post(Park park)
    {
      _db.Parks.Add(park);
      await _db.SaveChangesAsync();

      return CreatedAtAction("Post", new { id = park.ParkId }, park);
    }


    /// <summary>
    /// Deletes a specific park.
    /// </summary>
    /// <param name ="id"></param>
    /// <returns></returns>
    // DELETE: api/Parks/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletePark(int id)
    {
      var park = await _db.Parks.FindAsync(id);
      if (park == null)
      {
        return NotFound();
      }

      _db.Parks.Remove(park);
      await _db.SaveChangesAsync();

      return NoContent();
    }

    // PUT: api/Parks/5
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Park park)
    {
      if (id != park.ParkId)
      {
        return BadRequest();
      }

      _db.Entry(park).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!ParkExists(id))
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


    [HttpGet("{id}")]
    public async Task<ActionResult<Park>> GetPark(int id)
    {
        var park = await _db.Parks.FindAsync(id);

        if (park == null)
        {
            return NotFound();
        }

        return park;
    }
     private bool ParkExists(int id)
    {
      return _db.Parks.Any(e => e.ParkId == id);
    }
  }
}