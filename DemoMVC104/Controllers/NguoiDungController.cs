using Microsoft.AspNetCore.Mvc;

namespace DemoMVC104.Controllers
{
    public class NguoiDungController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string HoTen, string Email , string SốĐT)
        {
            ViewBag.ThongBao = $"Tên của bạn:{HoTen}<br/>  Email:{Email}<br/>  Số điện thoại:{SốĐT}<br/>";
            return View();
        }

        
    }
}