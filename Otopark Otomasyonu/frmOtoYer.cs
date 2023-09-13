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

namespace Otopark_Otomasyonu
{
    public partial class frmOtoYer : Form
    {
        public frmOtoYer()
        {
            InitializeComponent();
        }

        SqlConnection db = new SqlConnection("Data Source=ENES\\SQLEXPRESS;Initial Catalog=AracOtopark;Integrated Security=True");
        private void frmOtoYer_Load(object sender, EventArgs e)
        {
            BosParkYer();
            DoluParkYer();

            db.Open();
            SqlCommand komut = new SqlCommand("select*from arac_otopark_kaydı", db);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                foreach (Control item in Controls)
                {
                    if (item is Button)
                    {
                        if (item.Text == read["parkyeri"].ToString())
                        {
                            item.Text = read["plaka"].ToString(); 
                        }
                    }
                }
            }
            db.Close();
           
        }

        private void DoluParkYer()
        {
            db.Open();
            SqlCommand komut = new SqlCommand("select*from arac_durumu", db);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                foreach (Control item in Controls)
                {
                    if (item is Button)
                    {
                        if (item.Text == read["parkyeri"].ToString() && read["durum"].ToString() == "dolu")
                        {
                            item.BackColor = Color.Red;
                        }
                    }
                }
            }
            db.Close();
        }

        private void BosParkYer()
        {
            int sayac = 1;
            foreach (Control item in Controls)
            {
                if (item is Button)
                {
                    item.Text = "P-" + sayac;
                    item.Name = "P-" + sayac;
                    sayac++;
                }
            }
        }
    }
}
