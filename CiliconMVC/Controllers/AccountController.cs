using CiliconMVC.ViewModels;
using Infrastructure.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CiliconMVC.Controllers;

[Authorize]
public class AccountController : Controller
{
    private readonly UserManager<UserEntity> _userManager;
    private readonly SignInManager<UserEntity> _signInManager;

    public AccountController(UserManager<UserEntity> userManager, SignInManager<UserEntity> signInManager)
    {
        _userManager = userManager;
        _signInManager = signInManager;
    }

    [HttpGet]
    [Route("/account")]
    public async Task<IActionResult> Details()
    {
        //if (!_signInManager.IsSignedIn(User))
        //    return RedirectToAction("SignIn", "Auth");

        var userEntity = await _userManager.GetUserAsync(User);

        var viewModel = new AccountDetailsViewModel()
        {
            User = userEntity!
        };
        return View(viewModel);
    }

    [HttpPost]
    public async Task<IActionResult> BasicInfo(AccountDetailsViewModel viewModel)
    {
        return View(viewModel);
    }

    [HttpPost]
    public async Task<IActionResult> AddressInfo(AccountDetailsViewModel viewModel)
    {
        return View(viewModel);
    }
}

