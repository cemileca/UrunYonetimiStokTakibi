using DAL;
using Entities;
using System.Collections.Generic;
using System.Linq;

namespace BL
{
    public class MarkaManager
    {
        StokYonetimiDbContext contextimiz= new StokYonetimiDbContext();

        public List<Marka> GetAll()
        {
            return contextimiz.Markalar.ToList();
        }
    }
}
 