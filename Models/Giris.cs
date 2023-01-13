using System.ComponentModel.DataAnnotations;

namespace ApartDeneme.Models
{
	public class Giris
	{
		//TODO  Giris.cshtml bilgileri için model olusturulup gelen degerleri ApartControllerde islmeleri saglandı
		[Key]
		public int id { get; set; }
		public string kullaniciAdi { get; set; }
		public string sifre { get; set; }
	}
}
