using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Demo_MVC.Models;
 namespace Demo_MVC.Controllers
 {
    public class BMIController : Controller
    {
        [HttpGet]
        public IActionResult Index() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(BMI all)
        {
            double chiso = all.weight/(all.height*all.height);
            if (chiso < 18.5)
            {
                ViewBag.Message = "BMI của bạn là "+ Math.Round(chiso,2) + " Gầy";
                return View();
            }
            else if(chiso >= 18.5 && chiso <= 24.9)
            {
                ViewBag.Message = "BMI của bạn là "+ Math.Round(chiso,2) + " Bình thường";
                return View();
            }
            else if(chiso >= 25 && chiso <= 29.9)
            {
                ViewBag.Message = "BMI của bạn là "+ Math.Round(chiso,2) + " Thừa cân";
                return View();
            }
            else 
            {
                ViewBag.Message = "BMI của bạn là "+ Math.Round(chiso,2) + " Béo phì";
                return View();
            }
        }
    }
 }