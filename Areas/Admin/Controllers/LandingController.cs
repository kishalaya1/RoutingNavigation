using Microsoft.AspNetCore.Mvc;

namespace RoutingNavigation.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LandingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
