using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Demo_MVC.Models;
namespace Demo_MVC.Controllers
{
    public class TinhHoaDonController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(TinhHoaDon thd)
        {
            if (thd.Soluong <= 0 || thd.Dongia <= 0)
            {
                ViewBag.Message = "Giá trị không hợp lệ";
                return View();
            }
            else
            {
                double tongtien = thd.Soluong * thd.Dongia;
                ViewBag.Message  = "Tổng số tiền bạn cần thanh toán là "+tongtien + " VND";
                return View();
            }
        }
    }
}