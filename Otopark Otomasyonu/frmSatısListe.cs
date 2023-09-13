using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otopark_Otomasyonu
{
    public partial class frmSatısListe : Form
    {
        public frmSatısListe()
        {
            InitializeComponent();
        }

        SqlConnection db = new SqlConnection("Data Source=ENES\\SQLEXPRESS;Initial Catalog=AracOtopark;Integrated Security=True");
        DataSet ds = new DataSet();

        private void frmSatısListe_Load(object sender, EventArgs e)
        {
            SatislariListele();
            Hesapla();
        }

        private void Hesapla()
        {
            db.Open();
            SqlCommand komut = new SqlCommand("select sum(tutar) from satis", db);
            label1.Text = "Brüt Tutar--> " + komut.ExecuteScalar() + " Tl";
            SqlCommand komut2 = new SqlCommand("select sum(net_tutar) from satis", db);
            label2.Text = "Net Tutar--> " + komut2.ExecuteScalar() + " Tl";
            SqlCommand komut3 = new SqlCommand("select sum(iskonto) from satis", db);
            label3.Text = "İskonto Tutar--> " + komut3.ExecuteScalar() + " Tl";
            db.Close();
        }

        private void SatislariListele()
        {
            db.Open();
            SqlDataAdapter adptr = new SqlDataAdapter("select*from satis", db);
            adptr.Fill(ds, "satis");
            dataGridView1.DataSource = ds.Tables["satis"];
            db.Close();
        }
    }
}
