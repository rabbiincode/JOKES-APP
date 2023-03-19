using Microsoft.AspNetCore.Mvc;

namespace JOKES.Controllers
{
    public class ImagesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
