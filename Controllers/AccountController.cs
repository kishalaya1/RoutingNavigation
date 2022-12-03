using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.VisualBasic.Syntax;
using RoutingNavigation.Models;

namespace RoutingNavigation.Controllers
{
    public class AccountController : Controller
    {
        public ViewResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.UserName == "admin@gmail.com" && model.Password == "12345678")
                {
                    return RedirectToAction("Index", "Home", new { Area = "Admin" });
                }
                else if(model.UserName == "user@gmail.com" && model.Password == "12345678")
                {
                    return RedirectToAction("Index", "Home", new { Area = "User" });
                }
                else
                {
                    return View();
                }
            }
            return View();
        }
    }
}
