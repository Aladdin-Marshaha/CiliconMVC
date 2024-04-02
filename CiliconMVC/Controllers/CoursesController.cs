using Infrastructure.Entities;
using Infrastructure.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace CiliconMVC.Controllers;

public class CoursesController : Controller
{

    [Route("/courses")]
    public async Task <IActionResult> Courses()
    {
        using var http = new HttpClient();
        var response = await http.GetAsync("https://localhost:7190/api/courses");
        var json = await response.Content.ReadAsStringAsync();
        var data = JsonConvert.DeserializeObject<IEnumerable<CourseEntity>>(json);

        return View(data);
    }



    [Route("/course/details")]
    public async Task<IActionResult> CourseDetails()
    {
        using var http = new HttpClient();
        var response = await http.GetAsync("https://localhost:7190/api/courses/2");
        var json = await response.Content.ReadAsStringAsync();
        var data = JsonConvert.DeserializeObject<CourseEntity>(json);

        return View(data);
    }


    [HttpGet]
    [Route("/course/register/form")]
    public IActionResult CourseRegisterForm(CourseRegistrationFormViewModel viewModel)
    {
        return View(viewModel);
    }



    [HttpPost]
    [Route("/Courses/CreateCourse")]
    public async Task<IActionResult> CreateCourse(CourseRegistrationFormViewModel viewModel)
    {
        if (ModelState.IsValid)
        {
            using var http = new HttpClient();

            var json = JsonConvert.SerializeObject(viewModel);
            using var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await http.PostAsync("https://localhost:7190/api/courses", content);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Courses", "Courses");
            }
        }
        return View(viewModel); 
    }
}
