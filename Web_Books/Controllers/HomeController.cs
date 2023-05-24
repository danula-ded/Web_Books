using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Web_Books.Models;

namespace Web_Books.Controllers
{
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

        public IActionResult Books()
        {
            return View();
        }

        public IActionResult Book1()
        {
            return View();
        }

        public IActionResult Book2()
        {
            return View();
        }

        public IActionResult Book3()
        {
            return View();
        }

        public IActionResult Book4()
        {
            return View();
        }

        public IActionResult Book5()
        {
            return View();
        }

        public IActionResult Book6()
        {
            return View();
        }

        public IActionResult Book7()
        {
            return View();
        }

        public IActionResult Book8()
        {
            return View();
        }

        public IActionResult Book9()
        {
            return View();
        }

        public IActionResult Book10()
        {
            return View();
        }

        public IActionResult Book11()
        {
            return View();
        }

        public IActionResult Book12()
        {
            return View();
        }

        public IActionResult Book13()
        {
            return View();
        }

        public IActionResult Book14()
        {
            return View();
        }

        public IActionResult Book15()
        {
            return View();
        }

        public IActionResult Book16()
        {
            return View();
        }

        public IActionResult Book17()
        {
            return View();
        }

        public IActionResult Book18()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}