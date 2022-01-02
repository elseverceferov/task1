using Microsoft.AspNetCore.Mvc;

namespace Task22_12_2021.Areas.admin.Controllers
{
    [Area("admin")]
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
    }
}
