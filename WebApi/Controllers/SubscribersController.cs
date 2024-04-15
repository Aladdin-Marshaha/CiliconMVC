using Infrastructure.Contexts;
using Infrastructure.Dtos;
using Infrastructure.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EndpointsOchDTOModels.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SubscribersController(DataContext context) : ControllerBase
{
    private readonly DataContext _context = context;

    #region CREATE
    [HttpPost]
    public async Task<IActionResult> Create(Subscriber dto)
    {
        if (ModelState.IsValid)
        {
            if (!await _context.Subscribers.AnyAsync(x => x.Email == dto.Email))
            {
                _context.Subscribers.Add(dto);
                await _context.SaveChangesAsync();
                return Created("", null);
            }
            else
            {
                return Conflict();
            }
        }
        return BadRequest();
    }

    #endregion

    #region GET ALL
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var subscribers = await _context.Subscribers.ToListAsync();
        if (subscribers.Count != 0)
        {
            return Ok(subscribers);
        }
        return NotFound();
    }

    #endregion

    #region GET ONE
    [HttpGet("{id}")]
    public async Task<IActionResult> GetOne(string email)
    {
        var subscriber = await _context.Subscribers.FirstOrDefaultAsync(x => x.Email == email);
        if (subscriber != null)
        {
            return Ok(subscriber);
        }

        return NotFound();
    }

    #endregion

    #region UPDATE

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateOne(string email)
    {
        var subscriber = await _context.Subscribers.FirstOrDefaultAsync(x => x.Email == email);
        if (subscriber != null)
        {
            subscriber.Email = email;
            _context.Subscribers.Update(subscriber);
            await _context.SaveChangesAsync();

            return Ok(subscriber);
        }

        return NotFound();
    }

    #endregion

    #region DELETE

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteOne(string email)
    {
        var subscriber = await _context.Subscribers.FirstOrDefaultAsync(x => x.Email == email);
        if (subscriber != null)
        {
            _context.Subscribers.Remove(subscriber);
            await _context.SaveChangesAsync();

            return Ok();
        }

        return NotFound();
    }

    #endregion
}
