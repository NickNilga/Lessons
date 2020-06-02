using Microsoft.AspNetCore.Mvc;

namespace MyWebsite.Controllers
{
	public class HomeController : Controller
	{
		// GET
		public IActionResult Index()
		{
			//return Content("Hello world!");
			return View();
		}
	}
}