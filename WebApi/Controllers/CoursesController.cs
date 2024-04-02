using Infrastructure.Contexts;
using Infrastructure.Entities;
using Infrastructure.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi.Dtos;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CoursesController : ControllerBase
{
    private readonly DataContext _context;

    public CoursesController(DataContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll() => Ok(await _context.Courses.ToListAsync());



    [HttpGet("{id}")]
    public async Task<IActionResult> GetOne(int id)
    {
        var Course = await _context.Courses.FirstOrDefaultAsync(x => x.Id == id);
        if (Course != null)
        {
            return Ok(Course);
        }

        return NotFound();
    }


    [HttpPost]
    public async Task<IActionResult> CreateOne(CourseRegistrationForm form)
    {
        if (ModelState.IsValid)
        {
            var courseEntity = new CourseEntity
            {
                Title = form.Title,
                Author = form.Author,
                Price = form.Price,
                DiscountPrice = form.DiscountPrice,
                Hours = form.Hours,
                IsBestseller = form.IsBestseller,
                LikesInNumbers = form.LikesInNumbers,
                LikesInProcent = form.LikesInProcent,
            };

            _context.Courses.Add(courseEntity);
            await _context.SaveChangesAsync();

            return Created("", (Course)courseEntity);
        }
        return BadRequest();
    }
}
