namespace KahveSiparis.UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            cbCalismaAlanlari = new ComboBox();
            groupBox1 = new GroupBox();
            txtCalisanAdSoyad = new TextBox();
            btnGuncelle = new Button();
            dgvCalisanlar = new DataGridView();
            btnSil = new Button();
            btnEkle = new Button();
            btnYerlestir = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCalisanlar).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 56);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(163, 28);
            label1.TabIndex = 0;
            label1.Text = "Çalışan Ad Soyad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 107);
            label2.Name = "label2";
            label2.Size = new Size(128, 28);
            label2.TabIndex = 2;
            label2.Text = "Çalışma Alanı";
            // 
            // cbCalismaAlanlari
            // 
            cbCalismaAlanlari.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCalismaAlanlari.FormattingEnabled = true;
            cbCalismaAlanlari.Location = new Point(194, 104);
            cbCalismaAlanlari.Name = "cbCalismaAlanlari";
            cbCalismaAlanlari.Size = new Size(193, 36);
            cbCalismaAlanlari.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtCalisanAdSoyad);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cbCalismaAlanlari);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(76, 50);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(414, 162);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Çalışan Bilgileri";
            // 
            // txtCalisanAdSoyad
            // 
            txtCalisanAdSoyad.Location = new Point(194, 56);
            txtCalisanAdSoyad.Name = "txtCalisanAdSoyad";
            txtCalisanAdSoyad.Size = new Size(193, 34);
            txtCalisanAdSoyad.TabIndex = 4;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(358, 229);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(130, 62);
            btnGuncelle.TabIndex = 4;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // dgvCalisanlar
            // 
            dgvCalisanlar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCalisanlar.Location = new Point(76, 328);
            dgvCalisanlar.Name = "dgvCalisanlar";
            dgvCalisanlar.ReadOnly = true;
            dgvCalisanlar.RowHeadersWidth = 10;
            dgvCalisanlar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCalisanlar.Size = new Size(414, 224);
            dgvCalisanlar.TabIndex = 5;
            dgvCalisanlar.CellClick += dgvCalisanlar_CellClick;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(222, 229);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(130, 62);
            btnSil.TabIndex = 4;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(86, 229);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(130, 62);
            btnEkle.TabIndex = 4;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnYerlestir
            // 
            btnYerlestir.Location = new Point(75, 568);
            btnYerlestir.Name = "btnYerlestir";
            btnYerlestir.Size = new Size(415, 63);
            btnYerlestir.TabIndex = 6;
            btnYerlestir.Text = "Yerleştir";
            btnYerlestir.UseVisualStyleBackColor = true;
            btnYerlestir.Click += btnYerlestir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 659);
            Controls.Add(btnYerlestir);
            Controls.Add(dgvCalisanlar);
            Controls.Add(btnEkle);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCalisanlar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cbCalismaAlanlari;
        private GroupBox groupBox1;
        private Button btnGuncelle;
        private DataGridView dgvCalisanlar;
        private TextBox txtCalisanAdSoyad;
        private Button btnSil;
        private Button btnEkle;
        private Button btnYerlestir;
    }
}
