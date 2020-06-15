using Microsoft.AspNetCore.Mvc;

namespace MyWebsite.Controllers
{
    public class MathController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Factorial()
        {
            return View();
        }
        
    }
}