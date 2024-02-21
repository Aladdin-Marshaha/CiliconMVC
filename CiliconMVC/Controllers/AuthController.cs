using Microsoft.AspNetCore.Mvc;

namespace CiliconMVC.Controllers;

public class AuthController : Controller
{
    public IActionResult SignUp()
    {
        return View();
    }
}
