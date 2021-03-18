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
    public partial class frmStokRapor : Form
    {
        public frmStokRapor()
        {
            InitializeComponent();
        }

        private void frmStokRapor_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection StokFull = new SqlConnection();
                StokFull.ConnectionString = @"Data Source=DESKTOP-MND6GP9;Initial Catalog=Eczane;Integrated Security=True";
                SqlCommand komutStokFull = new SqlCommand();
                komutStokFull.CommandText = "SELECT UrunAd FROM Urunler";
                komutStokFull.Connection = StokFull;
                komutStokFull.CommandType = CommandType.Text;

                SqlDataReader dr;
                StokFull.Open();
                dr = komutStokFull.ExecuteReader();
                while (dr.Read())
                {
                    cBoxUrunAd.Items.Add(dr["UrunAd"]);
                }
                StokFull.Close();
            }
            catch
            {
                MessageBox.Show("Hata!");
            }
        }

        private void cBoxUrunTur_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection StokFull = new SqlConnection();
            StokFull.ConnectionString = @"Data Source=DESKTOP-789A4S9\SQLEXPRESS;Initial Catalog=ECZANE;Integrated Security=True";
            try
            {
                cBoxUrunAd.Items.Clear();

                if (cBoxUrunTur.Text == "Ağız-Diş Bakımı")
                {
                    SqlCommand komutStokFull = new SqlCommand();
                    komutStokFull.CommandText = "SELECT UrunAd FROM Urunler where UrunTur='Ağız-Diş Bakımı'";
                    komutStokFull.Connection = StokFull;
                    komutStokFull.CommandType = CommandType.Text;

                    SqlDataReader dr;
                    StokFull.Open();
                    dr = komutStokFull.ExecuteReader();
                    while (dr.Read())
                    {
                        cBoxUrunAd.Items.Add(dr["UrunAd"]);
                    }
                    StokFull.Close();
                }
                else if (cBoxUrunTur.Text == "Bebek Ürünleri")
                {
                    SqlCommand komutStokFull = new SqlCommand();
                    komutStokFull.CommandText = "SELECT UrunAd FROM Urunler where UrunTur='Bebek Ürünleri'";
                    komutStokFull.Connection = StokFull;
                    komutStokFull.CommandType = CommandType.Text;

                    SqlDataReader dr;
                    StokFull.Open();
                    dr = komutStokFull.ExecuteReader();
                    while (dr.Read())
                    {
                        cBoxUrunAd.Items.Add(dr["UrunAd"]);
                    }
                    StokFull.Close();
                }
                else if (cBoxUrunTur.Text == "Saç Bakımı")
                {
                    SqlCommand komutStokFull = new SqlCommand();
                    komutStokFull.CommandText = "SELECT UrunAd FROM Urunler where UrunTur='Saç Bakımı'";
                    komutStokFull.Connection = StokFull;
                    komutStokFull.CommandType = CommandType.Text;

                    SqlDataReader dr;
                    StokFull.Open();
                    dr = komutStokFull.ExecuteReader();
                    while (dr.Read())
                    {
                        cBoxUrunAd.Items.Add(dr["UrunAd"]);
                    }
                    StokFull.Close();
                }
                else if (cBoxUrunTur.Text == "Vitamin-Sağlık")
                {
                    SqlCommand komutStokFull = new SqlCommand();
                    komutStokFull.CommandText = "SELECT UrunAd FROM Urunler where UrunTur='Vitamin-Sağlık'";
                    komutStokFull.Connection = StokFull;
                    komutStokFull.CommandType = CommandType.Text;

                    SqlDataReader dr;
                    StokFull.Open();
                    dr = komutStokFull.ExecuteReader();
                    while (dr.Read())
                    {
                        cBoxUrunAd.Items.Add(dr["UrunAd"]);
                    }
                    StokFull.Close();
                }
                else if (cBoxUrunTur.Text == "İaçlar")
                {
                    SqlCommand komutStokFull = new SqlCommand();
                    komutStokFull.CommandText = "SELECT UrunAd FROM Urunler where UrunTur='İaçlar'";
                    komutStokFull.Connection = StokFull;
                    komutStokFull.CommandType = CommandType.Text;

                    SqlDataReader dr;
                    StokFull.Open();
                    dr = komutStokFull.ExecuteReader();
                    while (dr.Read())
                    {
                        cBoxUrunAd.Items.Add(dr["UrunAd"]);
                    }
                    StokFull.Close();
                }
                else
                {
                    SqlCommand komutStokFull = new SqlCommand();
                    komutStokFull.CommandText = "SELECT UrunAd FROM Urunler";
                    komutStokFull.Connection = StokFull;
                    komutStokFull.CommandType = CommandType.Text;

                    SqlDataReader dr;
                    StokFull.Open();
                    dr = komutStokFull.ExecuteReader();
                    while (dr.Read())
                    {
                        cBoxUrunAd.Items.Add(dr["UrunAd"]);
                    }
                    StokFull.Close();
                }

            }
            catch
            {
                MessageBox.Show("Hata");
            }
        }
        string connectionString = @"Data Source=DESKTOP-789A4S9\SQLEXPRESS;Initial Catalog=ECZANE;Integrated Security=True";
        private void btnGoster_Click(object sender, EventArgs e)
        {
            try
            {
                string queryKalan = " Select Adet from Stok where UrunKod=(Select UrunKod from Urunler where UrunAd='" + cBoxUrunAd.Text + "')";
                SqlConnection cnnKalan = new SqlConnection(connectionString);
                SqlDataAdapter daKalan = new SqlDataAdapter(queryKalan, cnnKalan);
                DataTable dtKalan = new DataTable();
                daKalan.Fill(dtKalan);

                lblStoktaKalanAdet.Text = dtKalan.Rows[0][0].ToString();

            }
            catch
            {
                MessageBox.Show("Hata!");
            }
        }

        private void btnKalanModelGoster_Click(object sender, EventArgs e)
        {
            SqlConnection StokFull = new SqlConnection();
            StokFull.ConnectionString = @"Data Source=DESKTOP-789A4S9\SQLEXPRESS;Initial Catalog=ECZANE;Integrated Security=True";
            try
            {
                lBoxKalanModel.Items.Clear();

                if (cBoxKalanModel.Text == "Ağız-Diş Bakımı")
                {
                    SqlCommand komutStokFull = new SqlCommand();
                    komutStokFull.CommandText = "exec sp_KalanUrunTur 'Ağız-Diş Bakımı'";
                    komutStokFull.Connection = StokFull;
                    komutStokFull.CommandType = CommandType.Text;

                    SqlDataReader dr;
                    StokFull.Open();
                    dr = komutStokFull.ExecuteReader();
                    while (dr.Read())
                    {
                        lBoxKalanModel.Items.Add(dr[0]+"    "+dr[1].ToString());
                    }
                    StokFull.Close();
                }
                else if (cBoxKalanModel.Text == "Bebek Ürünleri")
                {
                    SqlCommand komutStokFull = new SqlCommand();
                    komutStokFull.CommandText = "exec sp_KalanUrunTur 'Bebek Ürünleri' ";
                    komutStokFull.Connection = StokFull;
                    komutStokFull.CommandType = CommandType.Text;

                    SqlDataReader dr;
                    StokFull.Open();
                    dr = komutStokFull.ExecuteReader();
                    while (dr.Read())
                    {
                        lBoxKalanModel.Items.Add(dr[0] + "    " + dr[1].ToString());
                    }
                    StokFull.Close();
                }
                else if (cBoxKalanModel.Text == "Saç Bakımı")
                {
                    SqlCommand komutStokFull = new SqlCommand();
                    komutStokFull.CommandText = "exec sp_KalanUrunTur 'Saç Bakımı'";
                    komutStokFull.Connection = StokFull;
                    komutStokFull.CommandType = CommandType.Text;

                    SqlDataReader dr;
                    StokFull.Open();
                    dr = komutStokFull.ExecuteReader();
                    while (dr.Read())
                    {
                        lBoxKalanModel.Items.Add(dr[0] + "    " + dr[1].ToString());
                    }
                    StokFull.Close();
                }
                else if (cBoxKalanModel.Text == "Vitamin-Sağlık")
                {
                    SqlCommand komutStokFull = new SqlCommand();
                    komutStokFull.CommandText = "exec sp_KalanUrunTur 'Vitamin-Sağlık'";
                    komutStokFull.Connection = StokFull;
                    komutStokFull.CommandType = CommandType.Text;

                    SqlDataReader dr;
                    StokFull.Open();
                    dr = komutStokFull.ExecuteReader();
                    while (dr.Read())
                    {
                        lBoxKalanModel.Items.Add(dr[0] + "    " + dr[1].ToString());
                    }
                    StokFull.Close();
                }
                else if (cBoxKalanModel.Text == "İlaçlar")
                {
                    SqlCommand komutStokFull = new SqlCommand();
                    komutStokFull.CommandText = "exec sp_KalanUrunTur 'İlaçlar'";
                    komutStokFull.Connection = StokFull;
                    komutStokFull.CommandType = CommandType.Text;

                    SqlDataReader dr;
                    StokFull.Open();
                    dr = komutStokFull.ExecuteReader();
                    while (dr.Read())
                    {
                        lBoxKalanModel.Items.Add(dr[0] + "    " + dr[1].ToString());
                    }
                    StokFull.Close();
                }
                else
                {
                    SqlCommand komutStokFull = new SqlCommand();
                    komutStokFull.CommandText = "SELECT UrunAd FROM Urunler";
                    komutStokFull.Connection = StokFull;
                    komutStokFull.CommandType = CommandType.Text;

                    SqlDataReader dr;
                    StokFull.Open();
                    dr = komutStokFull.ExecuteReader();
                    while (dr.Read())
                    {
                        lBoxKalanModel.Items.Add(dr[0] + "    " + dr[1].ToString());
                    }
                    StokFull.Close();
                }

            }
            catch
            {
                MessageBox.Show("Hata");
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            frmAna frmAna = new frmAna();
            this.Close();
            frmAna.Show();
        }

        private void cBoxUrunTur_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void cBoxUrunAd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblUrunAd_Click(object sender, EventArgs e)
        {

        }

        private void lblStoktaKalan_Click(object sender, EventArgs e)
        {

        }
    }
}
