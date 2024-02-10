using Microsoft.AspNetCore.Mvc;

namespace MyFirstASPNetBlankProjectFun.wwwroot.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult FanMail()
        {
            return View();
        }
    }
}
