using Microsoft.AspNetCore.Mvc;

namespace Homish.PresentetionLayer.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
