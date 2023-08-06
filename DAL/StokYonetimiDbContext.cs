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
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>(); // Veritabanýnda oluþacal olan tablolalarýn isimlerinin sonun "s" takýsý gelmemesi için
            base.OnModelCreating(modelBuilder);
        }

        public class DatabaseInitializer : CreateDatabaseIfNotExists<StokYonetimiDbContext> // CreateDatabaseIfNotExists 'in anlamý eðer veritabaný yoksa oluþtur, <UrunYonetimDbContext>içerisindeki dbsetlere göre
        {
            protected override void Seed(StokYonetimiDbContext context) // Veritabaný oluþturdukdan sonra içeri girip iþlem yapmamýzý saðlar.
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