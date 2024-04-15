using Infrastructure.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace CiliconMVC.Controllers;

public class HomeController(HttpClient http) : Controller
{
    private readonly HttpClient _http = http;

    [Route("/")]
    public IActionResult Index()
    {
        return View();
    }



    [HttpPost]
    public async Task<IActionResult> Subscribe(SubscribeViewModel viewModel)
    {
        try 
        {
            var content = new StringContent(JsonConvert.SerializeObject(viewModel), Encoding.UTF8,"application/json");
            var response = await _http.PostAsync("https://localhost:7190/api/subscribers", content);

            if (response.IsSuccessStatusCode)
            {
                ViewData["Status"] = "Success";
            }
            else if (response.StatusCode == System.Net.HttpStatusCode.Conflict)
            {
                ViewData["Status"] = "AlreadyExists";
            }
        } 
        catch
        {
            ViewData["Status"] = "Invalid";
        }
        return RedirectToAction("Index");
    }
}
