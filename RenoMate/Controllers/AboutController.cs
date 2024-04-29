using Microsoft.AspNetCore.Mvc;

namespace RenoMate.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
