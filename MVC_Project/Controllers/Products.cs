﻿using Microsoft.AspNetCore.Mvc;

namespace MVC_Project.Controllers
{
    public class Products : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
