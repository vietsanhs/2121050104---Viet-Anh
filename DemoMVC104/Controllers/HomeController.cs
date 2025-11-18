using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DemoMVC104.Models;

namespace DemoMVC104.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}


// tên project . tên thư mục . 
// Các bước nhận dữ liệu từ View Và Controller  **

// - Tạo Controller(.cs) => Tạo action => Trả về View
// - Tạo View cho người dùng nhập vào và gửi dữ liệu => Tạo form => Action và Controller
// - Controller nhận dữ liệu từ View gửi lên => Action [httpPost], parameter      - Một Action có đánh dấu [HttpPost]

                                                                                  // Các tham số (parameter) trong Action trùng với tên các input trong form)
// - Sử dụng ViewBag để gử từi dữ liệu Controller => View => ViewBag.ThongBao
// - View hiển thị dữ liệu từ Controller trả về => @ViewBag.ThongBao





// [HttpGet] và [HttpPost]  **

// [HttpGet] dùng để hiển thị trang hoặc lấy dữ liệu ban đầu từ server.
// Nó là mặc định khi người dùng vừa truy cập trang lần đầu (chưa bấm nút gửi form).

// [HttpPost] dùng khi người dùng nhấn nút Gửi (Submit) form.
// Dữ liệu mà bạn nhập trong form sẽ được gửi lên server để xử lý (ví dụ: tính toán, lưu database, v.v...).


// =>  Người dùng mở trang → chạy hàm [HttpGet] → hiển thị form.

// =>  Người dùng nhập thông tin và bấm Gửi → chạy hàm [HttpPost] → xử lý dữ liệu → hiển thị kết quả.




// Giải thích thẻ form có :  asp-action="Index":  Cho biết cái Form này sẽ gửi đến Action nào trong Controller  (Trong Controller có Action là index thì thẻ form này sẽ gửi đến đúng action Index trong của Controller)
                            // method= "post"  [httpPost]  : Khi người dùng bấm “Gửi”, trình duyệt sẽ gửi dữ liệu form bằng phương thức POST đến action Index trong HelloController.


// **<p>@ViewBag.ThongBao</p> và <p>@Html.Raw(ViewBag.ThongBao)</p>

// <p>@ViewBag.ThongBao</p>:  Khi muốn hiển thị chữ

// <p>@Html.Raw(ViewBag.ThongBao)</p>: hiển thị đẹp, có HTML