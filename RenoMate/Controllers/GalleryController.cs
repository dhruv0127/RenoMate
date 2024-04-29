using Microsoft.AspNetCore.Mvc;

namespace RenoMate.Controllers
{
    public class GalleryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
