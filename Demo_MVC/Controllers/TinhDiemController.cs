using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Demo_MVC.Models;
namespace Demo_MVC.Controllers
{
    public class TinhDiemController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(TinhDiem td)
        {
            double diemso = 0.1*td.DiemC + 0.3*td.DiemB + 0.6*td.DiemA;
            ViewBag.Message = "Điểm của bạn là: " + diemso;
            return View();
        }
    }
}