using Microsoft.AspNetCore.Mvc;

namespace Bezpieczeństwo_systemów_LAB.Controllers;

public class SzyfrPolibiuszaController : Controller
{
    
    public IActionResult Form()
    {
        return View();
    }
}