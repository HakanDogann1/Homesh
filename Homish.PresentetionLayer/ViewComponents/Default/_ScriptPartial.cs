using Microsoft.AspNetCore.Mvc;

namespace Homish.PresentetionLayer.ViewComponents.Default
{
    public class _ScriptPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
