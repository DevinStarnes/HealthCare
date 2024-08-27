using Microsoft.AspNetCore.Mvc;

namespace HealthCare.Controllers
{
    public class BodyweightController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Summary()
        {
            return View();
        }
    }
}
