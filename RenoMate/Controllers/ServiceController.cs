using Microsoft.AspNetCore.Mvc;

namespace RenoMate.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
