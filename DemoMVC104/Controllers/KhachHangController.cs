using Microsoft.AspNetCore.Mvc;

namespace DemoMVC104.Controllers
{
    public class KhachHangController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string HoTen , int YearOfBirth)
        {
            int tuoi = DateTime.Now.Year - YearOfBirth;
            ViewBag.ThongBao = $"Xin chào: {HoTen} , bạn năm nay: {tuoi} tuổi";
            return View();
        }
    }
}