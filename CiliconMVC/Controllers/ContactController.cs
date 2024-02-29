using CiliconMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CiliconMVC.Controllers;

public class ContactController : Controller
{
    [Route("/contact")]
    public IActionResult Contact()
    {
        var viewModel = new ContactUsViewModel();
        return View(viewModel);
    }

    [Route("/contact")]
    [HttpPost]
    public IActionResult Contact(ContactUsViewModel viewModel)
    {
        if (!ModelState.IsValid)
            return View(viewModel);
        return RedirectToAction("Contact");
    }
}
