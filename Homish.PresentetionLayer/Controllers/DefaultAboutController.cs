using Microsoft.AspNetCore.Mvc;

namespace Homish.PresentetionLayer.Controllers
{
    public class DefaultAboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
