using Microsoft.AspNetCore.Mvc;

namespace MyWebsite
{
	public class HomeController : Controller
	{
		// GET
		public IActionResult Index()
		{
			return View();
		}
	}
}