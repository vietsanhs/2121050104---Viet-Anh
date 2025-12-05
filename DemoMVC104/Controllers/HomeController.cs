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




// ================================
// CẤU HÌNH VÀ KẾT NỐI VỚI CSDL
// ================================


//    Một ứng dụng ASP.NET MVC sử dụng Entity Framework thường bao gồm 3 phần chính:

//                Model – Đại diện cho dữ liệu, ánh xạ vào bảng trong cơ sở dữ liệu.

//                View – Giao diện hiển thị dữ liệu ra màn hình.

//                 Controller – Nhận request → xử lý logic → trả kết quả ra View.

   // Cài đặt các package

// 1. Tạo Controller (PersonController.cs)
//    - Trong Controllers tạo file PersonController.cs
//    - Tạo action Index để lấy dữ liệu từ CSDL và trả về View.

// 2. Tạo View tương ứng
//    - Trong Views tạo thư mục Person
//    - Tạo file Index.cshtml để hiển thị dữ liệu.
//    - Khi người dùng  nhập dữ liệu (Create hoặc Edit), View sẽ chứa form (asp-action="Index")
//      và gửi dữ liệu lại lên Controller bằng phương thức [HttpPost].
//    - Sau khi Controller xử lý dữ liệu xong sẽ gửi lại cho View để hiển thị.


// 3. Cập nhật Model (Person.cs)
//    - Trong folder Models tạo class Person.cs
//    - Khai báo các thuộc tính (Id, Name, Age, Address,...)
//    => Đây là class ánh xạ sang bảng trong cơ sở dữ liệu. ((Báo cho Entity Framework biết rằng class Person ánh xạ (map) vào bảng Persons trong database.)



// 4. Tạo DbContext
//    - Kết nối database
//    - Tạo thự mục Data trong đó tạo class ApplicationDbContext.cs
//    - Kế thừa DbContext và khai báo DbSet<Person>
//    => Đây là cầu nối giữa ứng Models và database. 

// 5. Cấu hình Connection String
//    - Mở Web.config và khai báo connectionString
//      chứa thông tin server, database, user/password (nếu có).


// 6. Tạo bảng và cập nhật vào Database bằng Entity Framework
//    - Lệnh tạo Migration:
//          dotnet ef migrations add Create_Table_Person
//
//    - Lệnh cập nhật bảng vào database:
//          dotnet ef database update
//
//    - Nếu cần xoá migration lỗi: (Xóa migration cuối cùng (nếu chưa update database)
//          dotnet ef migrations remove

//    - Migration là cơ chế để:

//      Tự động tạo bảng

//      Tự động sửa bảng khi Model thay đổi

//      Giúp lưu lại lịch sử thay đổi cấu trúc database




// 7. Thực hiện CRUD
//    - READ: Lấy danh sách dữ liệu để hiển thị trong View (Index)

//    - CREATE: // Người dùng nhập dữ liệu vào form Create

                // Controller nhận dữ liệu

                 //Lưu vào database bằng db.Add() và db.SaveChanges()

//    - UPDATE: //  Tải dữ liệu cũ lên form Edit
                //  Ng dùng sửa => Controller nhận dữ liệu => Cập nhật dữ liệu database

//    - DELETE: Xoá dữ liệu theo Id
//
//    => Các thao tác đều thông qua DbContext:
//          db.Persons.Add();
//          db.Persons.Update();
//          db.Persons.Remove();
//          db.SaveChanges();


//  tạo 


// Sinh Code tự đông sinh ra mã nguồn Controller và View dựa trên Model 





// /*

// // Xây dựng chức năng Đọc dữ liệu từ file Excel lưu vào trong Cơ Sở Dữ Liệu

// // B1 Cài đặt thư viện (EPP Plus)

//    B2 Tạo giao diện Upload file Excel (Sử dụng I FORM FILE)

//    B3 Tạo file Excel mẫu có chứa dữ liệu

//    B4 Upload file Excel, đọc dữ liệu chuyển sang dạng dataTable hoặc List

//    B5 Sử dụng vòng lặp để duyệt qua dữ liệu ở bước 4 Tương ứng mỗi một dòng sẽ tạo một đối tượng và gán giá trị của các cột cho thuộc tính tương ứng. Sau đó thêm đối tượng vào DbContext

//    B6 Kết thúc vòng lặp, tiến hành lưu thay đổi vào CSDL sau đó điều hướng về trang Index

//    */