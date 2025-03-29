namespace KahveSiparis.UI
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnSiparisAl = new Button();
            chklbEkstraMalzemeler = new CheckedListBox();
            txtMusteriAdi = new TextBox();
            label3 = new Label();
            cbUrunler = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            lstvSiparisler = new ListView();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSiparisAl);
            groupBox1.Controls.Add(chklbEkstraMalzemeler);
            groupBox1.Controls.Add(txtMusteriAdi);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cbUrunler);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(71, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(461, 416);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ürün Bilgileri";
            // 
            // btnSiparisAl
            // 
            btnSiparisAl.Location = new Point(23, 342);
            btnSiparisAl.Name = "btnSiparisAl";
            btnSiparisAl.Size = new Size(386, 54);
            btnSiparisAl.TabIndex = 7;
            btnSiparisAl.Text = "Sipariş Al";
            btnSiparisAl.UseVisualStyleBackColor = true;
            btnSiparisAl.Click += btnSiparisAl_Click;
            // 
            // chklbEkstraMalzemeler
            // 
            chklbEkstraMalzemeler.FormattingEnabled = true;
            chklbEkstraMalzemeler.Location = new Point(199, 118);
            chklbEkstraMalzemeler.Name = "chklbEkstraMalzemeler";
            chklbEkstraMalzemeler.Size = new Size(210, 207);
            chklbEkstraMalzemeler.TabIndex = 6;
            // 
            // txtMusteriAdi
            // 
            txtMusteriAdi.Location = new Point(197, 36);
            txtMusteriAdi.Name = "txtMusteriAdi";
            txtMusteriAdi.Size = new Size(212, 34);
            txtMusteriAdi.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 40);
            label3.Name = "label3";
            label3.Size = new Size(113, 28);
            label3.TabIndex = 4;
            label3.Text = "Müşteri Adı";
            // 
            // cbUrunler
            // 
            cbUrunler.FormattingEnabled = true;
            cbUrunler.Location = new Point(199, 75);
            cbUrunler.Name = "cbUrunler";
            cbUrunler.Size = new Size(210, 36);
            cbUrunler.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 118);
            label2.Name = "label2";
            label2.Size = new Size(170, 28);
            label2.TabIndex = 1;
            label2.Text = "Ekstra Malzemeler";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 78);
            label1.Name = "label1";
            label1.Size = new Size(77, 28);
            label1.TabIndex = 0;
            label1.Text = "Ürünler";
            // 
            // lstvSiparisler
            // 
            lstvSiparisler.Location = new Point(590, 73);
            lstvSiparisler.Name = "lstvSiparisler";
            lstvSiparisler.Size = new Size(1027, 339);
            lstvSiparisler.TabIndex = 1;
            lstvSiparisler.UseCompatibleStateImageBehavior = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1704, 788);
            Controls.Add(lstvSiparisler);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Form2";
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private CheckedListBox chklbEkstraMalzemeler;
        private TextBox txtMusteriAdi;
        private Label label3;
        private ComboBox cbUrunler;
        private Button btnSiparisAl;
        private ListView lstvSiparisler;
    }
}