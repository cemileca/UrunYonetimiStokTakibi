using Entities;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

using Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
namespace DAL
{
    public class StokYonetimiDbContext : DbContext
    {

        public StokYonetimiDbContext() : base("name=UrunYonetimDbContextPostgreSQL")
        {
            Database.SetInitializer(new DatabaseInitializer());
        }

        public virtual DbSet<Kullanici> Kullanicilar { get; set; }
        public virtual DbSet<Kategori> Kategoriler { get; set; }
        public virtual DbSet<Marka> Markalar { get; set; }
        public virtual DbSet<Urun> Urunler { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>(); // Veritaban�nda olu�acal olan tablolalar�n isimlerinin sonun "s" tak�s� gelmemesi i�in
            base.OnModelCreating(modelBuilder);
        }

        public class DatabaseInitializer : CreateDatabaseIfNotExists<StokYonetimiDbContext> // CreateDatabaseIfNotExists 'in anlam� e�er veritaban� yoksa olu�tur, <UrunYonetimDbContext>i�erisindeki dbsetlere g�re
        {
            protected override void Seed(StokYonetimiDbContext context) // Veritaban� olu�turdukdan sonra i�eri girip i�lem yapmam�z� sa�lar.
            {
                if (context.Kullanicilar.Any())
                {
                    context.Kullanicilar.Add(
                        new Kullanici()
                        {
                            Aktif = true,
                            KullaniciAdi = "admin",
                            Sifre = "123456"
                        });
                    ;

                    context.SaveChanges();
                }
                base.Seed(context);
            }
        }
    }

  
}