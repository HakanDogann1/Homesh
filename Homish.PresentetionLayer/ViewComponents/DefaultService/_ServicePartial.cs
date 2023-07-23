using Homish.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Homish.PresentetionLayer.ViewComponents.DefaultService
{
    public class _ServicePartial:ViewComponent
    {
        private readonly IServiceService _serviceService;

        public _ServicePartial(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }
        public IViewComponentResult Invoke()
        {
            var values = _serviceService.TGetAll();
            return View(values);
        }
    }
}
