using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.SqlServer.Server;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;



namespace VTYS_Proje_App
{
    public partial class frmAna : Form
    {
        frmKullaniciEkle frmKullaniciEkle = new frmKullaniciEkle();
        frmKullaniciDuzenle frmKullaniciDuzenle = new frmKullaniciDuzenle();
        frmUrunDuzenle frmUrunDuzenle = new frmUrunDuzenle();
        frmMusteriDuzenle frmMusteriDuzenle = new frmMusteriDuzenle();

        public static string Yetki;
        string connectionString = @"Data Source=DESKTOP-789A4S9\SQLEXPRESS;Initial Catalog=ECZANE;Integrated Security=True";

        public void GosterMusteriler()
        {
            string queryMusteriler = "Select MusteriID,TCKimlikNo,Ad,SoyAd,DogumTarih,Cinsiyet,Mail,Tel,il from Musteriler where Aktif=1";
            SqlConnection cnnMusteriler = new SqlConnection(connectionString);
            SqlDataAdapter daMusteriler = new SqlDataAdapter(queryMusteriler, cnnMusteriler);
            DataTable dtMusteriler = new DataTable();
            daMusteriler.Fill(dtMusteriler);
            dgvMusteriler.DataSource = dtMusteriler;
            dgvMusteriler.Refresh();
            cnnMusteriler.Close();
        }
        public void GosterUrunler()
        {
             string queryUrunler = "select U.UrunKod,U.UrunTur,U.UrunAd,U.UrunFiyat,U.UrunAciklama,S.Adet from Urunler as U inner join stok as S on U.UrunKod=S.UrunKod  ";
          //  string queryUrunler = "select * from Urunler  ";
            SqlConnection cnnUrunler = new SqlConnection(connectionString);
            SqlDataAdapter da = new SqlDataAdapter(queryUrunler, cnnUrunler);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            cnnUrunler.Close();
        }
        public void GosterSatis()
        {
            string querysatis = "select S.MusteriID ,U.UrunAd, S.SatisTarih, S.Adet from Satislar as S inner join Urunler as U on U.UrunKod=S.UrunKod ";

            SqlConnection cnnsatis = new SqlConnection(connectionString);
            SqlDataAdapter dd = new SqlDataAdapter(querysatis, cnnsatis);
            DataTable de = new DataTable();
            dd.Fill(de);
            dataGridView2.DataSource = de;
            dataGridView2.Refresh();
            cnnsatis.Close();
        }
        private void txtMusteriTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        public void GosterKullanicilar()
        {
            string queryKullanicilar = "Select * from Kullanicilar";
            SqlConnection cnnKullanicilar = new SqlConnection(connectionString);
            SqlDataAdapter daKullanicilar = new SqlDataAdapter(queryKullanicilar, cnnKullanicilar);
            DataTable dtKullanicilar = new DataTable();
            daKullanicilar.Fill(dtKullanicilar);

            dgwKullanicilar.DataSource = dtKullanicilar;
            dgwKullanicilar.Refresh();
            cnnKullanicilar.Close();
        }

        public frmAna()
        {
            InitializeComponent();
        }

        public void frmAna_Load_()
        {

            if (Yetki == "Admin" )
            {
                GosterKullanicilar();
            }

            if (Yetki != "Admin")
            {
                pnlKullaniciKontrol.Visible = false;
            
            }

            if (Yetki != "Admin" && Yetki != "Yönetici")
            {
                pnlStokKontrol.Visible = false;
            }

            GosterMusteriler();
            GosterUrunler();
            GosterSatis();
        }

        private void frmAna_Load(object sender, EventArgs e)
        {
            frmAna_Load_();

            string queryUrunler = "exec sp_UrunBilgi";
            SqlConnection cnnUrunler = new SqlConnection(connectionString);
            SqlDataAdapter daUrunler = new SqlDataAdapter(queryUrunler, cnnUrunler);
            DataTable dtUrunler = new DataTable();
            daUrunler.Fill(dtUrunler);
        }

        private void btnKullaniciEkle_Click(object sender, EventArgs e)
        {
            frmKullaniciEkle.Show();
            this.Hide();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            GosterKullanicilar();
        }

