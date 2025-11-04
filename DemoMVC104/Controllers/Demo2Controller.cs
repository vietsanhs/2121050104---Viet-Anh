using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace DemoMVC104.Controllers
{
    public class DemoController : Controller
    {
        // 1. ViewResult → Trả về giao diện
        public IActionResult ViewExample()
        {
            ViewBag.Message = " Ví dụ về ViewResult";
            return View(); // Views/Demo/ViewExample.cshtml
        }

        // 2. RedirectResult → Chuyển hướng đến URL ngoài
        public IActionResult RedirectExample()
        {
            return Redirect("https://www.google.com");
        }

        // 3. RedirectToActionResult → Chuyển hướng đến action khác trong cùng project
        public IActionResult RedirectToActionExample()
        {
            return RedirectToAction("ViewExample");
        }

        // 4. JsonResult → Trả về dữ liệu JSON
        public IActionResult JsonExample()
        {
            var data = new
            {
                Name = "Việt Anh",
                Age = 22,
                Message = "Ví dụ về JsonResult"
            };
            return Json(data);
        }

        // 5. FileResult → Trả về file để tải về
        public IActionResult FileExample()
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/files/demo.txt");
            var fileBytes = System.IO.File.ReadAllBytes(filePath);
            return File(fileBytes, "text/plain", "TaiLieuDemo.txt");
        }

        // 6. StatusCodeResult → Trả về mã trạng thái HTTP
        public IActionResult StatusExample(int code)
        {
            // code: 200, 400, 404, 500 ...
            return StatusCode(code);
        }
    }
}