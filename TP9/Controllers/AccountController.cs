using Microsoft.AspNetCore.Mvc;
using TP9.Models;
namespace TP9.Controllers;

public class AccountController : Controller
{
    [HttpPost] public IActionResult Login(string user, string pass)
    {
        string contra;
        contra = BD.GetPassByUser(user);
        if(contra==pass){
            return RedirectToAction("Bienvenida","Home");
        }else
        {
            return RedirectToAction("Login","Home");
        }
    }
    public IActionResult Registro(Usuario username)
    {
        BD.Registro(username);
        return RedirectToAction("Login","Home");
    }
    public IActionResult CambiarContraseña(string us, string nuevaContra)
    {
        BD.CambiarContraseña(us,nuevaContra);
        return RedirectToAction("Bienvenida","Home");
    }
}