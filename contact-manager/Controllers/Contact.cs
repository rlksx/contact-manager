using Microsoft.AspNetCore.Mvc;

namespace contact_manager.Controllers;

public class Contact : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}