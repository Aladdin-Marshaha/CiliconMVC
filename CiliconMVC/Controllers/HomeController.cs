﻿using Microsoft.AspNetCore.Mvc;

namespace CiliconMVC.Controllers
{
    public class HomeController : Controller
    {

        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }
    }

}
