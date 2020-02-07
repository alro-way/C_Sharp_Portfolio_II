using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace C_Sharp_Portfolio_II.Controllers
{
    public class ProjectsController : Controller  
    {
        [HttpGet("projects")]
        public IActionResult Projects()
        {
            ViewBag.Projects =  "This is my projects!";
            return View("Projects");
        }

    }
}
