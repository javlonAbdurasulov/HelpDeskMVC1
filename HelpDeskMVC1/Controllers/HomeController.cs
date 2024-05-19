using HelpDeskMVC1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Text.Json;

namespace HelpDeskMVC1.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		string _url = "https://localhost:7061/api/Letter/CreateLetter";
		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult authenticationLogin()
		{
			return View();
		}
        
		public IActionResult Index( User user)
		{
			// tut pishem http request dlya proverki parolya

			user.Id = 1;
			user.Roles = "user";

			return View(user);
		}

		public IActionResult uiButtons(User user)
		{
			return View(user);
		}
		public IActionResult uiForms(User user)
		{

			return View(user);
		}
		
        public IActionResult CreateLetter(LetterCreateDTO letter)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var json = JsonSerializer.Serialize(letter);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = client.PostAsync(_url, content);

            if (response.Result.IsSuccessStatusCode)
            {
                User user = new User();
                user.Id = letter.UserId;
                user.Roles = "user";
                return View("~/Views/Home/uiForms.cshtml", user);
            }
            else
            {
                throw new Exception($"Request failed with status code {response.Result.StatusCode}");
            }

        }

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
