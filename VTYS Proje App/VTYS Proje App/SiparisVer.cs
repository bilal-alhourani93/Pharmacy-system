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
    public partial class frmSiparisVer : Form
    {
        public frmSiparisVer()
        {
            InitializeComponent();
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            frmAna frmAna = new frmAna();
            this.Close();
            frmAna.Show();
        }
        string connectionString = @"Data Source=DESKTOP-789A4S9\SQLEXPRESS;Initial Catalog=ECZANE;Integrated Security=True";

        private void btnSiparis_Click(object sender, EventArgs e)
        {
            try
            {
                string querySiparisVer = "insert into Siparisler (UrunKod,SiparisAdet,SiparisTeslimTarih) values('" + Convert.ToInt32(txtUrunKod.Text) + "','" + Convert.ToInt32(txtAdet.Text) + "','" + dtpSiparisTeslim.Value.ToString("yyyy-MM-dd") + "')";
                SqlConnection cnnSiparisVer = new SqlConnection(connectionString);
                SqlDataAdapter daSiparisVer = new SqlDataAdapter(querySiparisVer, cnnSiparisVer);
                DataTable dtSiparisVer = new DataTable();
                daSiparisVer.Fill(dtSiparisVer);

                MessageBox.Show("Sipariş Verildi.");

                this.Close();
                frmAna frmAna = new frmAna();
                frmAna.Show();
            }
            catch
            {
                MessageBox.Show("Hata");
            }
        }

        private void frmSiparisVer_Load(object sender, EventArgs e)
        {

        }
    }
}
