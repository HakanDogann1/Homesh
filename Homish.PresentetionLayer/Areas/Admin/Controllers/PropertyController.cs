using Homesh.BusinessLayer.Abstract;
using Homesh.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Homish.PresentetionLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PropertyController : Controller
    {
        private readonly IPropertyService _propertyService;

        public PropertyController(IPropertyService propertyService)
        {
            _propertyService = propertyService;
        }

        public IActionResult Index()
        {
            var values = _propertyService.TGetAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddProperty()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddProperty(Property property)
        {
            _propertyService.TAdd(property);
            return RedirectToAction("Index","Property");
        }
        public IActionResult DeleteProperty(string id)
        {
            _propertyService.TDelete(id);
            return RedirectToAction("Index", "Property");
        }
        [HttpGet]
        public IActionResult UpdateProperty(string id)
        {
            var value = _propertyService.TGetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateProperty(Property property)
        {
            _propertyService.TUpdate(property);
            return RedirectToAction("Index", "Property");
        }
    }
}
