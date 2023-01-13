using System.ComponentModel.DataAnnotations;

namespace ApartDeneme.Models
{
	public class ApartEkle
	{
		//TODO Apart bilgilerini kayıtı için model olusturulup gelen degerleri ApartControllerde islmeleri saglandı
		[Key]
		public int id { get; set; }
		public string il { get; set; }
		public string ilce { get; set; }
		public string Adres { get; set; }
		public int odasayısı { get; set; }
		public double metreKare { get; set; }
		public string fotograf { get; set; }
		public int fiyat { get; set; }


	}
}
