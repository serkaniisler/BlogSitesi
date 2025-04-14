using Microsoft.AspNetCore.Mvc;

namespace BlogSite.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
