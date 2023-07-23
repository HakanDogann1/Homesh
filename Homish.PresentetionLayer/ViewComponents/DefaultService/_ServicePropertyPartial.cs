using Homish.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Homish.PresentetionLayer.ViewComponents.DefaultService
{
    public class _ServicePropertyPartial:ViewComponent
    {
        private readonly IServicePropertyService _servicePropertyService;

        public _ServicePropertyPartial(IServicePropertyService servicePropertyService)
        {
            _servicePropertyService = servicePropertyService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _servicePropertyService.TGetAll();
            return View(values);
        }
    }
}
