using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SimpleWeb.Controllers;

[Authorize(AuthenticationSchemes = "Cookie")]
public class CartController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}

