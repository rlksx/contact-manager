using Microsoft.AspNetCore.Mvc;

namespace contact_manager.Controllers;

public class ContactController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}