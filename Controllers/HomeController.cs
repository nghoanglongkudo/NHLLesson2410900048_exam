using Microsoft.AspNetCore.Mvc;
using NguyenHoangLong2410900048_exam.Models;
using NHLLesson2410900048_exam.Models;
using System.Diagnostics;

namespace NguyenHoangLong2410900048_exam.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // Trang chủ mặc định
        public IActionResult Index()
        {
            return View();
        }

        // Trang Chính sách bảo mật mặc định
        public IActionResult Privacy()
        {
            return View();
        }

        // Action NhlAbout - Hiển thị thông tin sinh viên
        public IActionResult NhlAbout()
        {
            ViewBag.MaSV = "2410900048";
            ViewBag.HoTen = "Nguyễn Hoàng Long";
            ViewBag.Lop = "K24CNT2";
            return View();
        }

        // Trang xử lý lỗi mặc định
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}