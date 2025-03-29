using KahveSiparis.UI.Enums;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveSiparis.UI.Interfaces
{
    public interface IUrun
    {
        public string MusteriAdiSoyadi { get; set; }
        public string UrunAdi { get; set; }
        public int HazirlanmaSuresi { get; set; }
        public double BegenilmeOrani { get; set; }
        public List<EkstraMalzemeler> EkstraMalzemelerListesi { get; set; } 


    }
}
