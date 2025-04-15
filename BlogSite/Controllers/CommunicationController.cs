using Microsoft.AspNetCore.Mvc;

namespace BlogSite.Controllers
{
    public class CommunicationController : Controller
    {

        public IActionResult Contact()
        {
            return View();
        }
    }
}
