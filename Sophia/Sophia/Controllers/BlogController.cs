using Microsoft.AspNetCore.Mvc;

namespace Sophia.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
