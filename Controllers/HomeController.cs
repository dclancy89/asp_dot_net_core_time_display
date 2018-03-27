using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Time_Display
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
    }
}