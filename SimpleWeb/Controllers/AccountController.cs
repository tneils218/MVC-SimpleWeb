using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using SimpleWeb.Models;
using System.Security.Claims;

namespace SimpleWeb.Controllers;

public class AccountController : Controller
{
    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Login(LoginViewModel model, [FromQuery] string returnUrl = null)
    {
        if(ModelState.IsValid)
        {
            if(model.Email == "admin@page.com" && model.Password == "123456")
            {
                var redirectUrl = string.IsNullOrEmpty(returnUrl) ? "/" : returnUrl;
                var claims = new Claim[]
                {
                    new Claim(ClaimTypes.Email, model.Email),
                    new Claim("name", "Adminstrator")
                };
                ClaimsIdentity identity = new ClaimsIdentity(claims, "Cookie");
                ClaimsPrincipal principal = new ClaimsPrincipal(identity);
                await HttpContext.SignInAsync(principal, new AuthenticationProperties
                {
                    IsPersistent = model.RememberMe
                });
                return Redirect(redirectUrl);
            }
            ViewData["Error"] = "User hoặc mật khẩu không đúng";
        }
        return View(model);
    }
}