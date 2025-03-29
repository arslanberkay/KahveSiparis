using KahveSiparis.UI.Interfaces;

namespace KahveSiparis.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Calisan> calisanlar = new List<Calisan>
       {
           new Calisan{AdSoyad = "Berkay Arslan"},
           new Calisan{AdSoyad = "Ekrem Hosanlý"},
           new Calisan{AdSoyad = "Talha Din"},
           new Calisan{AdSoyad = "Doða Yýldýz"},
       };

        private void CalisanAlanlariGoster()
        {
            cbCalismaAlanlari.Items.Add("Kasa");
            cbCalismaAlanlari.Items.Add("Ürün Hazýrlama");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CalisanAlanlariGoster();
            DataGridViewTabloOlustur();
        }

        private void DataGridViewTabloOlustur()
        {
            dgvCalisanlar.DataSource = calisanlar;
            dgvCalisanlar.Columns["MusaitlikDurumu"].Visible = false;
        }

        private void TabloyuGuncelle()
        {
            dgvCalisanlar.DataSource = null;
            dgvCalisanlar.DataSource = calisanlar;
            dgvCalisanlar.Columns["MusaitlikDurumu"].Visible = false;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtCalisanAdSoyad.Text))
            {
                MessageBox.Show("Çalýþan ad soyad boþ olmamalýdýr!");
                return;
            }
            if (cbCalismaAlanlari.SelectedItem == null)
            {
                MessageBox.Show("Çalýþma alaný seçilmelidir!");
                return;
            }

            Calisan calisan = new Calisan();
            calisan.AdSoyad = txtCalisanAdSoyad.Text;
            calisan.CalismaAlani = cbCalismaAlanlari.SelectedItem.ToString();

            calisanlar.Add(calisan);

            TabloyuGuncelle();
        }

        private void dgvCalisanlar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCalisanlar.SelectedRows.Count > 0 && e.RowIndex >= 0)
            {
                txtCalisanAdSoyad.Text = dgvCalisanlar.SelectedRows[0].Cells[0].Value.ToString();
                cbCalismaAlanlari.Text = dgvCalisanlar.SelectedRows[0].Cells[1].Value?.ToString() ?? "";
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvCalisanlar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silmek istediðiniz çalýþaný seçiniz!");
                return;
            }

            Calisan silinecekCalisan = dgvCalisanlar.SelectedRows[0].DataBoundItem as Calisan;
            calisanlar.Remove(silinecekCalisan);

            TabloyuGuncelle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvCalisanlar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen güncellemek istediðiniz çalýþaný seçiniz!");
                return;
            }

            Calisan guncellenecekCalisan = dgvCalisanlar.SelectedRows[0].DataBoundItem as Calisan;
            guncellenecekCalisan.AdSoyad = txtCalisanAdSoyad.Text;
            guncellenecekCalisan.CalismaAlani = cbCalismaAlanlari.SelectedItem.ToString();

            TabloyuGuncelle();
        }

        private void btnYerlestir_Click(object sender, EventArgs e)
        {
            if (dgvCalisanlar.Rows.Count != 4)
            {
                MessageBox.Show("Toplamda 4 çalýþan olmalýdýr.");
                return;
            }

            int dagilimSayisi = 0;
            foreach (var calisan in calisanlar)
            {
                if (calisan.CalismaAlani == "Kasa")
                {
                    dagilimSayisi++;
                    calisan.MusaitlikDurumu = false; 
                }
                if (!(dagilimSayisi > 0 && dagilimSayisi < 2))
                {
                    MessageBox.Show("Kasada en fazla 2 en az 1 çalýþan olabilir.");
                    return;
                }
            }

            Form2 form2 = new Form2(calisanlar);
            form2.ShowDialog();
        }
    }
}
