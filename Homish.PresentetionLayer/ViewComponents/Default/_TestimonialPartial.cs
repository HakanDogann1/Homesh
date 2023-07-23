using Homish.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Homish.PresentetionLayer.ViewComponents.Default
{
    public class _TestimonialPartial:ViewComponent
    {
        private readonly ITestimonialService _testimonialService;

        public _TestimonialPartial(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _testimonialService.TGetAll();
            return View(values);
        }
    }
}
