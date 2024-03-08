using CiliconMVC.ViewModels;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace CiliconMVC.Controllers;

public class AuthController : Controller
{
    private readonly UserService _userService;

    public AuthController(UserService userService)
    {
        _userService = userService;
    }

    [HttpGet]
    [Route("/signup")]
    public IActionResult SignUp()
    {
        var viewModel = new SignUpViewModel();
        return View(viewModel);
    }

    [HttpPost]
    [Route("/signup")]
    public async Task<IActionResult> SignUp(SignUpViewModel viewModel)
    {
        if (ModelState.IsValid)
        {
            var result = await _userService.CreateUserAsync(viewModel.Form);
            if (result.StatusCode == Infrastructure.Models.StatusCode.Ok)
                return RedirectToAction("SignIn", "Auth");
        }
        return View(viewModel);

    }


    [HttpGet]
    [Route("/signin")]
    public IActionResult SignIn()
    {
        var viewModel = new SignInViewModel();
        return View(viewModel);
    }
     
    [HttpPost]
    [Route("/signin")]
    public async Task<IActionResult> SignIn(SignInViewModel viewModel)
    {
        if (ModelState.IsValid)
        {
            var result = await _userService.SignInUserAsync(viewModel.Form);
            if (result.StatusCode == Infrastructure.Models.StatusCode.Ok)
                return RedirectToAction("Details" , "Account");
        }
             
        viewModel.ErrorMessage = "Incorrect email or password";
            return View(viewModel);
    }       
}

