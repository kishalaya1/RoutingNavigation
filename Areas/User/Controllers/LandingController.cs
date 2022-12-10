using Microsoft.AspNetCore.Mvc;
using RoutingNavigation.Models;

namespace RoutingNavigation.Areas.User.Controllers
{
    [Area("User")]
    public class LandingController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            LoginViewModel user = new LoginViewModel();
            
            return View(user);
        }
        public ViewResult Profile()
        {
            return View();
        }
    }
}