        private void btnKullaniciSil_Click(object sender, EventArgs e)
        {
            if (txtSilID.Text == "")
            {
                txtSilID.Text = "0";
            }

            string queryKullaniciIDKontrol = "select * from Kullanicilar where KullaniciID='" + Convert.ToInt32(txtSilID.Text) + "'";

            SqlConnection cnnKullaniciIDKontrol = new SqlConnection(connectionString);
            cnnKullaniciIDKontrol.Open();
            SqlCommand cmdKullaniciIDKontrol = new SqlCommand(queryKullaniciIDKontrol);
            cmdKullaniciIDKontrol.Connection = cnnKullaniciIDKontrol;
            SqlDataAdapter daKullaniciIDKontrol = new SqlDataAdapter(queryKullaniciIDKontrol, cnnKullaniciIDKontrol);
            SqlDataReader drKullaniciIDKontrol = cmdKullaniciIDKontrol.ExecuteReader();

            if (drKullaniciIDKontrol.Read())
            {
                try
                {
                    string queryKullaniciSil = " delete from Kullanicilar where KullaniciID='" + Convert.ToInt32(txtSilID.Text) + "'";
                    SqlConnection cnnKullaniciSil = new SqlConnection(connectionString);
                    SqlDataAdapter daKullaniciSil = new SqlDataAdapter(queryKullaniciSil, cnnKullaniciSil);
                    DataTable dtKullaniciSil = new DataTable();
                    daKullaniciSil.Fill(dtKullaniciSil);

                    MessageBox.Show("Kullanıcı Silindi");
                    GosterKullanicilar();
                    cnnKullaniciSil.Close();
                }
                catch
                {
                    MessageBox.Show("Hata!");
                }
            }
            else
            {
                MessageBox.Show("Yanlış kullanıcı ID'si");
            }
            cnnKullaniciIDKontrol.Close();
        }
        private void btnKullaniciDuzenle_Click(object sender, EventArgs e)
        {
            if (txtDuzenleID.Text == "")
            {
                txtDuzenleID.Text = "0";
            }

            string queryKullaniciIDKontrol = "select * from Kullanicilar where KullaniciID='" + Convert.ToInt32(txtDuzenleID.Text) + "'";

            SqlConnection cnnKullaniciIDKontrol = new SqlConnection(connectionString);
            cnnKullaniciIDKontrol.Open();
            SqlCommand cmdKullaniciIDKontrol = new SqlCommand(queryKullaniciIDKontrol);
            cmdKullaniciIDKontrol.Connection = cnnKullaniciIDKontrol;
            SqlDataAdapter daKullaniciIDKontrol = new SqlDataAdapter(queryKullaniciIDKontrol, cnnKullaniciIDKontrol);
            SqlDataReader drKullaniciIDKontrol = cmdKullaniciIDKontrol.ExecuteReader();

            if (drKullaniciIDKontrol.Read())
            {
                frmKullaniciDuzenle.KullaniciID = Convert.ToInt32(txtDuzenleID.Text);
                this.Hide();
                frmKullaniciDuzenle.Show();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı ID'si!");
            }
            cnnKullaniciIDKontrol.Close();
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUrunEkle frmUrunEkle = new frmUrunEkle();
            frmUrunEkle.Show();
        }

        private void UrunKaldir_Click(object sender, EventArgs e)
        {
            if (txtKaldirUrun.Text == "")
            {
                txtKaldirUrun.Text = "0";
            }

            string queryUrunKodKontrol = "select * from Urunler where UrunKod='" + Convert.ToInt32(txtKaldirUrun.Text) + "'";

            SqlConnection cnnUrunKodKontrol = new SqlConnection(connectionString);
            cnnUrunKodKontrol.Open();
            SqlCommand cmdUrunKodKontrol = new SqlCommand(queryUrunKodKontrol);
            cmdUrunKodKontrol.Connection = cnnUrunKodKontrol;
            SqlDataAdapter daUrunKodKontrol = new SqlDataAdapter(queryUrunKodKontrol, cnnUrunKodKontrol);
            SqlDataReader drUrunKodKontrol = cmdUrunKodKontrol.ExecuteReader();

            if (drUrunKodKontrol.Read())
            {
                try
                {
                    string queryUrunSil = " delete from Urunler where UrunKod='" + Convert.ToInt32(txtKaldirUrun.Text) + "'";
                    SqlConnection cnnUrunSil = new SqlConnection(connectionString);
                    SqlDataAdapter daUrunSil = new SqlDataAdapter(queryUrunSil, cnnUrunSil);
                    DataTable dtUrunSil = new DataTable();
                    daUrunSil.Fill(dtUrunSil);

                    MessageBox.Show("Ürün kaldırıldı.");
                    GosterUrunler();
                    txtKaldirUrun.Text = "";
                    cnnUrunSil.Close();

            }
                catch
            {
                MessageBox.Show("Hata!");
            }
        }
            else
            {
                MessageBox.Show("Yanlış Ürün Kodu!");
            }
            cnnUrunKodKontrol.Close();
        }

