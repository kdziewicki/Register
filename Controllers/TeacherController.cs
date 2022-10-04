using Microsoft.AspNetCore.Mvc;
using Register.Models;
using System.Diagnostics;

namespace Register.Controllers
{
    public class TeacherController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public TeacherController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("Schedule")]
        public IActionResult Schedule()
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