using Homish.BusinessLayer.Abstract;
using Homish.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Homish.PresentetionLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    public class ServiceController : Controller
    {
        private readonly IServiceService _serviceService;

        public ServiceController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        public IActionResult Index()
        {
            var values = _serviceService.TGetAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddService()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddService(Service service)
        {
            _serviceService.TAdd(service);
            return RedirectToAction("Index","Service");
        }
        public IActionResult DeleteService(string id)
        {
            _serviceService.TDelete(id);
            return RedirectToAction("Index", "Service");
        }
        [HttpGet]
        public IActionResult UpdateService(string id)
        {
            var value = _serviceService.TGetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateService(Service service)
        {
            _serviceService.TUpdate(service);
            return RedirectToAction("Index", "Service");
        }
    }
}
