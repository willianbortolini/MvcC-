using Microsoft.AspNetCore.Mvc;

namespace salesWebMvc4.Controllers
{
    public class SalesRecordsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SimpleSearch()
        {
            return View();
        }

        public IActionResult GroupingSearch()
        {
            return View();
        }
    }
}
