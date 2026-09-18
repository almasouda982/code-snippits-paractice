using Microsoft.AspNetCore.Mvc;

namespace WebAppInClass.Controllers
{
    public class AccountsController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
