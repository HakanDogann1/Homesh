using Homesh.BusinessLayer.Abstract;
using Homesh.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Homish.PresentetionLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ServicePropertyController : Controller
    {
        private readonly IServicePropertyService _servicePropertyService;

        public ServicePropertyController(IServicePropertyService servicePropertyService)
        {
            _servicePropertyService = servicePropertyService;
        }

        public IActionResult Index()
        {
            var values = _servicePropertyService.TGetAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddServiceProperty()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddServiceProperty(ServiceProperty serviceProperty)
        {
            _servicePropertyService.TAdd(serviceProperty);
            return RedirectToAction("Index","ServiceProperty");
        }
        public IActionResult DeleteServiceProperty(string id)
        {
            _servicePropertyService.TDelete(id);
            return RedirectToAction("Index", "ServiceProperty");
        }
        [HttpGet]
        public IActionResult UpdateServiceProperty(string id)
        {
            var value = _servicePropertyService.TGetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateServiceProperty(ServiceProperty serviceProperty)
        {
            _servicePropertyService.TUpdate(serviceProperty);
            return RedirectToAction("Index", "ServiceProperty");
        }
    }
}
