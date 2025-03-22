using Microsoft.AspNetCore.Mvc;

namespace Lesson9.Lab1.Areas.Admins.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
