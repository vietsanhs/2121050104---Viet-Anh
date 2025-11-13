using DemoMVC104.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoMVC104.Controllers
{
    public class StudentController : Controller
    {
        // Hiển thị form nhập dữ liệu
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // Nhận dữ liệu từ form 
        [HttpPost]
        public IActionResult Create(Student std)
        {
            // sau này có thể lưu database, tạm thời chuyển sang trang Info
            return View("Info", std);
        }

        // Hiển thị dữ liệu ra view Info
        public IActionResult Info(Student std)
        {
            return View(std);
        }
    }
}
