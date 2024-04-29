using Microsoft.AspNetCore.Mvc;

namespace RenoMate.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Signup()
        {
            return View();
        }
    }
}
