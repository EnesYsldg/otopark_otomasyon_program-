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
    public partial class frmOtoKayıt : Form
    {
        public frmOtoKayıt()
        {
            InitializeComponent();
        }

        SqlConnection db = new SqlConnection("Data Source=ENES\\SQLEXPRESS;Initial Catalog=AracOtopark;Integrated Security=True");
        private void frmOtoKayıt_Load(object sender, EventArgs e)
        {
            BosAraclar();

            Marka();
        }

        private void Marka()
        {
            db.Open();
            SqlCommand komut = new SqlCommand("select marka from marka_bilgi", db);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                cmbMarka.Items.Add(read["marka"].ToString());
            }
            db.Close();
        }

        private void BosAraclar()
        {
            db.Open();
            SqlCommand komut = new SqlCommand("select*from arac_durumu where durum='bos'", db);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                cmbParkYeri.Items.Add(read["parkyeri"].ToString());
            }
            db.Close();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            db.Open();
            SqlCommand komut = new SqlCommand("insert into arac_otopark_kaydı(tc,ad,soyad,telefon,email,plaka,marka,seri,parkyeri,tarih) values(@tc,@ad,@soyad,@telefon,@email,@plaka,@marka,@seri,@parkyeri,@tarih)", db);

            komut.Parameters.AddWithValue("@tc", txtTc.Text);
            komut.Parameters.AddWithValue("@ad", txtAd.Text);
            komut.Parameters.AddWithValue("@soyad", txtSoyad.Text);
            komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            komut.Parameters.AddWithValue("@email", txtMail.Text);
            komut.Parameters.AddWithValue("@plaka", txtPlaka.Text);
            komut.Parameters.AddWithValue("@marka", cmbMarka.Text);
            komut.Parameters.AddWithValue("@seri", cmbSeri.Text);
            komut.Parameters.AddWithValue("@renk", txtRenk.Text);
            komut.Parameters.AddWithValue("@parkyeri", cmbParkYeri.Text);
            komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());

            komut.ExecuteNonQuery();
            SqlCommand komut2 = new SqlCommand("update arac_durumu set durum='dolu' where parkyeri='"+cmbParkYeri.SelectedItem+ "' ", db);
            komut2.ExecuteNonQuery(); 
            db.Close();
            MessageBox.Show("Araç Kaydı Oluşturuldu", " Kayıt");
            cmbParkYeri.Items.Clear();
            BosAraclar();
            cmbMarka.Items.Clear();
            Marka();
            cmbSeri.Items.Clear();

            foreach(Control item in grpKisi.Controls)
            {
                if(item is TextBox)
                {
                    item.Text = "";
                }
            }

            foreach (Control item in grpArac.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }

            foreach (Control item in grpArac.Controls)
            {
                if (item is ComboBox)
                {
                    item.Text = "";
                }
            }
        }

        private void BtnMarka_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnSeri_Click(object sender, EventArgs e)
        {
            
        }

        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbSeri.Items.Clear();
            db.Open();
            SqlCommand komut = new SqlCommand("select marka,seri from seri_bilgi where marka='"+cmbMarka.SelectedItem+"'", db);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                cmbSeri.Items.Add(read["seri"].ToString());
            }
            db.Close();
        }

        private void BtnMarka_Click_1(object sender, EventArgs e)
        {
            frmMarka marka = new frmMarka();
            marka.ShowDialog();
        }

        private void BtnSeri_Click_1(object sender, EventArgs e)
        {
            frmSeri seri = new frmSeri();
            seri.ShowDialog();
        }

        
    }
}
