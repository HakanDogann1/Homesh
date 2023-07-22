using Microsoft.AspNetCore.Mvc;

namespace Homish.PresentetionLayer.ViewComponents.Default
{
    public class _DefaultServicePartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
