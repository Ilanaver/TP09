using Microsoft.AspNetCore.Mvc;

namespace tp9.Controllers;

public class HomeController : Controller
{
    public IActionResult Login()
    {
        return View();
    }
    public IActionResult Bienvenida()
    {
        return View();
    }
    public IActionResult Registro()
    {
        return View();
    }
    public IActionResult Olvide()
    {
        return View();
    }
}