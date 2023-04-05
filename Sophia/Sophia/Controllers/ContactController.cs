using Microsoft.AspNetCore.Mvc;

namespace Sophia.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
