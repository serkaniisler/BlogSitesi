using Microsoft.AspNetCore.Mvc;

namespace BlogSite
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
