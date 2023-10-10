using Microsoft.AspNetCore.Mvc;

namespace TP9.Controllers;

public class AccountController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost] public IActionResult Login(Usuario user)
    {
        Usuario existente = BD.Login(user);
        return View("Login");
    }
}