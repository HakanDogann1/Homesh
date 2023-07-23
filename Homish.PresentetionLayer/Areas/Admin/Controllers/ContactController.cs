using Homish.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Homish.PresentetionLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IActionResult Index()
        {
            var values = _contactService.TGetAll();
            return View(values);
        }
        public IActionResult DeleteContact(string id)
        {
            _contactService.TDelete(id);
            return RedirectToAction("Index","Contact");
        }
    }
}
