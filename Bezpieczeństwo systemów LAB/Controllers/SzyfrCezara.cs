using Microsoft.AspNetCore.Mvc;

namespace Bezpieczeństwo_systemów_LAB.Controllers;

public class SzyfrCezara : Controller
{
    public IActionResult Form()
    {
        return View();
    }
}