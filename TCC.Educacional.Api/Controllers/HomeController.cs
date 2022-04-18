using Microsoft.AspNetCore.Mvc;

namespace TCC.Educacional.Api.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
