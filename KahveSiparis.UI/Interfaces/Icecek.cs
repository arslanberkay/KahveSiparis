﻿using KahveSiparis.UI.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveSiparis.UI.Interfaces
{
    internal class Icecek : IUrun
    {
        public string MusteriAdiSoyadi { get; set; }
        public string UrunAdi { get; set; }
        public int HazirlanmaSuresi { get; set; }
        public double BegenilmeOrani { get; set; }
        public List<EkstraMalzemeler> EkstraMalzemelerListesi { get; set; } = new List<EkstraMalzemeler>();

        public override string ToString()
        {
            return UrunAdi;
        }
    }
}
