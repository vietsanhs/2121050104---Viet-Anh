using Microsoft.AspNetCore.Mvc;


namespace DemoMvc104.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            ViewData ["Message"] = "Buổi học 3";
            return View();
        }
    }
}