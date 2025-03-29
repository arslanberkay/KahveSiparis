
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

           
            Icecek orijinalUrun = cbUrunler.SelectedItem as Icecek;
            IUrun seciliUrun = new Icecek
            {
                UrunAdi = orijinalUrun.UrunAdi,
                BegenilmeOrani = orijinalUrun.BegenilmeOrani,
                HazirlanmaSuresi = orijinalUrun.HazirlanmaSuresi,
                MusteriAdiSoyadi = txtMusteriAdi.Text
            };
          

            seciliUrun.EkstraMalzemelerListesi.Clear();

            int ekstraMalzemelerinHazirlanmaSuresi = 0;
            foreach (var seciliEkstraMalzeme in chklbEkstraMalzemeler.CheckedItems)
            {
                if (seciliEkstraMalzeme is EkstraMalzemeler ekstraMalzeme) //Enum türüne dönüştürdüm ve o şekilde listeye ekledim.
                {
                    seciliUrun.EkstraMalzemelerListesi.Add(ekstraMalzeme);
                    ekstraMalzemelerinHazirlanmaSuresi += (int)ekstraMalzeme; //Ekstra malzemeler enumundaki karşılık değerleri ekledim
                }
            }
            seciliUrun.HazirlanmaSuresi += ekstraMalzemelerinHazirlanmaSuresi;

            ListViewItem listViewItem = new ListViewItem();
            listViewItem.Text = seciliUrun.MusteriAdiSoyadi;
            listViewItem.SubItems.Add(seciliUrun.UrunAdi);
            listViewItem.SubItems.Add(seciliUrun.BegenilmeOrani.ToString());
            listViewItem.SubItems.Add(string.Join(", ", seciliUrun.EkstraMalzemelerListesi));
            listViewItem.SubItems.Add((seciliUrun.HazirlanmaSuresi / 1000).ToString());

            if (MusaitCalisanVarmi())
            {
                lstvSiparisler.Items.Add(listViewItem);
                CalisanaGonder(seciliUrun.MusteriAdiSoyadi, seciliUrun.HazirlanmaSuresi);
            }
            else
            {
                MessageBox.Show("Şuanda tüm çalışanlarımız dolu!");
            }
            Temizle();
        }

        private void Temizle()
        {
            txtMusteriAdi.Text = string.Empty;
            cbUrunler.SelectedItem = null;

            //CheckedBox içindeki tüm seçili olan itemların seçili olma durumlarını false çektim.
            for (int i = 0; i < chklbEkstraMalzemeler.Items.Count; i++)
            {
                chklbEkstraMalzemeler.SetItemChecked(i, false);
            }
        }

        private void TabloOlustur()
        {
            lstvSiparisler.View = View.Details;
            lstvSiparisler.GridLines = true;
            lstvSiparisler.Columns.Add("Müşteri ", 200);
            lstvSiparisler.Columns.Add("Ürün", 200);
            lstvSiparisler.Columns.Add("Beğenilme Oranı", 200);
            lstvSiparisler.Columns.Add("Ekstra Malzemeler", 200);
            lstvSiparisler.Columns.Add("Hazırlanma Süresi", 200);

        }

        private async void CalisanaGonder(string musteriAdi, int hazirlanmaSuresi)
        {
            for (int i = 0; i < calisanlar.Count; i++)
            {
                if (calisanlar[i].MusaitlikDurumu)
                {
                    lblHazirlanmaAlani.Text += $"{calisanlar[i].AdSoyad} => Merhaba {musteriAdi.ToUpper()}. Siparişini {hazirlanmaSuresi / 1000} saniye içinde hazırlıyorum.{Environment.NewLine}";
                    calisanlar[i].MusaitlikDurumu = false;
                    await Task.Delay(hazirlanmaSuresi);
                    lblHazirlanmaAlani.Text += $"{musteriAdi.ToUpper()} ürününüz hazır!{Environment.NewLine}";
                    calisanlar[i].MusaitlikDurumu = true;
                    break;
                }
            }
        }

        private bool MusaitCalisanVarmi()
        {
            for (int i = 0; i < calisanlar.Count; i++)
            {
                if (calisanlar[i].MusaitlikDurumu)
                {
                    return true;
                }
            }
            return false;
        }


    }
}
