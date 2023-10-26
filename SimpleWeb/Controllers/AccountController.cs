using Microsoft.AspNetCore.Mvc;
using SimpleWeb.Models;

namespace SimpleWeb.Controllers;

public class AccountController : Controller
{
    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Login(LoginViewModel model, [FromQuery] string returnUrl = null)
    {
        return View();
    }
}