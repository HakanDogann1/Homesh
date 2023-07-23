using Homish.BusinessLayer.Abstract;
using Homish.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Homish.PresentetionLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    public class PlanController : Controller
    {
        private readonly IPlanService _planService;

        public PlanController(IPlanService planService)
        {
            _planService = planService;
        }

        public IActionResult Index()
        {
            var values = _planService.TGetAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddPlan()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddPlan(Plan plan)
        {
            _planService.TAdd(plan);
            return RedirectToAction("Index","Plan");
        }
        public IActionResult DeletePlan(string id)
        {
            _planService.TDelete(id);
            return RedirectToAction("Index", "Plan");
        }
        [HttpGet]
        public IActionResult UpdatePlan(string id)
        {
            var value = _planService.TGetById(id);
            return RedirectToAction("Index", "Plan");
        }
        [HttpPost]
        public IActionResult UpdatePlan(Plan plan)
        {
            _planService.TUpdate(plan);
            return RedirectToAction("Index", "Plan");
        }
    }
}
