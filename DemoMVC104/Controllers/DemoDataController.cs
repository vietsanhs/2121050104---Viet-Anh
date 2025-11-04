using Microsoft.AspNetCore.Mvc;

namespace FirstWebMVC.Controllers
{
    public class DemoDataController : Controller
    {
        // Gửi dữ liệu sang View bằng ViewBag và ViewData
        public IActionResult Index()
        {
            ViewData["Title"] = "Ví dụ về ViewData và ViewBag";
            ViewData["Message"] = "Xin chào từ ViewData 👋";

            ViewBag.Name = "Việt Anh";
            ViewBag.Age = 22;
            ViewBag.Note = "Dữ liệu này được truyền bằng ViewBag ";

            return View();
        }

        // Gửi dữ liệu bằng TempData và chuyển hướng
        public IActionResult RedirectPage()
        {
            TempData["Alert"] = "Dữ liệu này đi qua Redirect nhờ TempData 🚀";
            return RedirectToAction("ShowTempData");
        }

        // Hiển thị dữ liệu nhận được từ TempData
        public IActionResult ShowTempData()
        {
            return View();
        }
    }
}