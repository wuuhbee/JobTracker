using Microsoft.AspNetCore.Mvc;

namespace JobTracker.Controllers
{
    public class CriticsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
