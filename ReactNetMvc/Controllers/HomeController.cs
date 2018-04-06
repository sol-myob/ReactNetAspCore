using Microsoft.AspNetCore.Mvc;

namespace ReactNetMvc.Controllers
{
    public class HomeController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return
            View();
        }
    }
}