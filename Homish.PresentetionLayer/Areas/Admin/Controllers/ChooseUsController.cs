using AutoMapper;
using Homesh.BusinessLayer.Abstract;
using Homesh.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using System.Linq;

namespace Homish.PresentetionLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    public class ChooseUsController : Controller
    {
        private readonly IChooseUsService _chooseUsService;
        private readonly IMapper _mapper;

        public ChooseUsController(IChooseUsService chooseUsService)
        {
            _chooseUsService = chooseUsService;
        }

        public IActionResult Index()
        {
             var values = _chooseUsService.TGetAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddChooseUs()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddChooseUs(ChooseUs chooseUs)
        {
            _chooseUsService.TAdd(chooseUs);
            return RedirectToAction("Index", "ChooseUs");
        }
        public IActionResult DeleteChooseUs(string id)
        {
            _chooseUsService.TDelete(id);
            return RedirectToAction("Index", "ChooseUs");
        }
        [HttpGet]
        public IActionResult UpdateChooseUs(string id)
        {
            var value = _chooseUsService.TGetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateChooseUs(ChooseUs chooseUs)
        {
            _chooseUsService.TUpdate(chooseUs);
            return RedirectToAction("Index", "ChooseUs");
        }
    }
}
