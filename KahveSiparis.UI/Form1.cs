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
           new Calisan{AdSoyad = "Berkay Arslan",CalismaAlani="�r�n Haz�rlama"},
           new Calisan{AdSoyad = "Ekrem Hosanl�",CalismaAlani="�r�n Haz�rlama"},
           new Calisan{AdSoyad = "Talha Din", CalismaAlani = "Kasa"},
           new Calisan{AdSoyad = "Do�a Y�ld�z",CalismaAlani="�r�n Haz�rlama"},
       };

        private void CalisanAlanlariGoster()
        {
            cbCalismaAlanlari.Items.Add("Kasa");
            cbCalismaAlanlari.Items.Add("�r�n Haz�rlama");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CalisanAlanlariGoster();
            DataGridViewTabloOlustur();
            Temizle();
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
                MessageBox.Show("�al��an ad soyad bo� olmamal�d�r!");
                return;
            }
            if (cbCalismaAlanlari.SelectedItem == null)
            {
                MessageBox.Show("�al��ma alan� se�ilmelidir!");
                return;
            }

            Calisan calisan = new Calisan();
            calisan.AdSoyad = txtCalisanAdSoyad.Text;
            calisan.CalismaAlani = cbCalismaAlanlari.SelectedItem.ToString();

            calisanlar.Add(calisan);

            TabloyuGuncelle();
            MessageBox.Show($"Yeni �al��an ekleme i�lemi ba�ar�l�! Aktif �al��an say�s� : {calisanlar.Count} ");
            Temizle();
        }

        private void Temizle()
        {
            txtCalisanAdSoyad.Text = string.Empty;
            cbCalismaAlanlari.SelectedItem = null;
            dgvCalisanlar.ClearSelection(); //Se�ili sat�rlar� kald�r�r.
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
                MessageBox.Show("L�tfen silmek istedi�iniz �al��an� se�iniz!");
                return;
            }

            Calisan silinecekCalisan = dgvCalisanlar.SelectedRows[0].DataBoundItem as Calisan;
            calisanlar.Remove(silinecekCalisan);

            TabloyuGuncelle();
            MessageBox.Show($"�al��an silme i�lemi ba�ar�yla sonu�land�! Aktif �al��an : {calisanlar.Count}");
            Temizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvCalisanlar.SelectedRows.Count == 0)
            {
                MessageBox.Show("L�tfen g�ncellemek istedi�iniz �al��an� se�iniz!");
                return;
            }

            //�al��anlar� listede g�ncelle
            Calisan guncellenecekCalisan = dgvCalisanlar.SelectedRows[0].DataBoundItem as Calisan;
            guncellenecekCalisan.AdSoyad = txtCalisanAdSoyad.Text;
            guncellenecekCalisan.CalismaAlani = cbCalismaAlanlari.SelectedItem.ToString();

            

            

            TabloyuGuncelle();
            MessageBox.Show("�al��an ba�ar�yla g�ncellendi!");
            Temizle();
        }

        private void btnYerlestir_Click(object sender, EventArgs e)
        {
            if (dgvCalisanlar.Rows.Count != 4)
            {
                MessageBox.Show("Toplamda 4 �al��an olmal�d�r.");
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
            }
            if (!(dagilimSayisi >= 1 && dagilimSayisi <= 2))
            {
                MessageBox.Show("Kasada en fazla 2 en az 1 �al��an olabilir.");
                return;
            }
            this.Hide();
            Form2 form2 = new Form2(calisanlar);
            form2.ShowDialog();

        }
    }
}
