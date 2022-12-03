using Microsoft.AspNetCore.Mvc;

namespace RoutingNavigation.Areas.User.Controllers
{
    [Area("User")]
    public class LandingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
