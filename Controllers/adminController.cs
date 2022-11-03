using Microsoft.AspNetCore.Mvc;

namespace ATRSwebApi1.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
