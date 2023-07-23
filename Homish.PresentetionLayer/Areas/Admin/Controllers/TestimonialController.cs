using Homish.BusinessLayer.Abstract;
using Homish.DataAccessLayer.Abstract;
using Homish.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Homish.PresentetionLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    public class TestimonialController : Controller
    {
       private readonly ITestimonialService _testimonialService;

        public TestimonialController(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }

        public IActionResult Index()
        {
            var values = _testimonialService.TGetAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddTestimonial()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddTestimonial(Testimonial testimonial)
        {
            _testimonialService.TAdd(testimonial);
            return RedirectToAction("Index","Testimonial");
        }
        public IActionResult DeleteTestimonial(string id)
        {
            _testimonialService.TDelete(id);
            return RedirectToAction("Index", "Testimonial");
        }
        [HttpGet]
        public IActionResult UpdateTestimonial(string id)
        {
            var value = _testimonialService.TGetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateTestimonial(Testimonial testimonial)
        {
            _testimonialService.TUpdate(testimonial);
            return RedirectToAction("Index", "Testimonial");
        }
    }
}
