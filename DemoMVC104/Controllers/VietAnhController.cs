using Microsoft.AspNetCore.Mvc;

namespace DemoMVC104.Controllers
{
    public class VietAnhController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}