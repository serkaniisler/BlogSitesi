using Microsoft.AspNetCore.Mvc;

namespace BlogSite.Controllers
{
    public class ArticlesController : Controller
    {

        public IActionResult Main()
        {
            return View();
        }

        public IActionResult Deneme()
        {
            return View();
        }
        public IActionResult sekoKasar()
        {
            return View();
        }
    }
}
