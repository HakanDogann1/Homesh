using Homish.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Homish.PresentetionLayer.ViewComponents.DefaultAbout
{
    public class _ChooseUsPartial:ViewComponent
    {
        private readonly IChooseUsService _chooseUsService;

        public _ChooseUsPartial(IChooseUsService chooseUsService)
        {
            _chooseUsService = chooseUsService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _chooseUsService.TGetAll();
            return View(values);
        }
    }
}
