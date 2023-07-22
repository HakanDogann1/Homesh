using Homesh.BusinessLayer.Abstract;
using Homesh.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Homish.PresentetionLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TeamController : Controller
    {
        private readonly ITeamService _teamService;

        public TeamController(ITeamService teamService)
        {
            _teamService = teamService;
        }

        public IActionResult Index()
        {
            var values = _teamService.TGetAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddTeam()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddTeam(Team team)
        {
            _teamService.TAdd(team);
            return RedirectToAction("Index", "Team");
        }
        public IActionResult DeleteTeam(string id)
        {
            _teamService.TDelete(id);
            return RedirectToAction("Index", "Team");
        }
        [HttpGet]
        public IActionResult UpdateTeam(string id)
        {
            var value = _teamService.TGetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateTeam(Team team)
        {
            _teamService.TUpdate(team);
            return RedirectToAction("Index", "Team");
        }
    }
}
