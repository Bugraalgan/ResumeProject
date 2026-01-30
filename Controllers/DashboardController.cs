using Microsoft.AspNetCore.Mvc;

namespace ResumeProjectDemoNight.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
