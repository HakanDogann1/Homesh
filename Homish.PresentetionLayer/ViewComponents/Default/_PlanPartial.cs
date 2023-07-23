using Homish.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Homish.PresentetionLayer.ViewComponents.Default
{
    public class _PlanPartial:ViewComponent
    {
        private readonly IPlanService _planService;

        public _PlanPartial(IPlanService planService)
        {
            _planService = planService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _planService.TGetAll();
            return View(values);
        }
    }
}
