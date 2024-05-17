using HelpDeskMVC1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HelpDeskMVC1.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult authenticationLogin()
		{
			return View();
		}
		public IActionResult Index()
		{
			// tut pishem http request dlya proverki parolya
			return View();
		}

		public IActionResult uiButtons()
		{
			return View();
		}
		public IActionResult uiForms()
		{
			return View();
		}
		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