        private void UrunDuzenle_Click(object sender, EventArgs e)
        {
            if (txtUrunDuzenle.Text == "")
            {
                txtUrunDuzenle.Text = "0";
            }

            string queryUrunKodKontrol2 = "select * from Urunler where UrunKod='" + Convert.ToInt32(txtUrunDuzenle.Text) + "'";

            SqlConnection cnnUrunKodKontrol2 = new SqlConnection(connectionString);
            cnnUrunKodKontrol2.Open();
            SqlCommand cmdUrunKodKontrol2 = new SqlCommand(queryUrunKodKontrol2);
            cmdUrunKodKontrol2.Connection = cnnUrunKodKontrol2;
            SqlDataAdapter daUrunKodKontrol2 = new SqlDataAdapter(queryUrunKodKontrol2, cnnUrunKodKontrol2);
            SqlDataReader drUrunKodKontrol2 = cmdUrunKodKontrol2.ExecuteReader();

            if (drUrunKodKontrol2.Read())
            {
                try
                {
                    frmUrunDuzenle.UrunKod = Convert.ToInt32(txtUrunDuzenle.Text);
                    this.Hide();
                    frmUrunDuzenle.Show();
                    GosterUrunler();
                }
                catch
                {
                    MessageBox.Show("Hata!");
                }
            }
            else
            {
                MessageBox.Show("Yanlış Ürün Kodu!");
            }
            cnnUrunKodKontrol2.Close();
        }

        private void btnUrunBilgi_Click(object sender, EventArgs e)
        {
         
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            frmMusteriEkle frmMusteriEkle = new frmMusteriEkle();
            this.Hide();
            frmMusteriEkle.Show();
        }

        private void btnMusteriKaldir_Click(object sender, EventArgs e)
        {
            if (txtMusteriKaldir.Text == "")
            {
                txtMusteriKaldir.Text = "0";
            }

            string queryTCKontrol = "select * from Musteriler where TCKimlikNo='" + txtMusteriKaldir.Text + "'";

            SqlConnection cnnTCKontrol = new SqlConnection(connectionString);
            cnnTCKontrol.Open();
            SqlCommand cmdTCKontrol = new SqlCommand(queryTCKontrol);
            cmdTCKontrol.Connection = cnnTCKontrol;
            SqlDataAdapter daTCKontrol = new SqlDataAdapter(queryTCKontrol, cnnTCKontrol);
            SqlDataReader drTCKontrol = cmdTCKontrol.ExecuteReader();

            if (drTCKontrol.Read())
            {
                try
                {
                    string queryMusteriSil = " Update Musteriler set Aktif=0 where TCKimlikNo='" + txtMusteriKaldir.Text + "' ";
                    SqlConnection cnnMusteriSil = new SqlConnection(connectionString);
                    SqlDataAdapter daMusteriSil = new SqlDataAdapter(queryMusteriSil, cnnMusteriSil);
                    DataTable dtMusteriSil = new DataTable();
                    daMusteriSil.Fill(dtMusteriSil);
                    MessageBox.Show("Kayıt Silindi");
                    GosterMusteriler();
                }
                catch
                {
                    MessageBox.Show("Hata!");
                }
            }
            else
            {
                MessageBox.Show("Hatalı TC Kimlik No!");
            }
            cnnTCKontrol.Close();
        }

