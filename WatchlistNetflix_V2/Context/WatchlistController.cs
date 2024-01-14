using Microsoft.AspNetCore.Mvc;

namespace WatchlistNetflix_V2.Context
{
    public class WatchlistController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
