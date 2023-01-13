using Microsoft.EntityFrameworkCore;

namespace ApartDeneme.Models
{
	public class Context:DbContext
	{ //TODO Veri tabanı bağlantısı oluşturuldu manager consoleden migration komutları calitrilip migration olusturuldu
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("server=DESKTOP-4ALBNKR; database=apartdeneme1; integrated security=true; TrustServerCertificate = True;");
		}
		public DbSet<ApartEkle> aparts { get; set; }

		public DbSet<Giris> girises { get; set; }
		public DbSet<KullaniciKayit> kullanicikayit { get; set; }
	}
}
