using Microsoft.AspNetCore.Mvc;

namespace Homish.PresentetionLayer.ViewComponents.Default
{
    public class _FooterPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
