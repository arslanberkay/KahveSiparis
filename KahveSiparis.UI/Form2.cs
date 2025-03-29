
using KahveSiparis.UI.Enums;
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
           new Icecek{UrunAdi="Salep",BegenilmeOrani = 9.8,HazirlanmaSuresi = 12000},
           new Icecek{UrunAdi="Türk Kahvesi",BegenilmeOrani = 8.8,HazirlanmaSuresi = 15000},
           new Icecek{UrunAdi="Filtre Kahve",BegenilmeOrani = 9.4,HazirlanmaSuresi = 10000},
           new Icecek{UrunAdi="Latte",BegenilmeOrani = 9.1,HazirlanmaSuresi = 11000}
        };

        List<EkstraMalzemeler> ekstraMalzemeler = new List<EkstraMalzemeler>();

        private void UrunleriGetir()
        {
            foreach (var urun in urunler)
            {
                cbUrunler.Items.Add(urun);
            }
        }

        private void EkstraMalzemeleriGetir()
        {
            foreach (var ekstraMalzeme in Enum.GetValues(typeof(EkstraMalzemeler)))
            {
                chklbEkstraMalzemeler.Items.Add(ekstraMalzeme);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            UrunleriGetir();
            EkstraMalzemeleriGetir();
            TabloOlustur();
        }

        private void btnSiparisAl_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMusteriAdi.Text))
            {
                MessageBox.Show("Müşteri adı girilmesi zorunludur!");
                return;
            }
            if (cbUrunler.SelectedItem == null)
            {
                MessageBox.Show("Ürün seçimi zorunludur!");
                return;
            }

            IUrun seciliUrun = cbUrunler.SelectedItem as Icecek;
            seciliUrun.MusteriAdiSoyadi = txtMusteriAdi.Text;

            foreach (var seciliEkstraMalzeme in chklbEkstraMalzemeler.CheckedItems)
            {
                if (seciliEkstraMalzeme is EkstraMalzemeler ekstraMalzeme) //Enum türüne dönüştürdüm ve o şekilde listeye ekledim.
                {
                    seciliUrun.EkstraMalzemelerListesi.Add(ekstraMalzeme);
                }
            }

            ListViewItem listViewItem = new ListViewItem();
            listViewItem.Text = seciliUrun.MusteriAdiSoyadi;
            listViewItem.SubItems.Add(seciliUrun.UrunAdi);
            listViewItem.SubItems.Add(seciliUrun.BegenilmeOrani.ToString());
            listViewItem.SubItems.Add(string.Join(", ", seciliUrun.EkstraMalzemelerListesi));

            lstvSiparisler.Items.Add(listViewItem);

        }

        private void TabloOlustur()
        {
            lstvSiparisler.View = View.Details;
            lstvSiparisler.GridLines = true;
            lstvSiparisler.Columns.Add("Müşteri ", 200);
            lstvSiparisler.Columns.Add("Ürün", 200);
            lstvSiparisler.Columns.Add("Beğenilme Oranı", 200);
            lstvSiparisler.Columns.Add("Ekstra Malzemeler", 200);
        }
    }
}
