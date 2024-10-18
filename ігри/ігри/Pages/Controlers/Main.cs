using Microsoft.AspNetCore.Mvc;

namespace ігри.Pages.Controlers
{
    public class Main : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
