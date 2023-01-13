using ApartDeneme.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApartDeneme.Controllers
{
	public class IletisimController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
		[HttpGet]
		public IActionResult iletişim()
		{
			return View();
		}
		[HttpPost]
		public IActionResult iletişim(iletisim ilet)
		{
			if (ModelState.IsValid)
			{
				var messages=ModelState.ToList();
				return View(ilet);
			}
			return View();
		}
	}
}
