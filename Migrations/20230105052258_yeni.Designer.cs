// <auto-generated />
using ApartDeneme.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ApartDeneme.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230105052258_yeni")]
    partial class yeni
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ApartDeneme.Models.ApartEkle", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Adres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("fiyat")
                        .HasColumnType("int");

                    b.Property<string>("fotograf")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("il")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ilce")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("metreKare")
                        .HasColumnType("float");

                    b.Property<int>("odasayısı")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("aparts");
                });

            modelBuilder.Entity("ApartDeneme.Models.Giris", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("kullaniciAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sifre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("girises");
                });

            modelBuilder.Entity("ApartDeneme.Models.KullaniciKayit", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("cinsiyet")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("isim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("kullaniciAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("parola")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("soyisim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("kullanicikayit");
                });
#pragma warning restore 612, 618
        }
    }
}
