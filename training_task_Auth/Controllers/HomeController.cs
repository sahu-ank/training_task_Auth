using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using training_task_Auth.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;

namespace training_task_Auth.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public HomeController(ILogger<HomeController> logger, IHttpContextAccessor httpContextAccessor)
        {
            _logger = logger;
            _httpContextAccessor = httpContextAccessor;
        }

        private void SetSessionDataInViewBag()
        {
            var username = _httpContextAccessor.HttpContext.Session.GetString("Username");
            var role = _httpContextAccessor.HttpContext.Session.GetString("Role");
            ViewBag.Username = username;
            ViewBag.Role = role;
        }
        public IActionResult Index()
        {
            SetSessionDataInViewBag();
            return View();
        }

        public IActionResult Privacy()
        {
            SetSessionDataInViewBag();
            return View();
        }

        public IActionResult EmpList()
        {
            SetSessionDataInViewBag();
            return View();
        }

        public IActionResult Create()
        {
            SetSessionDataInViewBag();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
