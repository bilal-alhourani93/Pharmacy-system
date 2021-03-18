namespace VTYS_Proje_App
{
    partial class frmAna
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
            this.tbcntrlAna = new System.Windows.Forms.TabControl();
            this.tbpgKullanici = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlKullaniciKontrol = new System.Windows.Forms.Panel();
            this.btnKullaniciEkle = new System.Windows.Forms.Button();
            this.lblSilID = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.lblDuzenleID = new System.Windows.Forms.Label();
            this.txtSilID = new System.Windows.Forms.TextBox();
            this.btnKullaniciDuzenle = new System.Windows.Forms.Button();
            this.txtDuzenleID = new System.Windows.Forms.TextBox();
            this.btnKullaniciSil = new System.Windows.Forms.Button();
            this.lblKullanicilar = new System.Windows.Forms.Label();
            this.dgwKullanicilar = new System.Windows.Forms.DataGridView();
            this.tbpgMusteri = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.btnMusteriGuncelle = new System.Windows.Forms.Button();
            this.lblMusteriler = new System.Windows.Forms.Label();
            this.dgvMusteriler = new System.Windows.Forms.DataGridView();
            this.txtMusteriKaldir = new System.Windows.Forms.TextBox();
            this.lblMusteriSil = new System.Windows.Forms.Label();
            this.txtMusteriDuzenle = new System.Windows.Forms.TextBox();
            this.lblMusteriDuzenle = new System.Windows.Forms.Label();
            this.btnMusteriKaldir = new System.Windows.Forms.Button();
            this.btnMusteriDuzenle = new System.Windows.Forms.Button();
            this.btnMusteriEkle = new System.Windows.Forms.Button();
            this.tbpgStok = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnlStokKontrol = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.btnStokKontrol = new System.Windows.Forms.Button();
            this.txtUrunDuzenle = new System.Windows.Forms.TextBox();
            this.btnSiparis = new System.Windows.Forms.Button();
            this.lblUrunDuzenle = new System.Windows.Forms.Label();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.lblUrunKod = new System.Windows.Forms.Label();
            this.txtKaldirUrun = new System.Windows.Forms.TextBox();
            this.UrunKaldir = new System.Windows.Forms.Button();
            this.UrunDuzenle = new System.Windows.Forms.Button();
            this.tbpgSatis = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.btnSat = new System.Windows.Forms.Button();
            this.lblSatisAdet = new System.Windows.Forms.Label();
            this.txtSatisAdet = new System.Windows.Forms.TextBox();
            this.txtUrunKod = new System.Windows.Forms.TextBox();
            this.lblSatisUrunKod = new System.Windows.Forms.Label();
            this.btnTCKontol = new System.Windows.Forms.Button();
            this.txtMusteriTC = new System.Windows.Forms.TextBox();
            this.lblMusteriTC = new System.Windows.Forms.Label();
            this.tbcntrlAna.SuspendLayout();
            this.tbpgKullanici.SuspendLayout();
            this.pnlKullaniciKontrol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwKullanicilar)).BeginInit();
            this.tbpgMusteri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriler)).BeginInit();
            this.tbpgStok.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlStokKontrol.SuspendLayout();
            this.tbpgSatis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcntrlAna
            // 
            this.tbcntrlAna.Controls.Add(this.tbpgKullanici);
            this.tbcntrlAna.Controls.Add(this.tbpgMusteri);
            this.tbcntrlAna.Controls.Add(this.tbpgStok);
            this.tbcntrlAna.Controls.Add(this.tbpgSatis);
            this.tbcntrlAna.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcntrlAna.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbcntrlAna.Location = new System.Drawing.Point(0, 0);
            this.tbcntrlAna.Margin = new System.Windows.Forms.Padding(0);
            this.tbcntrlAna.Multiline = true;
            this.tbcntrlAna.Name = "tbcntrlAna";
            this.tbcntrlAna.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbcntrlAna.SelectedIndex = 0;
            this.tbcntrlAna.Size = new System.Drawing.Size(782, 486);
            this.tbcntrlAna.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tbcntrlAna.TabIndex = 0;
            // 
            // tbpgKullanici
            // 
            this.tbpgKullanici.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbpgKullanici.Controls.Add(this.button1);
            this.tbpgKullanici.Controls.Add(this.pnlKullaniciKontrol);
            this.tbpgKullanici.Controls.Add(this.lblKullanicilar);
            this.tbpgKullanici.Controls.Add(this.dgwKullanicilar);
            this.tbpgKullanici.Location = new System.Drawing.Point(4, 22);
            this.tbpgKullanici.Name = "tbpgKullanici";
            this.tbpgKullanici.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgKullanici.Size = new System.Drawing.Size(774, 460);
            this.tbpgKullanici.TabIndex = 0;
            this.tbpgKullanici.Text = "Kullanıcı İşlemleri";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(673, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Çıkış Yap";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlKullaniciKontrol
            // 
            this.pnlKullaniciKontrol.Controls.Add(this.btnKullaniciEkle);
            this.pnlKullaniciKontrol.Controls.Add(this.lblSilID);
            this.pnlKullaniciKontrol.Controls.Add(this.btnGuncelle);
            this.pnlKullaniciKontrol.Controls.Add(this.lblDuzenleID);
            this.pnlKullaniciKontrol.Controls.Add(this.txtSilID);
            this.pnlKullaniciKontrol.Controls.Add(this.btnKullaniciDuzenle);
            this.pnlKullaniciKontrol.Controls.Add(this.txtDuzenleID);
            this.pnlKullaniciKontrol.Controls.Add(this.btnKullaniciSil);
            this.pnlKullaniciKontrol.Location = new System.Drawing.Point(6, 6);
            this.pnlKullaniciKontrol.Name = "pnlKullaniciKontrol";
            this.pnlKullaniciKontrol.Size = new System.Drawing.Size(753, 132);
            this.pnlKullaniciKontrol.TabIndex = 10;
            this.pnlKullaniciKontrol.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlKullaniciKontrol_Paint);
            // 
            // btnKullaniciEkle
            // 
            this.btnKullaniciEkle.Location = new System.Drawing.Point(3, 3);
            this.btnKullaniciEkle.Name = "btnKullaniciEkle";
            this.btnKullaniciEkle.Size = new System.Drawing.Size(109, 29);
            this.btnKullaniciEkle.TabIndex = 0;
            this.btnKullaniciEkle.Text = "Kullanıcı Ekle";
            this.btnKullaniciEkle.UseVisualStyleBackColor = true;
            this.btnKullaniciEkle.Click += new System.EventHandler(this.btnKullaniciEkle_Click);
            // 
            // lblSilID
            // 
            this.lblSilID.AutoSize = true;
            this.lblSilID.Location = new System.Drawing.Point(249, 66);
            this.lblSilID.Name = "lblSilID";
            this.lblSilID.Size = new System.Drawing.Size(112, 13);
            this.lblSilID.TabIndex = 8;
            this.lblSilID.Text = "Silinecek Kişinin ID\'si :";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(3, 90);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(109, 29);
            this.btnGuncelle.TabIndex = 9;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // lblDuzenleID
            // 
            this.lblDuzenleID.AutoSize = true;
            this.lblDuzenleID.Location = new System.Drawing.Point(249, 37);
            this.lblDuzenleID.Name = "lblDuzenleID";
            this.lblDuzenleID.Size = new System.Drawing.Size(138, 13);
            this.lblDuzenleID.TabIndex = 7;
            this.lblDuzenleID.Text = "Düzenlenecek Kişinin ID\'si :";
            // 
            // txtSilID
            // 
            this.txtSilID.Location = new System.Drawing.Point(412, 63);
            this.txtSilID.Name = "txtSilID";
            this.txtSilID.Size = new System.Drawing.Size(100, 20);
            this.txtSilID.TabIndex = 6;
            this.txtSilID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMusteriTC_KeyPress);
            // 
            // btnKullaniciDuzenle
            // 
            this.btnKullaniciDuzenle.Location = new System.Drawing.Point(3, 32);
            this.btnKullaniciDuzenle.Name = "btnKullaniciDuzenle";
            this.btnKullaniciDuzenle.Size = new System.Drawing.Size(109, 29);
            this.btnKullaniciDuzenle.TabIndex = 1;
            this.btnKullaniciDuzenle.Text = "Kullanıcı Düzenle";
            this.btnKullaniciDuzenle.UseVisualStyleBackColor = true;
            this.btnKullaniciDuzenle.Click += new System.EventHandler(this.btnKullaniciDuzenle_Click);
            // 
            // txtDuzenleID
            // 
            this.txtDuzenleID.Location = new System.Drawing.Point(412, 34);
            this.txtDuzenleID.Name = "txtDuzenleID";
            this.txtDuzenleID.Size = new System.Drawing.Size(100, 20);
            this.txtDuzenleID.TabIndex = 5;
            this.txtDuzenleID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMusteriTC_KeyPress);
            // 
            // btnKullaniciSil
            // 
            this.btnKullaniciSil.Location = new System.Drawing.Point(3, 61);
            this.btnKullaniciSil.Name = "btnKullaniciSil";
            this.btnKullaniciSil.Size = new System.Drawing.Size(109, 29);
            this.btnKullaniciSil.TabIndex = 2;
            this.btnKullaniciSil.Text = "Kullanıcı Sil";
            this.btnKullaniciSil.UseVisualStyleBackColor = true;
            this.btnKullaniciSil.Click += new System.EventHandler(this.btnKullaniciSil_Click);
            // 
            // lblKullanicilar
            // 
            this.lblKullanicilar.AutoSize = true;
            this.lblKullanicilar.Location = new System.Drawing.Point(8, 156);
            this.lblKullanicilar.Name = "lblKullanicilar";
            this.lblKullanicilar.Size = new System.Drawing.Size(57, 13);
            this.lblKullanicilar.TabIndex = 4;
            this.lblKullanicilar.Text = "Kullanıcılar";
            // 
            // dgwKullanicilar
            // 
            this.dgwKullanicilar.AllowUserToAddRows = false;
            this.dgwKullanicilar.AllowUserToDeleteRows = false;
            this.dgwKullanicilar.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgwKullanicilar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwKullanicilar.Location = new System.Drawing.Point(29, 172);
            this.dgwKullanicilar.Name = "dgwKullanicilar";
            this.dgwKullanicilar.ReadOnly = true;
            this.dgwKullanicilar.Size = new System.Drawing.Size(691, 211);
            this.dgwKullanicilar.TabIndex = 3;
            this.dgwKullanicilar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwKullanicilar_CellContentClick);
            // 
            // tbpgMusteri
            // 
            this.tbpgMusteri.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbpgMusteri.Controls.Add(this.button3);
            this.tbpgMusteri.Controls.Add(this.btnMusteriGuncelle);
            this.tbpgMusteri.Controls.Add(this.lblMusteriler);
            this.tbpgMusteri.Controls.Add(this.dgvMusteriler);
            this.tbpgMusteri.Controls.Add(this.txtMusteriKaldir);
            this.tbpgMusteri.Controls.Add(this.lblMusteriSil);
            this.tbpgMusteri.Controls.Add(this.txtMusteriDuzenle);
            this.tbpgMusteri.Controls.Add(this.lblMusteriDuzenle);
            this.tbpgMusteri.Controls.Add(this.btnMusteriKaldir);
            this.tbpgMusteri.Controls.Add(this.btnMusteriDuzenle);
            this.tbpgMusteri.Controls.Add(this.btnMusteriEkle);
            this.tbpgMusteri.Location = new System.Drawing.Point(4, 22);
            this.tbpgMusteri.Name = "tbpgMusteri";
            this.tbpgMusteri.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgMusteri.Size = new System.Drawing.Size(774, 460);
            this.tbpgMusteri.TabIndex = 2;
            this.tbpgMusteri.Text = "Müşteri İşlemleri";
            this.tbpgMusteri.Click += new System.EventHandler(this.tbpgStok_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(673, 408);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Çıkış Yap";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnMusteriGuncelle
            // 
            this.btnMusteriGuncelle.Location = new System.Drawing.Point(6, 126);
            this.btnMusteriGuncelle.Name = "btnMusteriGuncelle";
            this.btnMusteriGuncelle.Size = new System.Drawing.Size(109, 29);
            this.btnMusteriGuncelle.TabIndex = 10;
            this.btnMusteriGuncelle.Text = "Güncelle";
            this.btnMusteriGuncelle.UseVisualStyleBackColor = true;
            this.btnMusteriGuncelle.Click += new System.EventHandler(this.btnMusteriGuncelle_Click);
            // 
            // lblMusteriler
            // 
            this.lblMusteriler.AutoSize = true;
            this.lblMusteriler.Location = new System.Drawing.Point(8, 165);
            this.lblMusteriler.Name = "lblMusteriler";
            this.lblMusteriler.Size = new System.Drawing.Size(52, 13);
            this.lblMusteriler.TabIndex = 9;
            this.lblMusteriler.Text = "Musteriler";
            // 
            // dgvMusteriler
            // 
            this.dgvMusteriler.AllowUserToAddRows = false;
            this.dgvMusteriler.AllowUserToDeleteRows = false;
            this.dgvMusteriler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMusteriler.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvMusteriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMusteriler.Location = new System.Drawing.Point(6, 193);
            this.dgvMusteriler.Name = "dgvMusteriler";
            this.dgvMusteriler.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvMusteriler.Size = new System.Drawing.Size(765, 209);
            this.dgvMusteriler.TabIndex = 8;
            this.dgvMusteriler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMusteriler_CellContentClick);
            // 
            // txtMusteriKaldir
            // 
            this.txtMusteriKaldir.Location = new System.Drawing.Point(371, 88);
            this.txtMusteriKaldir.MaxLength = 11;
            this.txtMusteriKaldir.Multiline = true;
            this.txtMusteriKaldir.Name = "txtMusteriKaldir";
            this.txtMusteriKaldir.Size = new System.Drawing.Size(170, 20);
            this.txtMusteriKaldir.TabIndex = 7;
            this.txtMusteriKaldir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMusteriTC_KeyPress);
            // 
            // lblMusteriSil
            // 
            this.lblMusteriSil.AutoSize = true;
            this.lblMusteriSil.Location = new System.Drawing.Point(153, 91);
            this.lblMusteriSil.Name = "lblMusteriSil";
            this.lblMusteriSil.Size = new System.Drawing.Size(180, 13);
            this.lblMusteriSil.TabIndex = 6;
            this.lblMusteriSil.Text = "Kaldırılıcak Müşteri TC Kimlik No\' su :";
            // 
            // txtMusteriDuzenle
            // 
            this.txtMusteriDuzenle.Location = new System.Drawing.Point(371, 47);
            this.txtMusteriDuzenle.MaxLength = 11;
            this.txtMusteriDuzenle.Name = "txtMusteriDuzenle";
            this.txtMusteriDuzenle.Size = new System.Drawing.Size(170, 20);
            this.txtMusteriDuzenle.TabIndex = 5;
            this.txtMusteriDuzenle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMusteriTC_KeyPress);
            // 
            // lblMusteriDuzenle
            // 
            this.lblMusteriDuzenle.AutoSize = true;
            this.lblMusteriDuzenle.Location = new System.Drawing.Point(153, 50);
            this.lblMusteriDuzenle.Name = "lblMusteriDuzenle";
            this.lblMusteriDuzenle.Size = new System.Drawing.Size(199, 13);
            this.lblMusteriDuzenle.TabIndex = 4;
            this.lblMusteriDuzenle.Text = "Düzenlenecek Müşteri TC Kimlik No\' su :";
            // 
            // btnMusteriKaldir
            // 
            this.btnMusteriKaldir.Location = new System.Drawing.Point(6, 88);
            this.btnMusteriKaldir.Name = "btnMusteriKaldir";
            this.btnMusteriKaldir.Size = new System.Drawing.Size(109, 29);
            this.btnMusteriKaldir.TabIndex = 3;
            this.btnMusteriKaldir.Text = "Müşteri Kaldır";
            this.btnMusteriKaldir.UseVisualStyleBackColor = true;
            this.btnMusteriKaldir.Click += new System.EventHandler(this.btnMusteriKaldir_Click);
            // 
            // btnMusteriDuzenle
            // 
            this.btnMusteriDuzenle.Location = new System.Drawing.Point(8, 50);
            this.btnMusteriDuzenle.Name = "btnMusteriDuzenle";
            this.btnMusteriDuzenle.Size = new System.Drawing.Size(109, 29);
            this.btnMusteriDuzenle.TabIndex = 2;
            this.btnMusteriDuzenle.Text = "Müşteri Düzenle";
            this.btnMusteriDuzenle.UseVisualStyleBackColor = true;
            this.btnMusteriDuzenle.Click += new System.EventHandler(this.btnMusteriDuzenle_Click);
            // 
            // btnMusteriEkle
            // 
            this.btnMusteriEkle.Location = new System.Drawing.Point(8, 15);
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(109, 29);
            this.btnMusteriEkle.TabIndex = 1;
            this.btnMusteriEkle.Text = "Müşteri Ekle";
            this.btnMusteriEkle.UseVisualStyleBackColor = true;
            this.btnMusteriEkle.Click += new System.EventHandler(this.btnMusteriEkle_Click);
            // 
            // tbpgStok
            // 
            this.tbpgStok.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbpgStok.Controls.Add(this.button2);
            this.tbpgStok.Controls.Add(this.dataGridView1);
            this.tbpgStok.Controls.Add(this.pnlStokKontrol);
            this.tbpgStok.Location = new System.Drawing.Point(4, 22);
            this.tbpgStok.Name = "tbpgStok";
            this.tbpgStok.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgStok.Size = new System.Drawing.Size(774, 460);
            this.tbpgStok.TabIndex = 1;
            this.tbpgStok.Text = "Stok İşlemleri";
            this.tbpgStok.Click += new System.EventHandler(this.tbpgStok_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(673, 408);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Çıkış Yap";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(92, 220);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(617, 157);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pnlStokKontrol
            // 
            this.pnlStokKontrol.Controls.Add(this.button6);
            this.pnlStokKontrol.Controls.Add(this.btnStokKontrol);
            this.pnlStokKontrol.Controls.Add(this.txtUrunDuzenle);
            this.pnlStokKontrol.Controls.Add(this.btnSiparis);
            this.pnlStokKontrol.Controls.Add(this.lblUrunDuzenle);
            this.pnlStokKontrol.Controls.Add(this.btnUrunEkle);
            this.pnlStokKontrol.Controls.Add(this.lblUrunKod);
            this.pnlStokKontrol.Controls.Add(this.txtKaldirUrun);
            this.pnlStokKontrol.Controls.Add(this.UrunKaldir);
            this.pnlStokKontrol.Controls.Add(this.UrunDuzenle);
            this.pnlStokKontrol.Location = new System.Drawing.Point(8, 6);
            this.pnlStokKontrol.Name = "pnlStokKontrol";
            this.pnlStokKontrol.Size = new System.Drawing.Size(756, 172);
            this.pnlStokKontrol.TabIndex = 10;
            this.pnlStokKontrol.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlStokKontrol_Paint);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(572, 93);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(109, 32);
            this.button6.TabIndex = 10;
            this.button6.Text = "Stok Durumu";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnStokKontrol
            // 
            this.btnStokKontrol.Location = new System.Drawing.Point(572, 17);
            this.btnStokKontrol.Name = "btnStokKontrol";
            this.btnStokKontrol.Size = new System.Drawing.Size(109, 32);
            this.btnStokKontrol.TabIndex = 0;
            this.btnStokKontrol.Text = "Stok Kontrolü Yap";
            this.btnStokKontrol.UseVisualStyleBackColor = true;
            this.btnStokKontrol.Click += new System.EventHandler(this.btnStokKontrol_Click);
            // 
            // txtUrunDuzenle
            // 
            this.txtUrunDuzenle.Location = new System.Drawing.Point(384, 77);
            this.txtUrunDuzenle.Name = "txtUrunDuzenle";
            this.txtUrunDuzenle.Size = new System.Drawing.Size(125, 20);
            this.txtUrunDuzenle.TabIndex = 9;
            this.txtUrunDuzenle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMusteriTC_KeyPress);
            // 
            // btnSiparis
            // 
            this.btnSiparis.Location = new System.Drawing.Point(572, 55);
            this.btnSiparis.Name = "btnSiparis";
            this.btnSiparis.Size = new System.Drawing.Size(109, 32);
            this.btnSiparis.TabIndex = 1;
            this.btnSiparis.Text = "Sipariş Ver";
            this.btnSiparis.UseVisualStyleBackColor = true;
            this.btnSiparis.Click += new System.EventHandler(this.btnSiparis_Click);
            // 
            // lblUrunDuzenle
            // 
            this.lblUrunDuzenle.AutoSize = true;
            this.lblUrunDuzenle.Location = new System.Drawing.Point(250, 80);
            this.lblUrunDuzenle.Name = "lblUrunDuzenle";
            this.lblUrunDuzenle.Size = new System.Drawing.Size(136, 13);
            this.lblUrunDuzenle.TabIndex = 8;
            this.lblUrunDuzenle.Text = "Düzenlenecek Ürün Kodu :";
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.Location = new System.Drawing.Point(65, 16);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(109, 32);
            this.btnUrunEkle.TabIndex = 2;
            this.btnUrunEkle.Text = "Ürün Ekle";
            this.btnUrunEkle.UseVisualStyleBackColor = true;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // lblUrunKod
            // 
            this.lblUrunKod.AutoSize = true;
            this.lblUrunKod.Location = new System.Drawing.Point(261, 35);
            this.lblUrunKod.Name = "lblUrunKod";
            this.lblUrunKod.Size = new System.Drawing.Size(117, 13);
            this.lblUrunKod.TabIndex = 7;
            this.lblUrunKod.Text = "Kaldırılıcak Ürün Kodu :";
            // 
            // txtKaldirUrun
            // 
            this.txtKaldirUrun.Location = new System.Drawing.Point(384, 32);
            this.txtKaldirUrun.Name = "txtKaldirUrun";
            this.txtKaldirUrun.Size = new System.Drawing.Size(125, 20);
            this.txtKaldirUrun.TabIndex = 6;
            this.txtKaldirUrun.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMusteriTC_KeyPress);
            // 
            // UrunKaldir
            // 
            this.UrunKaldir.Location = new System.Drawing.Point(65, 55);
            this.UrunKaldir.Name = "UrunKaldir";
            this.UrunKaldir.Size = new System.Drawing.Size(109, 32);
            this.UrunKaldir.TabIndex = 3;
            this.UrunKaldir.Text = "Ürün Kaldır";
            this.UrunKaldir.UseVisualStyleBackColor = true;
            this.UrunKaldir.Click += new System.EventHandler(this.UrunKaldir_Click);
            // 
            // UrunDuzenle
            // 
            this.UrunDuzenle.Location = new System.Drawing.Point(65, 93);
            this.UrunDuzenle.Name = "UrunDuzenle";
            this.UrunDuzenle.Size = new System.Drawing.Size(109, 32);
            this.UrunDuzenle.TabIndex = 4;
            this.UrunDuzenle.Text = "Ürün Düzenle";
            this.UrunDuzenle.UseVisualStyleBackColor = true;
            this.UrunDuzenle.Click += new System.EventHandler(this.UrunDuzenle_Click);
            // 
            // tbpgSatis
            // 
            this.tbpgSatis.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbpgSatis.Controls.Add(this.dataGridView2);
            this.tbpgSatis.Controls.Add(this.button4);
            this.tbpgSatis.Controls.Add(this.btnSat);
            this.tbpgSatis.Controls.Add(this.lblSatisAdet);
            this.tbpgSatis.Controls.Add(this.txtSatisAdet);
            this.tbpgSatis.Controls.Add(this.txtUrunKod);
            this.tbpgSatis.Controls.Add(this.lblSatisUrunKod);
            this.tbpgSatis.Controls.Add(this.btnTCKontol);
            this.tbpgSatis.Controls.Add(this.txtMusteriTC);
            this.tbpgSatis.Controls.Add(this.lblMusteriTC);
            this.tbpgSatis.Location = new System.Drawing.Point(4, 22);
            this.tbpgSatis.Name = "tbpgSatis";
            this.tbpgSatis.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgSatis.Size = new System.Drawing.Size(774, 460);
            this.tbpgSatis.TabIndex = 3;
            this.tbpgSatis.Text = "Satışlar";
            this.tbpgSatis.Click += new System.EventHandler(this.tbpgSatis_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(146, 168);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(516, 216);
            this.dataGridView2.TabIndex = 14;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(673, 408);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "Çıkış Yap";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnSat
            // 
            this.btnSat.Location = new System.Drawing.Point(498, 102);
            this.btnSat.Name = "btnSat";
            this.btnSat.Size = new System.Drawing.Size(86, 25);
            this.btnSat.TabIndex = 7;
            this.btnSat.Text = "Sat";
            this.btnSat.UseVisualStyleBackColor = true;
            this.btnSat.Click += new System.EventHandler(this.btnSat_Click);
            // 
            // lblSatisAdet
            // 
            this.lblSatisAdet.AutoSize = true;
            this.lblSatisAdet.Location = new System.Drawing.Point(346, 105);
            this.lblSatisAdet.Name = "lblSatisAdet";
            this.lblSatisAdet.Size = new System.Drawing.Size(35, 13);
            this.lblSatisAdet.TabIndex = 6;
            this.lblSatisAdet.Text = "Adet :";
            // 
            // txtSatisAdet
            // 
            this.txtSatisAdet.Location = new System.Drawing.Point(387, 102);
            this.txtSatisAdet.Multiline = true;
            this.txtSatisAdet.Name = "txtSatisAdet";
            this.txtSatisAdet.Size = new System.Drawing.Size(105, 23);
            this.txtSatisAdet.TabIndex = 5;
            this.txtSatisAdet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMusteriTC_KeyPress);
            // 
            // txtUrunKod
            // 
            this.txtUrunKod.Location = new System.Drawing.Point(185, 99);
            this.txtUrunKod.Multiline = true;
            this.txtUrunKod.Name = "txtUrunKod";
            this.txtUrunKod.Size = new System.Drawing.Size(145, 23);
            this.txtUrunKod.TabIndex = 4;
            this.txtUrunKod.TextChanged += new System.EventHandler(this.txtUrunKod_TextChanged);
            this.txtUrunKod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMusteriTC_KeyPress);
            // 
            // lblSatisUrunKod
            // 
            this.lblSatisUrunKod.AutoSize = true;
            this.lblSatisUrunKod.Location = new System.Drawing.Point(115, 102);
            this.lblSatisUrunKod.Name = "lblSatisUrunKod";
            this.lblSatisUrunKod.Size = new System.Drawing.Size(64, 13);
            this.lblSatisUrunKod.TabIndex = 3;
            this.lblSatisUrunKod.Text = "Ürün Kodu :";
            this.lblSatisUrunKod.Click += new System.EventHandler(this.lblSatisUrunKod_Click);
            // 
            // btnTCKontol
            // 
            this.btnTCKontol.Location = new System.Drawing.Point(336, 39);
            this.btnTCKontol.Name = "btnTCKontol";
            this.btnTCKontol.Size = new System.Drawing.Size(86, 25);
            this.btnTCKontol.TabIndex = 2;
            this.btnTCKontol.Text = "Kotrol Et";
            this.btnTCKontol.UseVisualStyleBackColor = true;
            this.btnTCKontol.Click += new System.EventHandler(this.btnTCKontol_Click);
            // 
            // txtMusteriTC
            // 
            this.txtMusteriTC.Location = new System.Drawing.Point(186, 39);
            this.txtMusteriTC.MaxLength = 11;
            this.txtMusteriTC.Multiline = true;
            this.txtMusteriTC.Name = "txtMusteriTC";
            this.txtMusteriTC.Size = new System.Drawing.Size(145, 23);
            this.txtMusteriTC.TabIndex = 1;
            this.txtMusteriTC.TextChanged += new System.EventHandler(this.txtMusteriTC_TextChanged);
            this.txtMusteriTC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMusteriTC_KeyPress);
            // 
            // lblMusteriTC
            // 
            this.lblMusteriTC.AutoSize = true;
            this.lblMusteriTC.Location = new System.Drawing.Point(106, 42);
            this.lblMusteriTC.Name = "lblMusteriTC";
            this.lblMusteriTC.Size = new System.Drawing.Size(74, 13);
            this.lblMusteriTC.TabIndex = 0;
            this.lblMusteriTC.Text = "TC Kimlik No :";
            this.lblMusteriTC.Click += new System.EventHandler(this.lblMusteriTC_Click);
            // 
            // frmAna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(782, 486);
            this.ControlBox = false;
            this.Controls.Add(this.tbcntrlAna);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmAna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eczane";
            this.Load += new System.EventHandler(this.frmAna_Load);
            this.tbcntrlAna.ResumeLayout(false);
            this.tbpgKullanici.ResumeLayout(false);
            this.tbpgKullanici.PerformLayout();
            this.pnlKullaniciKontrol.ResumeLayout(false);
            this.pnlKullaniciKontrol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwKullanicilar)).EndInit();
            this.tbpgMusteri.ResumeLayout(false);
            this.tbpgMusteri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriler)).EndInit();
            this.tbpgStok.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlStokKontrol.ResumeLayout(false);
            this.pnlStokKontrol.PerformLayout();
            this.tbpgSatis.ResumeLayout(false);
            this.tbpgSatis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcntrlAna;
        private System.Windows.Forms.TabPage tbpgKullanici;
        private System.Windows.Forms.TabPage tbpgStok;
        private System.Windows.Forms.TabPage tbpgMusteri;
        private System.Windows.Forms.TabPage tbpgSatis;
        private System.Windows.Forms.Label lblDuzenleID;
        private System.Windows.Forms.TextBox txtSilID;
        private System.Windows.Forms.TextBox txtDuzenleID;
        private System.Windows.Forms.Label lblKullanicilar;
        private System.Windows.Forms.DataGridView dgwKullanicilar;
        private System.Windows.Forms.Button btnKullaniciSil;
        private System.Windows.Forms.Button btnKullaniciDuzenle;
        private System.Windows.Forms.Button btnKullaniciEkle;
        private System.Windows.Forms.Label lblSilID;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label lblUrunKod;
        private System.Windows.Forms.TextBox txtKaldirUrun;
        private System.Windows.Forms.Button UrunDuzenle;
        private System.Windows.Forms.Button UrunKaldir;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.Button btnSiparis;
        private System.Windows.Forms.Button btnStokKontrol;
        private System.Windows.Forms.TextBox txtUrunDuzenle;
        private System.Windows.Forms.Label lblUrunDuzenle;
        private System.Windows.Forms.Button btnMusteriKaldir;
        private System.Windows.Forms.Button btnMusteriDuzenle;
        private System.Windows.Forms.Button btnMusteriEkle;
        private System.Windows.Forms.TextBox txtMusteriKaldir;
        private System.Windows.Forms.Label lblMusteriSil;
        private System.Windows.Forms.TextBox txtMusteriDuzenle;
        private System.Windows.Forms.Label lblMusteriDuzenle;
        private System.Windows.Forms.Label lblMusteriler;
        private System.Windows.Forms.DataGridView dgvMusteriler;
        private System.Windows.Forms.Button btnMusteriGuncelle;
        private System.Windows.Forms.Button btnTCKontol;
        private System.Windows.Forms.TextBox txtMusteriTC;
        private System.Windows.Forms.Label lblMusteriTC;
        private System.Windows.Forms.Button btnSat;
        private System.Windows.Forms.Label lblSatisAdet;
        private System.Windows.Forms.TextBox txtSatisAdet;
        private System.Windows.Forms.TextBox txtUrunKod;
        private System.Windows.Forms.Label lblSatisUrunKod;
        private System.Windows.Forms.Panel pnlKullaniciKontrol;
        private System.Windows.Forms.Panel pnlStokKontrol;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button6;
    }
}