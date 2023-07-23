using Homish.BusinessLayer.Abstract;
using Homish.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Homish.PresentetionLayer.Controllers
{
    public class DefaultContactController : Controller
    {
        private readonly IContactService _contactService;

        public DefaultContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult AddContact()
        {
            return PartialView();
        }
        [HttpPost]
        public IActionResult AddContact(Contact contact)
        {
            _contactService.TAdd(contact);
            return RedirectToAction("Index", "DefaultContact");
        }
    }
}
