using Microsoft.AspNetCore.Mvc;
using RoutingNavigation.Models;

namespace RoutingNavigation.Controllers
{
    public class AccountController : Controller
    {
        public ViewResult Login()
        {
            return View("~/Views/Account/Login.cshtml");
        }
        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index","Home");
            }
            return View();
        }
    }
}
