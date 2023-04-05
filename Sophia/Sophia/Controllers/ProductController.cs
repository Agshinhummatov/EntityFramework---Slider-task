using Microsoft.AspNetCore.Mvc;

namespace Sophia.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
