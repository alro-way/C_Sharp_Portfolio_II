using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace C_Sharp_Portfolio_II.Controllers
{
    public class HomeController : Controller  
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            ViewBag.HomeIndex = "Cool! This is my Index!";
            return View();
        }

        // [HttpGet("projects")]
        // public IActionResult Projects()
        // {
        //     ViewBag.Projects =  "This is my projects!";
        //     return View();
        // }

        // [HttpGet("contact")]
        // public IActionResult Contact()
        // {
        //     ViewBag.Contact = "This is my contact!";
        //     return View();
        // }

    }
}
