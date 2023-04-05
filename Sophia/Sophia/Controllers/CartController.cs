using Microsoft.AspNetCore.Mvc;

namespace Sophia.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
