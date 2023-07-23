using Homish.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Homish.PresentetionLayer.ViewComponents.DefaultAbout
{
    public class _TeamPartial:ViewComponent
    {
        private readonly ITeamService _teamService;

        public _TeamPartial(ITeamService teamService)
        {
            _teamService = teamService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _teamService.TGetAll();
            return View(values);
        }
    }
}
