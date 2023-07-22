using Microsoft.AspNetCore.Mvc;

namespace Homish.PresentetionLayer.ViewComponents.Default
{
    public class _PlanPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
