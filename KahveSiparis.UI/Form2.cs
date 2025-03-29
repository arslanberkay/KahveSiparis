
using KahveSiparis.UI.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KahveSiparis.UI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        List<Calisan> calisanlar; //Adları,yerleri ve müsaitlik durumları hazır olan çalışan listesi

        public Form2(List<Calisan> yerlestirilenCalisanlar) : this()
        {
            calisanlar = yerlestirilenCalisanlar;
        }

        List<IUrun> urunler = new List<IUrun>
        {
           new Icecek{UrunAdi="Salep",BegenilmeOrani = 9.8,HazirlanmaSuresi = 12},
           new Icecek{UrunAdi="Türk Kahvesi",BegenilmeOrani = 8.8,HazirlanmaSuresi = 15},
           new Icecek{UrunAdi="Filtre Kahve",BegenilmeOrani = 9.4,HazirlanmaSuresi = 10},
           new Icecek{UrunAdi="Latte",BegenilmeOrani = 9.1,HazirlanmaSuresi = 11}
        };

        private void UrunleriGetir()
        {
            foreach (var urun in urunler)
            {
                cbUrunler.Items.Add(urun);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            UrunleriGetir();
        }
    }
}
