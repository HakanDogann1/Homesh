using Microsoft.AspNetCore.Mvc;

namespace Homish.PresentetionLayer.Areas.Member.Controllers
{
    [Area("Member")]
    public class MemberLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
