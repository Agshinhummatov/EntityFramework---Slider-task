using Microsoft.AspNetCore.Mvc;

namespace Sophia.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
