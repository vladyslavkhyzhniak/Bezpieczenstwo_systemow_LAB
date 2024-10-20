using Bezpieczeństwo_systemów_LAB.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bezpieczeństwo_systemów_LAB.Controllers;

public class SzyfrCezaraController : Controller
{
    public IActionResult Form()
    {
        return View();
    }

    public IActionResult Result(SzyfrCezara model)
    {
        if (!model.IsValid())
        {
            return View("SzyfrCezaraError");
        }
        return View(model);
    }
}