using Microsoft.AspNetCore.Mvc;

namespace RenoMate.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
