using Homesh.BusinessLayer.Abstract;
using Homesh.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Homish.PresentetionLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    public class HeaderController : Controller
    {
        private readonly IHeaderService _headerService;

        public HeaderController(IHeaderService headerService)
        {
            _headerService = headerService;
        }

        public IActionResult Index()
        {
            var values = _headerService.TGetAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddHeader()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddHeader(Header header)
        {
            _headerService.TAdd(header);
            return RedirectToAction("Index","Header");

        }
        public IActionResult DeleteHeader(string id)
        {
            _headerService.TDelete(id);
            return RedirectToAction("Index", "Header");
        }

        [HttpGet]
        public IActionResult UpdateHeader(string id)
        {
            var value = _headerService.TGetById(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateHeader(Header header)
        {
            _headerService.TUpdate(header);
            return RedirectToAction("Index", "Header");
        }
    }
}
