using Microsoft.AspNetCore.Mvc;
namespace DemoNNS.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string FullName, string Address)
        {
            ViewBag. thongbao = "Xin Chao" + FullName + "_" + Address;
            return View();
        }
    }
}