        private void btnMusteriDuzenle_Click(object sender, EventArgs e)
        {
            if (txtMusteriDuzenle.Text == "")
            {
                txtMusteriDuzenle.Text = "0";
            }

            string queryTCKontrol = "select * from Musteriler where TCKimlikNo='" + txtMusteriDuzenle.Text + "'";

            SqlConnection cnnTCKontrol = new SqlConnection(connectionString);
            cnnTCKontrol.Open();
            SqlCommand cmdTCKontrol = new SqlCommand(queryTCKontrol);
            cmdTCKontrol.Connection = cnnTCKontrol;
            SqlDataAdapter daTCKontrol = new SqlDataAdapter(queryTCKontrol, cnnTCKontrol);
            SqlDataReader drTCKontrol = cmdTCKontrol.ExecuteReader();

            if (drTCKontrol.Read())
            {
                try
                {
                    frmMusteriDuzenle.TCYeni = txtMusteriDuzenle.Text;
                    this.Hide();
                    frmMusteriDuzenle.Show();
                }
                catch
                {
                    MessageBox.Show("Hata!");
                }
            }
            else
            {
                MessageBox.Show("Hatalı TC Kimlik No!");
            }
            cnnTCKontrol.Close();
        }

        private void btnMusteriGuncelle_Click(object sender, EventArgs e)
        {
            GosterMusteriler();
        }

        private void btnTCKontol_Click(object sender, EventArgs e)
        {
            if (txtMusteriTC.Text == "")
            {
                txtMusteriTC.Text = "0";
            }

            string queryTCKontrol = "select * from Musteriler where TCKimlikNo='" + txtMusteriTC.Text + "'";

            SqlConnection cnnTCKontrol = new SqlConnection(connectionString);
            cnnTCKontrol.Open();
            SqlCommand cmdTCKontrol = new SqlCommand(queryTCKontrol);
            cmdTCKontrol.Connection = cnnTCKontrol;
            SqlDataAdapter daTCKontrol = new SqlDataAdapter(queryTCKontrol, cnnTCKontrol);
            SqlDataReader drTCKontrol = cmdTCKontrol.ExecuteReader();

            if (drTCKontrol.Read())
            {
                MessageBox.Show("Müşteri Kayıtlı");
            }
            else
            {
                MessageBox.Show("Yeni Müşteri");
                this.Hide();
                frmMusteriEkle frmMusteriEkle = new frmMusteriEkle();
                frmMusteriEkle.Show();
                GosterMusteriler();
            }
            cnnTCKontrol.Close();
        }

        private void btnSat_Click(object sender, EventArgs e)
        {
            try
            {
                string queryStokKontrol = " select Adet from stok where UrunKod='" + Convert.ToInt32(txtUrunKod.Text) + "' ";
                SqlConnection cnnStokKontrol = new SqlConnection(connectionString);
                SqlDataAdapter daStokKontrol = new SqlDataAdapter(queryStokKontrol, cnnStokKontrol);
                DataTable dtStokKontrol = new DataTable();
                daStokKontrol.Fill(dtStokKontrol);

                int Adet = Convert.ToInt32(dtStokKontrol.Rows[0][0]);


                if (Adet >= Convert.ToInt32(txtSatisAdet.Text))
                {
                    try
                    {
                        string queryUrunSat = " insert into Satislar(UrunKod,MusteriID,SatisTarih,Adet) values ('" + Convert.ToInt32(txtUrunKod.Text) + "',(select MusteriID from Musteriler where TCKimlikNo='" + txtMusteriTC.Text + "'),GETDATE(),'" + Convert.ToInt32(txtSatisAdet.Text) + "') ";
                        SqlConnection cnnUrunSat = new SqlConnection(connectionString);
                        SqlDataAdapter daUrunSat = new SqlDataAdapter(queryUrunSat, cnnUrunSat);
                        DataTable dtUrunSat = new DataTable();
                        daUrunSat.Fill(dtUrunSat);

                        MessageBox.Show("Satış Yapıldı");
                        GosterUrunler();
                        GosterSatis();
                    }
                    catch
                    {
                        MessageBox.Show("Satış Başarısız!");
                    }
                }
                else
                {
                    MessageBox.Show("Yetersiz Ütün Stoğu!");
                }
                cnnStokKontrol.Close();
            }
            catch
            {
                MessageBox.Show("Hata! Lütfen Bilgileri Kontrol Edin.");
            }
            txtMusteriTC.Text = txtUrunKod.Text = txtSatisAdet.Text = "";

        }

