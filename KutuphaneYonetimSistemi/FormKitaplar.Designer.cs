namespace KutuphaneYonetimSistemi
{
    partial class FormKitaplar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKitaplar));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxKitapTurKodu = new System.Windows.Forms.TextBox();
            this.textBoxISBN = new System.Windows.Forms.TextBox();
            this.textBoxYazarSoyadi = new System.Windows.Forms.TextBox();
            this.textBoxYazarAdi = new System.Windows.Forms.TextBox();
            this.textBoxKitapAdi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonKitapOduncVer = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxOduncAlan = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonKitapİadeEt = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.labelGecikmeBedeli = new System.Windows.Forms.Label();
            this.labelGecikmetext = new System.Windows.Forms.Label();
            this.buttonGecikmeHesaplama = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridViewKitaplar = new System.Windows.Forms.DataGridView();
            this.buttonYeniKitapEkle = new System.Windows.Forms.Button();
            this.buttonKitapBilgiGuncelle = new System.Windows.Forms.Button();
            this.buttonTemizle = new System.Windows.Forms.Button();
            this.buttonSorgula = new System.Windows.Forms.Button();
            this.buttonHepsiniGoster = new System.Windows.Forms.Button();
            this.buttonKayitSil = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKitaplar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxKitapTurKodu);
            this.groupBox1.Controls.Add(this.textBoxISBN);
            this.groupBox1.Controls.Add(this.textBoxYazarSoyadi);
            this.groupBox1.Controls.Add(this.textBoxYazarAdi);
            this.groupBox1.Controls.Add(this.textBoxKitapAdi);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.labelID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 215);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kitap Kayıt Ve Güncelleme";
            // 
            // textBoxKitapTurKodu
            // 
            this.textBoxKitapTurKodu.Location = new System.Drawing.Point(163, 181);
            this.textBoxKitapTurKodu.Name = "textBoxKitapTurKodu";
            this.textBoxKitapTurKodu.Size = new System.Drawing.Size(100, 23);
            this.textBoxKitapTurKodu.TabIndex = 11;
            // 
            // textBoxISBN
            // 
            this.textBoxISBN.Location = new System.Drawing.Point(163, 152);
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.Size = new System.Drawing.Size(100, 23);
            this.textBoxISBN.TabIndex = 10;
            // 
            // textBoxYazarSoyadi
            // 
            this.textBoxYazarSoyadi.Location = new System.Drawing.Point(163, 123);
            this.textBoxYazarSoyadi.Name = "textBoxYazarSoyadi";
            this.textBoxYazarSoyadi.Size = new System.Drawing.Size(216, 23);
            this.textBoxYazarSoyadi.TabIndex = 9;
            // 
            // textBoxYazarAdi
            // 
            this.textBoxYazarAdi.Location = new System.Drawing.Point(163, 87);
            this.textBoxYazarAdi.Name = "textBoxYazarAdi";
            this.textBoxYazarAdi.Size = new System.Drawing.Size(216, 23);
            this.textBoxYazarAdi.TabIndex = 8;
            // 
            // textBoxKitapAdi
            // 
            this.textBoxKitapAdi.Location = new System.Drawing.Point(163, 54);
            this.textBoxKitapAdi.Name = "textBoxKitapAdi";
            this.textBoxKitapAdi.Size = new System.Drawing.Size(216, 23);
            this.textBoxKitapAdi.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(6, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Kitap Tür Kodu:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(6, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "ISBN:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(6, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Yazar Soyadı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(6, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Yazar Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kitap Adı:";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelID.Location = new System.Drawing.Point(107, 19);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(28, 25);
            this.labelID.TabIndex = 1;
            this.labelID.Text = "--";
            this.labelID.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonKitapOduncVer);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.textBoxOduncAlan);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(440, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(258, 215);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kitap Ödünç Alma";
            // 
            // buttonKitapOduncVer
            // 
            this.buttonKitapOduncVer.Location = new System.Drawing.Point(71, 181);
            this.buttonKitapOduncVer.Name = "buttonKitapOduncVer";
            this.buttonKitapOduncVer.Size = new System.Drawing.Size(110, 30);
            this.buttonKitapOduncVer.TabIndex = 8;
            this.buttonKitapOduncVer.Text = "Kitap Ödünç Ver";
            this.buttonKitapOduncVer.UseVisualStyleBackColor = true;
            this.buttonKitapOduncVer.Click += new System.EventHandler(this.buttonKitapOduncVer_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(143, 125);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(110, 23);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(6, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 25);
            this.label9.TabIndex = 5;
            this.label9.Text = "Alma Tarihi:";
            // 
            // textBoxOduncAlan
            // 
            this.textBoxOduncAlan.Location = new System.Drawing.Point(143, 59);
            this.textBoxOduncAlan.Name = "textBoxOduncAlan";
            this.textBoxOduncAlan.Size = new System.Drawing.Size(110, 23);
            this.textBoxOduncAlan.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(6, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 25);
            this.label8.TabIndex = 3;
            this.label8.Text = "Ödünç Alan:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonKitapİadeEt);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.labelGecikmeBedeli);
            this.groupBox3.Controls.Add(this.labelGecikmetext);
            this.groupBox3.Controls.Add(this.buttonGecikmeHesaplama);
            this.groupBox3.Location = new System.Drawing.Point(699, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(234, 215);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kitap İade";
            // 
            // buttonKitapİadeEt
            // 
            this.buttonKitapİadeEt.Location = new System.Drawing.Point(49, 181);
            this.buttonKitapİadeEt.Name = "buttonKitapİadeEt";
            this.buttonKitapİadeEt.Size = new System.Drawing.Size(132, 28);
            this.buttonKitapİadeEt.TabIndex = 7;
            this.buttonKitapİadeEt.Text = "Kitap İade Et";
            this.buttonKitapİadeEt.UseVisualStyleBackColor = true;
            this.buttonKitapİadeEt.Click += new System.EventHandler(this.buttonKitapİadeEt_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(203, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 25);
            this.label12.TabIndex = 6;
            this.label12.Text = "Tl";
            // 
            // labelGecikmeBedeli
            // 
            this.labelGecikmeBedeli.AutoSize = true;
            this.labelGecikmeBedeli.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelGecikmeBedeli.Location = new System.Drawing.Point(158, 30);
            this.labelGecikmeBedeli.Name = "labelGecikmeBedeli";
            this.labelGecikmeBedeli.Size = new System.Drawing.Size(23, 25);
            this.labelGecikmeBedeli.TabIndex = 5;
            this.labelGecikmeBedeli.Text = "0";
            this.labelGecikmeBedeli.Click += new System.EventHandler(this.label11_Click);
            // 
            // labelGecikmetext
            // 
            this.labelGecikmetext.AutoSize = true;
            this.labelGecikmetext.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelGecikmetext.Location = new System.Drawing.Point(0, 30);
            this.labelGecikmetext.Name = "labelGecikmetext";
            this.labelGecikmetext.Size = new System.Drawing.Size(152, 25);
            this.labelGecikmetext.TabIndex = 4;
            this.labelGecikmetext.Text = "Gecikme Bedeli:";
            // 
            // buttonGecikmeHesaplama
            // 
            this.buttonGecikmeHesaplama.Location = new System.Drawing.Point(49, 125);
            this.buttonGecikmeHesaplama.Name = "buttonGecikmeHesaplama";
            this.buttonGecikmeHesaplama.Size = new System.Drawing.Size(132, 31);
            this.buttonGecikmeHesaplama.TabIndex = 0;
            this.buttonGecikmeHesaplama.Text = "Gecikme Hesaplama";
            this.buttonGecikmeHesaplama.UseVisualStyleBackColor = true;
            this.buttonGecikmeHesaplama.Click += new System.EventHandler(this.buttonGecikmeHesaplama_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridViewKitaplar);
            this.groupBox4.Location = new System.Drawing.Point(0, 282);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(930, 167);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Kitap Listesi";
            // 
            // dataGridViewKitaplar
            // 
            this.dataGridViewKitaplar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKitaplar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewKitaplar.Location = new System.Drawing.Point(3, 19);
            this.dataGridViewKitaplar.Name = "dataGridViewKitaplar";
            this.dataGridViewKitaplar.Size = new System.Drawing.Size(924, 145);
            this.dataGridViewKitaplar.TabIndex = 0;
            this.dataGridViewKitaplar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKitaplar_CellClick);
            this.dataGridViewKitaplar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKitaplar_CellContentClick);
            // 
            // buttonYeniKitapEkle
            // 
            this.buttonYeniKitapEkle.Location = new System.Drawing.Point(109, 242);
            this.buttonYeniKitapEkle.Name = "buttonYeniKitapEkle";
            this.buttonYeniKitapEkle.Size = new System.Drawing.Size(72, 34);
            this.buttonYeniKitapEkle.TabIndex = 4;
            this.buttonYeniKitapEkle.Text = "Kitap Ekle";
            this.buttonYeniKitapEkle.UseVisualStyleBackColor = true;
            this.buttonYeniKitapEkle.Click += new System.EventHandler(this.buttonYeniKitapEkle_Click);
            // 
            // buttonKitapBilgiGuncelle
            // 
            this.buttonKitapBilgiGuncelle.Location = new System.Drawing.Point(12, 242);
            this.buttonKitapBilgiGuncelle.Name = "buttonKitapBilgiGuncelle";
            this.buttonKitapBilgiGuncelle.Size = new System.Drawing.Size(91, 34);
            this.buttonKitapBilgiGuncelle.TabIndex = 5;
            this.buttonKitapBilgiGuncelle.Text = "Kitap Güncelle";
            this.buttonKitapBilgiGuncelle.UseVisualStyleBackColor = true;
            this.buttonKitapBilgiGuncelle.Click += new System.EventHandler(this.buttonKitapBilgiGuncelle_Click);
            // 
            // buttonTemizle
            // 
            this.buttonTemizle.Location = new System.Drawing.Point(373, 242);
            this.buttonTemizle.Name = "buttonTemizle";
            this.buttonTemizle.Size = new System.Drawing.Size(61, 34);
            this.buttonTemizle.TabIndex = 6;
            this.buttonTemizle.Text = "Temizle";
            this.buttonTemizle.UseVisualStyleBackColor = true;
            this.buttonTemizle.Click += new System.EventHandler(this.buttonTemizle_Click);
            // 
            // buttonSorgula
            // 
            this.buttonSorgula.Location = new System.Drawing.Point(312, 242);
            this.buttonSorgula.Name = "buttonSorgula";
            this.buttonSorgula.Size = new System.Drawing.Size(55, 34);
            this.buttonSorgula.TabIndex = 7;
            this.buttonSorgula.Text = "Sorgula";
            this.buttonSorgula.UseVisualStyleBackColor = true;
            this.buttonSorgula.Click += new System.EventHandler(this.buttonSorgula_Click);
            // 
            // buttonHepsiniGoster
            // 
            this.buttonHepsiniGoster.Location = new System.Drawing.Point(254, 242);
            this.buttonHepsiniGoster.Name = "buttonHepsiniGoster";
            this.buttonHepsiniGoster.Size = new System.Drawing.Size(52, 34);
            this.buttonHepsiniGoster.TabIndex = 8;
            this.buttonHepsiniGoster.Text = "Göster";
            this.buttonHepsiniGoster.UseVisualStyleBackColor = true;
            this.buttonHepsiniGoster.Click += new System.EventHandler(this.buttonHepsiniGoster_Click);
            // 
            // buttonKayitSil
            // 
            this.buttonKayitSil.Location = new System.Drawing.Point(184, 242);
            this.buttonKayitSil.Name = "buttonKayitSil";
            this.buttonKayitSil.Size = new System.Drawing.Size(64, 34);
            this.buttonKayitSil.TabIndex = 12;
            this.buttonKayitSil.Text = "Kayıt Sil";
            this.buttonKayitSil.UseVisualStyleBackColor = true;
            this.buttonKayitSil.Click += new System.EventHandler(this.buttonKayitSil_Click);
            // 
            // FormKitaplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(931, 450);
            this.Controls.Add(this.buttonKayitSil);
            this.Controls.Add(this.buttonHepsiniGoster);
            this.Controls.Add(this.buttonSorgula);
            this.Controls.Add(this.buttonTemizle);
            this.Controls.Add(this.buttonKitapBilgiGuncelle);
            this.Controls.Add(this.buttonYeniKitapEkle);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormKitaplar";
            this.Text = "Kütüpkane Kitap Yönetim Sistemi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormKitaplar_FormClosed);
            this.Load += new System.EventHandler(this.FormKitaplar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKitaplar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label labelID;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox textBoxKitapTurKodu;
        private TextBox textBoxISBN;
        private TextBox textBoxYazarSoyadi;
        private TextBox textBoxYazarAdi;
        private TextBox textBoxKitapAdi;
        private DateTimePicker dateTimePicker1;
        private Label label9;
        private TextBox textBoxOduncAlan;
        private Label label8;
        private Label labelGecikmeBedeli;
        private Label labelGecikmetext;
        private Button buttonGecikmeHesaplama;
        private GroupBox groupBox4;
        private DataGridView dataGridViewKitaplar;
        private Button buttonYeniKitapEkle;
        private Button buttonKitapBilgiGuncelle;
        private Label label12;
        private Button buttonKitapOduncVer;
        private Button buttonKitapİadeEt;
        private Button buttonTemizle;
        private Button buttonSorgula;
        private Button buttonHepsiniGoster;
        private Button buttonKayitSil;
    }
}