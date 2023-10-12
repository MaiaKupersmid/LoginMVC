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
    
    public IActionResult VerificarLogin(string UserName, string Contraseña)
    {   
        
        bool okey = BD.Verificar(UserName, Contraseña);
        if(okey){    
            return RedirectToAction("PostLogin", "Account", new {username=UserName});
        } else{
            return RedirectToAction("Login", "Account");
        }
    }

    public IActionResult PostLogin(string username)
    {
        
        ViewBag.user =BD.TraerUsuario(username);
        return View();
    }

    public IActionResult Olvide()
    {
        return View();
    }

    [HttpPost]
    public IActionResult PostOlvide(string UserName)
    {
        string user = BD.TraerPorTel(UserName);
        return RedirectToAction("PostLogin", "Account", new {username=user});
    }

    [HttpPost]
    public IActionResult RegistarUsuario(string UserName, string Contraseña, string Nombre, string Mail, string Telefono)
    {
        Usuario user = new Usuario (UserName, Contraseña, Nombre, Mail, Telefono);
        BD.AgregarUsuario(user);
        return RedirectToAction("PostLogin", "Account", new {username=UserName});
    }
}
