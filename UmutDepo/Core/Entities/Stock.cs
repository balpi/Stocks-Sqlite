using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmutDepo.Core.Entities
{
    public class Stock:BaseEntity
    {
        public string UrunAdi { get; set; }
        public string OlcuBirimi { get; set; }
        public double StokMiktari { get; set; }
        public  string GuncellemeTarihi { get; set; }
    }
}
