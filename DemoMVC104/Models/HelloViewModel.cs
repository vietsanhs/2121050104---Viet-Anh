using System;
using System.ComponentModel.DataAnnotations;

namespace DemoMVC104.Models
{
    public class HelloViewModel
    {
        [Required(ErrorMessage = "Xin mời nhập tên")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Xin mời nhập năm sinh")]
        [Range(1970, 2025, ErrorMessage = "Năm sinh không hợp lệ")]
        public int YearOfBirth { get; set; }

        public string Message { get; set; } = string.Empty;
    }
}
