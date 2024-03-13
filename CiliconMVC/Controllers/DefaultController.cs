using Microsoft.AspNetCore.Mvc;

namespace CiliconMVC.Controllers
{
    public class DefaultController : Controller
    {

        [Route("/error")]
        public IActionResult Error404(int statusCode)
        {
            return View();
        }
    }
}

