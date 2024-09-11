using Microsoft.AspNetCore.Mvc;
using Personal_Portfolio_Website.Models;
using System.Diagnostics;

namespace Personal_Portfolio_Website.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    namespace Portfolio.Controllers
    {
        public class HomeController : Controller
        {
            public IActionResult Index()
            {
                return View();
            }

            public IActionResult Projects()
            {
                return View();
            }

            public IActionResult Resume()
            {
                return View();
            }

            public IActionResult Contact()
            {
                return View();
            }

            [HttpPost]
            public IActionResult Contact(ContactFormModel model)
            {
                if (ModelState.IsValid)
                {
                    // Handle form submission, e.g., send email or save data to the database
                    ViewBag.Message = "Thank you for reaching out!";
                }
                return View();
            }
        }
    }
}
