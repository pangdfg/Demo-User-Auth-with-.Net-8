using Microsoft.AspNetCore.Mvc;

namespace DemoUserAuth.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
