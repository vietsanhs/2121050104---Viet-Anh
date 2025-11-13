using Microsoft.AspNetCore.Mvc;
using DemoMVC104.Models;
using System;

namespace DemoMVC104.Controllers
{
    public class HelloController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new HelloViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(HelloViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            int currentYear = DateTime.Now.Year;
            int age = currentYear - model.YearOfBirth;

            model.Message = $"Xin chào {model.UserName}, bạn {age} tuổi.";

            return View(model);
        }
    }
}
