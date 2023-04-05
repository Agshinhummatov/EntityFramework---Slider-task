using Microsoft.AspNetCore.Mvc;

namespace Sophia.Controllers
{
    public class WishtlistController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
