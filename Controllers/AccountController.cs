using Microsoft.AspNetCore.Mvc;

using RoutingNavigation.Models;
using System.Text.Json;

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
                    return RedirectToAction("Index", "Landing", new { Area = "Admin" });
                }
                else if (model.UserName == "user@gmail.com" && model.Password == "12345678")
                {
                    
                    return RedirectToAction("Index", "Landing", new { Area = "User" });
                }
                else
                {
                    return View();
                }
            }
            return View();
        }

        [HttpGet]
        public ViewResult LogOut()
        {
            return View();
        }
    }
}
