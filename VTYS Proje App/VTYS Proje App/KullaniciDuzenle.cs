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

namespace VTYS_Proje_App
{
    public partial class frmKullaniciDuzenle : Form
    {
        public frmKullaniciDuzenle()
        {
            InitializeComponent();
        }
        public int KullaniciID = 0;

        string connectionString = @"Data Source=DESKTOP-789A4S9\SQLEXPRESS;Initial Catalog=ECZANE;Integrated Security=True";

        private void frmKullaniciDuzenle_Load(object sender, EventArgs e)
        {
            string queryKullaniciDuzenle = "select * from Kullanicilar where KullaniciID='" + KullaniciID + "'";
            SqlConnection cnnKullaniciDuzenle = new SqlConnection(connectionString);
            cnnKullaniciDuzenle.Open();
            SqlCommand cmdKullaniciDuzenle = new SqlCommand(queryKullaniciDuzenle);
            cmdKullaniciDuzenle.Connection = cnnKullaniciDuzenle;
            SqlDataAdapter daKullaniciDuzenle = new SqlDataAdapter(queryKullaniciDuzenle, cnnKullaniciDuzenle);
            SqlDataReader drKullaniciDuzenle = cmdKullaniciDuzenle.ExecuteReader();

            if (drKullaniciDuzenle.Read())
            {
                string queryKullaniciDuzenle2 = "select KullaniciAd,Sifre,Ad,SoyAd,Yetki from Kullanicilar where KullaniciID='" + KullaniciID + "'";
                SqlConnection cnnKullaniciDuzenle2 = new SqlConnection(connectionString);
                SqlDataAdapter daKullaniciDuzenle2 = new SqlDataAdapter(queryKullaniciDuzenle2, cnnKullaniciDuzenle2);
                DataTable dtKullaniciDuzenle2 = new DataTable();
                daKullaniciDuzenle2.Fill(dtKullaniciDuzenle2);

                txtKullaniciAdi.Text=dtKullaniciDuzenle2.Rows[0][0].ToString();
                txtSifre.Text = dtKullaniciDuzenle2.Rows[0][1].ToString();
                txtAd.Text = dtKullaniciDuzenle2.Rows[0][2].ToString();
                txtSoyad.Text = dtKullaniciDuzenle2.Rows[0][3].ToString();
                dudYetki.Text = dtKullaniciDuzenle2.Rows[0][4].ToString(); 
            }
            else
            {
                MessageBox.Show("Hatalı Kullanici ID'si!");
            }
            
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAna frmAna = new frmAna();
            frmAna.Show();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string queryKullaniciAdiKontrol = "select * from Kullanicilar where KullaniciAd='" + txtKullaniciAdi.Text + "'";

            SqlConnection cnnKullaniciAdiKontrol = new SqlConnection(connectionString);
            cnnKullaniciAdiKontrol.Open();
            SqlCommand cmdKullaniciAdiKontrol = new SqlCommand(queryKullaniciAdiKontrol);
            cmdKullaniciAdiKontrol.Connection = cnnKullaniciAdiKontrol;
            SqlDataAdapter daKullaniciAdiKontrol = new SqlDataAdapter(queryKullaniciAdiKontrol, cnnKullaniciAdiKontrol);
            SqlDataReader drKullaniciAdiKontrol = cmdKullaniciAdiKontrol.ExecuteReader();

            string EskiKullaniciAdi = txtKullaniciAdi.Text;

            if(txtKullaniciAdi.Text!=EskiKullaniciAdi)
            {
                if (drKullaniciAdiKontrol.Read())
                {
                    MessageBox.Show("Mevcut kullanıcı!");
                }
                else
                {
                    try
                    {
                        string queryKaydet = " update Kullanicilar set KullaniciAd='" + txtKullaniciAdi.Text + "', Sifre='" + txtSifre.Text + "', Ad='" + txtAd.Text + "', SoyAd='" + txtSoyad.Text + "', Yetki='" + dudYetki.Text + "' where KullaniciID='" + KullaniciID + "' ";
                        SqlConnection cnnKaydet = new SqlConnection(connectionString);
                        SqlDataAdapter daKaydet = new SqlDataAdapter(queryKaydet, cnnKaydet);
                        DataTable dtKaydet = new DataTable();
                        daKaydet.Fill(dtKaydet);
                        MessageBox.Show("Güncelleme başarılı");
                        this.Close();
                        frmAna frmAna = new frmAna();
                        frmAna.Show();
                    }
                    catch
                    {
                        MessageBox.Show("Güncelleme başarısız.Lütfen bilgileri kontrol ediniz.");
                    }
                }
            }
            else
            {
                try
                {
                    string queryKaydet = " update Kullanicilar set KullaniciAd='" + txtKullaniciAdi.Text + "', Sifre='" + txtSifre.Text + "', Ad='" + txtAd.Text + "', SoyAd='" + txtSoyad.Text + "', Yetki='" + dudYetki.Text + "' where KullaniciID='" + KullaniciID + "' ";
                    SqlConnection cnnKaydet = new SqlConnection(connectionString);
                    SqlDataAdapter daKaydet = new SqlDataAdapter(queryKaydet, cnnKaydet);
                    DataTable dtKaydet = new DataTable();
                    daKaydet.Fill(dtKaydet);
                    MessageBox.Show("Güncelleme başarılı");
                    this.Close();
                    frmAna frmAna = new frmAna();
                    frmAna.Show();
                }
                catch
                {
                    MessageBox.Show("Güncelleme başarısız.Lütfen bilgileri kontrol ediniz.");
                }
            }
        }
    }
}