        private void btnStokKontrol_Click(object sender, EventArgs e)
        {
            try
            {
                string queryStokGuncelle4 = "select UrunKod,SiparisAdet from Siparisler where SiparisTeslimTarih<GETDATE() and Aktif=1 ";

                SqlConnection cnnStokGuncelle4 = new SqlConnection(connectionString);
                cnnStokGuncelle4.Open();
                SqlCommand cmdStokGuncelle4 = new SqlCommand(queryStokGuncelle4);
                cmdStokGuncelle4.Connection = cnnStokGuncelle4;
                SqlDataAdapter daStokGuncelle4 = new SqlDataAdapter(queryStokGuncelle4, cnnStokGuncelle4);
                SqlDataReader drStokGuncelle4 = cmdStokGuncelle4.ExecuteReader();

                if (drStokGuncelle4.Read())
                {
                    string queryStokGuncelle = " select UrunKod,SiparisAdet from Siparisler where SiparisTeslimTarih<GETDATE() and Aktif=1 ";
                    SqlConnection cnnStokGuncelle = new SqlConnection(connectionString);
                    SqlDataAdapter daStokGuncelle = new SqlDataAdapter(queryStokGuncelle, cnnStokGuncelle);
                    DataTable dtStokGuncelle = new DataTable();
                    daStokGuncelle.Fill(dtStokGuncelle);

                    int i = 0;
                    for (i = 0; i < dtStokGuncelle.Columns.Count - 1; i++)
                    {
                        //////////////////////////////////////////////////////////////////////////////////////////////////
                        string queryStokGuncelle2 = "update Stok set Adet=Adet+'" + Convert.ToInt32(dtStokGuncelle.Rows[i][1]) + "' where UrunKod='" + Convert.ToInt32(dtStokGuncelle.Rows[i][0]) + "'  ";
                        SqlConnection cnnStokGuncelle2 = new SqlConnection(connectionString);
                        SqlDataAdapter daStokGuncelle2 = new SqlDataAdapter(queryStokGuncelle2, cnnStokGuncelle2);
                        DataTable dtStokGuncelle2 = new DataTable();
                        daStokGuncelle2.Fill(dtStokGuncelle2);
                    }
                    string queryStokGuncelle3 = " update Siparisler set Aktif=0 where SiparisTeslimTarih<GETDATE() and Aktif=1 ";
                    SqlConnection cnnStokGuncelle3 = new SqlConnection(connectionString);
                    SqlDataAdapter daStokGuncelle3 = new SqlDataAdapter(queryStokGuncelle3, cnnStokGuncelle3);
                    DataTable dtStokGuncelle3 = new DataTable();
                    daStokGuncelle3.Fill(dtStokGuncelle3);

                    MessageBox.Show("Stok Güncellendi");
                    GosterUrunler();
                }
                else
                {
                    MessageBox.Show("Teslim Alınmış Sipariş Yok!");
                }

                cnnStokGuncelle4.Close();
            }
            catch
            {
                MessageBox.Show("Hata!");
            }
        }

        private void btnSiparis_Click(object sender, EventArgs e)
        {
            frmSiparisVer frmSiparisVer = new frmSiparisVer();
            this.Hide();
            frmSiparisVer.Show();
        }
        private void btnStokRapolari_Click(object sender, EventArgs e)
        {
            frmStokRapor frmStokRapor = new frmStokRapor();
            this.Hide();
            frmStokRapor.Show();
        }

        private void btnSatisRapor_Click(object sender, EventArgs e)
        {
        }


        private void btnCikis_Click(object sender, EventArgs e)
        {
            frmGiris frmGiris = new frmGiris();
            this.Close();
            frmGiris.Show();
        }

        private void dgwKullanicilar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtUrunKod_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnlKullaniciKontrol_Paint(object sender, PaintEventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmGiris frmGiris = new frmGiris();
            this.Close();
            frmGiris.Show();
        }

        private void pnlStokKontrol_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvMusteriler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmGiris frmGiris = new frmGiris();
            this.Close();
            frmGiris.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmGiris frmGiris = new frmGiris();
            this.Close();
            frmGiris.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmGiris frmGiris = new frmGiris();
            this.Close();
            frmGiris.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmGiris frmGiris = new frmGiris();
            this.Close();
            frmGiris.Show();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
            
        }

        private void tbpgSatis_Click(object sender, EventArgs e)
        {

        }

        private void tbpgStok_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmStokRapor frmStokRapor = new frmStokRapor();
            this.Hide();
            frmStokRapor.Show();
        }

        private void lblSatisUrunKod_Click(object sender, EventArgs e)
        {

        }

        private void txtMusteriTC_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblMusteriTC_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbpgStok_Click_1(object sender, EventArgs e)
        {

        }
    }
}
