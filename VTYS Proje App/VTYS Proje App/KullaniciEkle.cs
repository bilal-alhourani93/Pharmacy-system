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
using System.Xml;
using System.Xml.Linq;

namespace VTYS_Proje_App
{
    public partial class frmKullaniciEkle : Form
    {
        public frmKullaniciEkle()
        {
            InitializeComponent();
        }

        /*void yukle()
        {
            XmlDocument i = new XmlDocument();
            DataSet ds = new DataSet();
            //xml dosyamızı okumak için bir reader oluşturuyoruz.
            XmlReader xmlFile;
            xmlFile = XmlReader.Create(@"veri.xml", new XmlReaderSettings());
            //içeriği Dataset e aktarıyoruz.
            ds.ReadXml(xmlFile);
            //datagridviewin kaynağı olarak dataseti gösteriyoruz.
            dataGridView1.DataSource = ds.Tables[0];
            xmlFile.Close();
        }*/
        string connectionString = @"Data Source=DESKTOP-789A4S9\SQLEXPRESS;Initial Catalog=ECZANE;Integrated Security=True";

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

            if (drKullaniciAdiKontrol.Read())
            {
                MessageBox.Show("Mevcut kullanıcı!");
            }
            else
            {
                try
                {
                    string queryKaydet = " insert into Kullanicilar values ('" + txtKullaniciAdi.Text + "','" + txtSifre.Text + "','" + txtAd.Text + "','" + txtSoyad.Text + "' ,'" + dudYetki.Text + "')";
                    SqlConnection cnnKaydet = new SqlConnection(connectionString);
                    SqlDataAdapter daKaydet = new SqlDataAdapter(queryKaydet, cnnKaydet);
                    DataTable dtKaydet = new DataTable();
                    daKaydet.Fill(dtKaydet);
                    MessageBox.Show("Kayıt başarılı");
                    this.Close();
                    frmAna frmAna = new frmAna();
                    frmAna.Show();
                }
                catch
                {
                    MessageBox.Show("Kayıt başarısız.Lütfen bilgileri kontrol ediniz.");
                }
            }
            
        }

        private void frmKullaniciEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
