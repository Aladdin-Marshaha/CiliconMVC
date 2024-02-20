using Microsoft.AspNetCore.Mvc;

namespace CiliconMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
