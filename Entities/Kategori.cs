using System;

namespace Entities
{
    public class Kategori:IEntity 
    {
        public int Id { get; set; }
        public string KategoriAdi { get; set; }
        public string KategoriAciklamasi { get; set; }
        public DateTime  EklemeTarihi { get; set; }
        public bool Aktif { get; set; }
    }
}
