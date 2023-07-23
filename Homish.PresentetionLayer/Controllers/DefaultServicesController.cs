using Homish.BusinessLayer.Abstract;
using Homish.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Homish.PresentetionLayer.Controllers
{
    public class DefaultServicesController : Controller
    {
  
        public IActionResult Index()
        {
            return View();
        }
       
      
    }
}
