using Infrastructure.Entities;
using Infrastructure.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace CiliconMVC.Controllers;

public class SubscribersController : Controller
{
    [Route("/subscribe")]
    public IActionResult Subscribe()
    {
        return View(new SubscribeViewModel());
    }


    [Route("/subscribe")]
    [HttpPost]
    public async Task<IActionResult> Subscribe(SubscribeViewModel viewModel)
    {
        if (ModelState.IsValid)
        {
            using var http = new HttpClient();

            var url = $"https://localhost:7190/api/Subscribers?email={viewModel.Email}";
            var request = new HttpRequestMessage(HttpMethod.Post, url);

            var response = await http.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                viewModel.IsSubscribed = true;
            }
        }
        return View(viewModel);
    }
}

