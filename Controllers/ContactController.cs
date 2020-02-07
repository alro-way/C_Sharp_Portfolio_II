using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace C_Sharp_Portfolio_II.Controllers
{
    public class ContactController : Controller  
    {

        [HttpGet("contact")]
        public IActionResult Contact()
        {
            ViewBag.Contact = "This is my contact!";
            return View("Contact");
        }

    }
}
