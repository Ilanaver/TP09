using Microsoft.AspNetCore.Mvc;

namespace TP9.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Registro()
    {
        return View();
    }
    public IActionResult Bienvenida(){
        return View();
    }
    public IActionResult Login(){
        return View();
    }
    public IActionResult Olvide(){
        return View();
    }
}
