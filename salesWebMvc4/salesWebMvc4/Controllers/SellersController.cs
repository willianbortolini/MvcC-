using Microsoft.AspNetCore.Mvc;

namespace salesWebMvc4.Controllers
{
    public class SellersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
