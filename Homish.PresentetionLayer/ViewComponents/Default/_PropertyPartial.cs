using Homish.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Homish.PresentetionLayer.ViewComponents.Default
{
    public class _PropertyPartial:ViewComponent
    {
        private readonly IPropertyService _propertyService;

        public _PropertyPartial(IPropertyService propertyService)
        {
            _propertyService = propertyService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _propertyService.TGetAll();
            return View(values);
        }
    }
}
