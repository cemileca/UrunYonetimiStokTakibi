using System;

namespace Entities
{
    public class Marka : IEntity
    {
        public int Id { get; set; }
        public string MarkaAdi { get; set; }
        public string MarkaAciklamasi { get; set; }
        public DateTime EklemeTarihi { get; set; }
        public bool Aktif { get; set; }
    }
}
