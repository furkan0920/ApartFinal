using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace ApartDeneme.Models
{
	public class KullaniciKayit
	{
		//TODO Kayit.cshtml dosyası için model olusturulup gelen degerleri ApartControllerde islmeleri saglandı
		[Key]
		public int id { get; set; }
		public string isim { get; set; }
		public string soyisim { get; set; }
		public string cinsiyet { get; set; }
		public string kullaniciAdi { get; set; }
		public string parola { get; set; }

	}
}
