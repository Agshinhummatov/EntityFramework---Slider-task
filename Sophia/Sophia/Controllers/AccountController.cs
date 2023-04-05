using Microsoft.AspNetCore.Mvc;

namespace Sophia.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
