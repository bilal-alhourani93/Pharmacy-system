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

    public partial class frmGiris : Form
    {
        frmAna frmAna = new frmAna();
        public frmGiris()
        {
            InitializeComponent();
        }
        string connectionString = @"Data Source=DESKTOP-789A4S9\SQLEXPRESS;Initial Catalog=ECZANE;Integrated Security=True";

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string queryKullanici = "select * from Kullanicilar where KullaniciAd='" + txtKullaniciAdi.Text + "' and Sifre='" + txtSifre.Text + "'";

            SqlConnection cnnKullanici = new SqlConnection(connectionString);
            cnnKullanici.Open();
            SqlCommand cmdKullanici = new SqlCommand(queryKullanici);
            cmdKullanici.Connection = cnnKullanici;
            SqlDataAdapter daKullanici = new SqlDataAdapter(queryKullanici, cnnKullanici);
            SqlDataReader drKullanici = cmdKullanici.ExecuteReader();

            if (drKullanici.Read())
            {
                cnnKullanici.Close();
                DataTable dtKullanici = new DataTable();
                daKullanici.Fill(dtKullanici);

                frmAna.Yetki = dtKullanici.Rows[0][5].ToString();
                frmAna.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre hatalı!");
            }
            cnnKullanici.Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yöneticiye başvurunuz.");
        }

        private void frmGiris_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void lblKullaniciAdi_Click(object sender, EventArgs e)
        {

        }

        private void frmGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
