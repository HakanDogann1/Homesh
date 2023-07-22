using Microsoft.AspNetCore.Mvc;

namespace Homish.PresentetionLayer.ViewComponents.Default
{
    public class _TestimonialPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
