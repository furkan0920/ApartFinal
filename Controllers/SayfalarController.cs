using Microsoft.AspNetCore.Mvc;

namespace ApartDeneme.Controllers
{
	public class SayfalarController : Controller
	{
		public IActionResult Hakkimizda()
		{
			return View();
		}
		public IActionResult Haberler()
		{
			return View();
		}
		public IActionResult Iletisim()
		{
			return View();
		}
		public IActionResult Destek()
		{
			return View();
		}
	}
}
