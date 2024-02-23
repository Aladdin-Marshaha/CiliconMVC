using CiliconMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CiliconMVC.Controllers;

public class AuthController : Controller
{
    [Route("/signup")]
    [HttpGet]
    public IActionResult SignUp()
    {
        var viewModel = new SignUpViewModel();
        return View(viewModel);
    }

    [Route("/signup")]
    [HttpPost]
    public IActionResult SignUp(SignUpViewModel model)
    {
        return View();
    }

    [Route("/signin")]
    public IActionResult SignIn()
    {
        return View();
    }
}
