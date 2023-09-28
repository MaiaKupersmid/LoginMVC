using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Login.Models;

public class Account : Controller
{
    private readonly ILogger<Account> _logger;

    public Account(ILogger<Account> logger)
    {
        _logger = logger;
    }

    public IActionResult Registro()
    {
        return View();
    }

    public IActionResult Login()
    {
        return View();
    }

    public IActionResult PostLogin()
    {
        return View();
    }

    public IActionResult Olvide()
    {
        return View();
    }

    [HttpPost]
    public IActionResult RegistarUsuario(string UserName, string Contraseña, string Nombre, string Mail, string Telefono)
    {
        BD.AgregarUsuario(new Usuario (UserName, Contraseña, Nombre, Mail, Telefono));
        return RedirectToAction("PostLogin", "Account");
    }
}