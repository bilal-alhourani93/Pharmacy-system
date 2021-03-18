namespace VTYS_Proje_App
{
    partial class frmStokRapor
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
            this.cBoxUrunTur = new System.Windows.Forms.ComboBox();
            this.lnlUrunTur = new System.Windows.Forms.Label();
            this.lblUrunAd = new System.Windows.Forms.Label();
            this.cBoxUrunAd = new System.Windows.Forms.ComboBox();
            this.lblStoktaKalan = new System.Windows.Forms.Label();
            this.lblStoktaKalanAdet = new System.Windows.Forms.Label();
            this.btnGoster = new System.Windows.Forms.Button();
            this.lblKalanModel = new System.Windows.Forms.Label();
            this.cBoxKalanModel = new System.Windows.Forms.ComboBox();
            this.lblKalanModel2 = new System.Windows.Forms.Label();
            this.btnKalanModelGoster = new System.Windows.Forms.Button();
            this.lBoxKalanModel = new System.Windows.Forms.ListBox();
            this.btnGeri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cBoxUrunTur
            // 
            this.cBoxUrunTur.FormattingEnabled = true;
            this.cBoxUrunTur.Items.AddRange(new object[] {
            "Vitamin-Sağlık",
            "Ağız-Diş Bakımı",
            "Saç Bakımı",
            "Bebek Ürünlei",
            "İlaçlar"});
            this.cBoxUrunTur.Location = new System.Drawing.Point(132, 12);
            this.cBoxUrunTur.Name = "cBoxUrunTur";
            this.cBoxUrunTur.Size = new System.Drawing.Size(183, 21);
            this.cBoxUrunTur.TabIndex = 0;
            this.cBoxUrunTur.SelectedIndexChanged += new System.EventHandler(this.cBoxUrunTur_SelectedIndexChanged);
            this.cBoxUrunTur.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cBoxUrunTur_MouseClick);
            // 
            // lnlUrunTur
            // 
            this.lnlUrunTur.AutoSize = true;
            this.lnlUrunTur.Location = new System.Drawing.Point(12, 15);
            this.lnlUrunTur.Name = "lnlUrunTur";
            this.lnlUrunTur.Size = new System.Drawing.Size(61, 13);
            this.lnlUrunTur.TabIndex = 1;
            this.lnlUrunTur.Text = "Ürün Türü :";
            // 
            // lblUrunAd
            // 
            this.lblUrunAd.AutoSize = true;
            this.lblUrunAd.Location = new System.Drawing.Point(12, 42);
            this.lblUrunAd.Name = "lblUrunAd";
            this.lblUrunAd.Size = new System.Drawing.Size(54, 13);
            this.lblUrunAd.TabIndex = 2;
            this.lblUrunAd.Text = "Ürün Adı :";
            this.lblUrunAd.Click += new System.EventHandler(this.lblUrunAd_Click);
            // 
            // cBoxUrunAd
            // 
            this.cBoxUrunAd.FormattingEnabled = true;
            this.cBoxUrunAd.Location = new System.Drawing.Point(132, 39);
            this.cBoxUrunAd.Name = "cBoxUrunAd";
            this.cBoxUrunAd.Size = new System.Drawing.Size(183, 21);
            this.cBoxUrunAd.TabIndex = 3;
            this.cBoxUrunAd.SelectedIndexChanged += new System.EventHandler(this.cBoxUrunAd_SelectedIndexChanged);
            // 
            // lblStoktaKalan
            // 
            this.lblStoktaKalan.AutoSize = true;
            this.lblStoktaKalan.Location = new System.Drawing.Point(12, 71);
            this.lblStoktaKalan.Name = "lblStoktaKalan";
            this.lblStoktaKalan.Size = new System.Drawing.Size(99, 13);
            this.lblStoktaKalan.TabIndex = 4;
            this.lblStoktaKalan.Text = "Stokta Kalan Adet :";
            this.lblStoktaKalan.Click += new System.EventHandler(this.lblStoktaKalan_Click);
            // 
            // lblStoktaKalanAdet
            // 
            this.lblStoktaKalanAdet.AutoSize = true;
            this.lblStoktaKalanAdet.Location = new System.Drawing.Point(129, 71);
            this.lblStoktaKalanAdet.Name = "lblStoktaKalanAdet";
            this.lblStoktaKalanAdet.Size = new System.Drawing.Size(13, 13);
            this.lblStoktaKalanAdet.TabIndex = 5;
            this.lblStoktaKalanAdet.Text = "0";
            // 
            // btnGoster
            // 
            this.btnGoster.Location = new System.Drawing.Point(240, 66);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(75, 23);
            this.btnGoster.TabIndex = 6;
            this.btnGoster.Text = "Göster";
            this.btnGoster.UseVisualStyleBackColor = true;
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // lblKalanModel
            // 
            this.lblKalanModel.AutoSize = true;
            this.lblKalanModel.Location = new System.Drawing.Point(12, 98);
            this.lblKalanModel.Name = "lblKalanModel";
            this.lblKalanModel.Size = new System.Drawing.Size(37, 13);
            this.lblKalanModel.TabIndex = 7;
            this.lblKalanModel.Text = "Kalan ";
            // 
            // cBoxKalanModel
            // 
            this.cBoxKalanModel.FormattingEnabled = true;
            this.cBoxKalanModel.Items.AddRange(new object[] {
            "Vitamin-Sağlık",
            "Ağız-Diş Bakımı",
            "Saç Bakımı",
            "Bebek Ürünlei",
            "İlaçlar"});
            this.cBoxKalanModel.Location = new System.Drawing.Point(55, 93);
            this.cBoxKalanModel.Name = "cBoxKalanModel";
            this.cBoxKalanModel.Size = new System.Drawing.Size(118, 21);
            this.cBoxKalanModel.TabIndex = 8;
            // 
            // lblKalanModel2
            // 
            this.lblKalanModel2.AutoSize = true;
            this.lblKalanModel2.Location = new System.Drawing.Point(179, 98);
            this.lblKalanModel2.Name = "lblKalanModel2";
            this.lblKalanModel2.Size = new System.Drawing.Size(49, 13);
            this.lblKalanModel2.TabIndex = 9;
            this.lblKalanModel2.Text = "Modelleri";
            // 
            // btnKalanModelGoster
            // 
            this.btnKalanModelGoster.Location = new System.Drawing.Point(240, 93);
            this.btnKalanModelGoster.Name = "btnKalanModelGoster";
            this.btnKalanModelGoster.Size = new System.Drawing.Size(75, 23);
            this.btnKalanModelGoster.TabIndex = 10;
            this.btnKalanModelGoster.Text = "Göster";
            this.btnKalanModelGoster.UseVisualStyleBackColor = true;
            this.btnKalanModelGoster.Click += new System.EventHandler(this.btnKalanModelGoster_Click);
            // 
            // lBoxKalanModel
            // 
            this.lBoxKalanModel.FormattingEnabled = true;
            this.lBoxKalanModel.Location = new System.Drawing.Point(15, 122);
            this.lBoxKalanModel.Name = "lBoxKalanModel";
            this.lBoxKalanModel.Size = new System.Drawing.Size(300, 95);
            this.lBoxKalanModel.TabIndex = 11;
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(236, 242);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(75, 23);
            this.btnGeri.TabIndex = 12;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // frmStokRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(323, 277);
            this.ControlBox = false;
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.lBoxKalanModel);
            this.Controls.Add(this.btnKalanModelGoster);
            this.Controls.Add(this.lblKalanModel2);
            this.Controls.Add(this.cBoxKalanModel);
            this.Controls.Add(this.lblKalanModel);
            this.Controls.Add(this.btnGoster);
            this.Controls.Add(this.lblStoktaKalanAdet);
            this.Controls.Add(this.lblStoktaKalan);
            this.Controls.Add(this.cBoxUrunAd);
            this.Controls.Add(this.lblUrunAd);
            this.Controls.Add(this.lnlUrunTur);
            this.Controls.Add(this.cBoxUrunTur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmStokRapor";
            this.Text = "Stok Durumu Raporları";
            this.Load += new System.EventHandler(this.frmStokRapor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cBoxUrunTur;
        private System.Windows.Forms.Label lnlUrunTur;
        private System.Windows.Forms.Label lblUrunAd;
        private System.Windows.Forms.ComboBox cBoxUrunAd;
        private System.Windows.Forms.Label lblStoktaKalan;
        private System.Windows.Forms.Label lblStoktaKalanAdet;
        private System.Windows.Forms.Button btnGoster;
        private System.Windows.Forms.Label lblKalanModel;
        private System.Windows.Forms.ComboBox cBoxKalanModel;
        private System.Windows.Forms.Label lblKalanModel2;
        private System.Windows.Forms.Button btnKalanModelGoster;
        private System.Windows.Forms.ListBox lBoxKalanModel;
        private System.Windows.Forms.Button btnGeri;
    }
}