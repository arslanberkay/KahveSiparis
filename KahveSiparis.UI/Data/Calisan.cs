using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveSiparis.UI.Interfaces
{
    public class Calisan
    {
        public string AdSoyad { get; set; }
        public string CalismaAlani { get; set; }
        public bool MusaitlikDurumu { get; set; } = true;



        public override string ToString()
        {
            return AdSoyad;
        }
    }
}
