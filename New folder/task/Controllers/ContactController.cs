﻿using Microsoft.AspNetCore.Mvc;

namespace Task22_12_2021.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
