using Microsoft.AspNetCore.Mvc;

namespace Sophia.Controllers
{
    public class CheckoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
