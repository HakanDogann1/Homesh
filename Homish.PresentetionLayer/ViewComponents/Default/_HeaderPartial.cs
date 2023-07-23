using Homish.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Homish.PresentetionLayer.ViewComponents.Default
{
    public class _HeaderPartial:ViewComponent
    {
        private readonly IHeaderService _headerService;

        public _HeaderPartial(IHeaderService headerService)
        {
            _headerService = headerService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _headerService.TGetAll();
            return View(values);
        }
    }
}
