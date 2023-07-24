using Microsoft.AspNetCore.Mvc;
using DemoNNS.Models;

namespace DemoNNS.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Person ps)
        {
            string message = ps.FullName + "_" + ps.ID;
            ViewBag.thongbao = message;
            return View();
        }
    }
}