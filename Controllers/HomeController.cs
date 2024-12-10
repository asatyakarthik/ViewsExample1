using Microsoft.AspNetCore.Mvc;

namespace ViewsExample1.Controllers
{
    public class HomeController : Controller
    {
        [Route("Home")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
