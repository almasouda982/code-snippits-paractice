using Microsoft.AspNetCore.Mvc;

namespace WebAppInClass.Controllers
{
    public class AccountsController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        

        [HttpPost]
        public IActionResult LoginConfirm(string email , string password)
        {
            if(email=="m@gmail.com" && password=="12345")
            {
                return RedirectToAction("Index", "Home");
            }

            return View("Login");
        }

    }
}
