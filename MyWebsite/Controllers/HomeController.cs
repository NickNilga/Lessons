using Microsoft.AspNetCore.Mvc;
using MyWebsite.Models;

namespace MyWebsite.Controllers
{
	public class HomeController : Controller
	{
		// GET
		public IActionResult Index(string name)
		{
			GreetingsModel model = new GreetingsModel(name);
			
			return View(model);
		}
	}
}