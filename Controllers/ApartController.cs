using ApartDeneme.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Security.Claims;

namespace ApartDeneme.Controllers
{
	public class ApartController : Controller
	{
		Context dbs = new Context();
		public ActionResult Anasayfa()
		{
			return View();
		}

		public IActionResult ApartEkle()
		{
			return View();

		}
		[HttpPost]
		public IActionResult ApartEkle(ApartEkle ekle)
		{
			dbs.aparts.Add(ekle);
			dbs.SaveChanges();
			return RedirectToAction("Anasayfa");

		}
		public IActionResult Kayit()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Kayit(KullaniciKayit kayit)
		{
			dbs.kullanicikayit.Add(kayit);
			dbs.SaveChanges();
			return RedirectToAction("Giris");
		}
		
		[HttpGet]
		public IActionResult Giris()
		{
			return View();
		}
		//[Authorize]
		//public async Task <IActionResult> Giris(Giris g)
		//{
		//	var bilgiler = dbs.girises.FirstOrDefault(x => x.kullaniciAdi == g.kullaniciAdi && x.sifre == g.sifre);
		//	if (bilgiler!=null)
		//	{
		//		var claims = new List<Claim>
		//		{
		//			new Claim(ClaimTypes.Name,g.kullaniciAdi)
		//		};
		//		var useridentity=new ClaimsIdentity(claims,"Giris");
		//		ClaimsPrincipal principal= new ClaimsPrincipal(useridentity);
		//		await HttpContext.SignInAsync(principal);
		//		return RedirectToAction("Apartlar");
		//	}

		//	return View();

		//}
		public IActionResult Apartlar()
		{
			var degerler = dbs.aparts.ToList();

			return View(degerler);
		}
		public IActionResult ApartSil(int id)
		{
			var del = dbs.aparts.Find(id);
			dbs.aparts.Remove(del);
			dbs.SaveChanges();
			return RedirectToAction("Apartlar");
		}
		public IActionResult ApartBilgileriGetir(int id)
		{
			var apartbilgi = dbs.aparts.Find(id);
			return View("ApartBilgileriGetir",apartbilgi);


		}


		public IActionResult Guncelle(ApartEkle duzenle)
		{
			var gnc = dbs.aparts.Find(duzenle.id);
			gnc.Adres = duzenle.Adres;
			dbs.SaveChanges();
			return RedirectToAction("ApartEkle");
		}
		public IActionResult Yıllık()
		{
			var degerler = dbs.aparts.ToList();

			return View(degerler);
		}
	}
}
