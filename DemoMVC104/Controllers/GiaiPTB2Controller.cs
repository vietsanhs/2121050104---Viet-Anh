using Microsoft.AspNetCore.Mvc;

namespace DemoMVC104.Controllers
{
    public class GiaiPTB2Controller : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(double a, double b, double c)
        {
            string ketqua = "";

            if (a == 0)
            {
                // Phương trình bậc 1
                if (b == 0)
                {
                    ketqua = (c == 0) 
                        ? "Phương trình vô số nghiệm" 
                        : "Phương trình vô nghiệm";
                }
                else
                {
                    double x = -c / b;
                    ketqua = $"Phương trình có 1 nghiệm: x = {x}";
                }
            }
            else
            {
                // Phương trình bậc 2
                double delta = b * b - 4 * a * c;

                if (delta < 0)
                {
                    ketqua = "Phương trình vô nghiệm";
                }
                else if (delta == 0)
                {
                    double x = -b / (2 * a);
                    ketqua = $"Phương trình có nghiệm kép: x = {x}";
                }
                else
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    ketqua = $"Phương trình có 2 nghiệm: x1 = {x1}, x2 = {x2}";
                }
            }

            ViewBag.ThongBao = ketqua;
            return View();
        }
    }
}
