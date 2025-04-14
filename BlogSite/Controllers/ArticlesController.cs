using Microsoft.AspNetCore.Mvc;

namespace BlogSite.Controllers
{
    public class ArticlesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
