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
    public partial class frmAracCıkıs : Form
    {
        public frmAracCıkıs()
        {
            InitializeComponent();
        }


        SqlConnection db = new SqlConnection("Data Source=ENES\\SQLEXPRESS;Initial Catalog=AracOtopark;Integrated Security=True");
        private void frmAracCıkıs_Load(object sender, EventArgs e)
        {
            DoluYerler();

            Plakalar();

            timer1.Enabled = true;
        }

        private void Plakalar()
        {
            db.Open();
            SqlCommand komut = new SqlCommand("select*from arac_otopark_kaydı ", db);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                cmbPlaka.Items.Add(read["plaka"].ToString());
            }
            db.Close();
        }

        private void DoluYerler()
        {
            db.Open();
            SqlCommand komut = new SqlCommand("select*from arac_durumu where durum='dolu'", db);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                cmbParkYeri.Items.Add(read["parkyeri"].ToString());
            }
            db.Close();
        }

        private void cmbPlaka_SelectedIndexChanged(object sender, EventArgs e)
        {
            db.Open();
            SqlCommand komut = new SqlCommand("select*from arac_otopark_kaydı where plaka= '"+cmbPlaka.SelectedItem+"'", db);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtParkYeri.Text = read["parkyeri"].ToString();
            }
            db.Close();
        }

        private void cmbParkYeri_SelectedIndexChanged(object sender, EventArgs e)
        {
            db.Open();
            SqlCommand komut = new SqlCommand("select*from arac_otopark_kaydı where parkyeri= '" + cmbParkYeri.SelectedItem + "'", db);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtParkYeri2.Text = read["parkyeri"].ToString();
                txtTC.Text = read["tc"].ToString();
                txtAd.Text = read["ad"].ToString();
                txtSoyad.Text = read["soyad"].ToString();
                txtMarka.Text = read["marka"].ToString();
                txtSeri.Text = read["seri"].ToString();
                txtPlaka.Text = read["plaka"].ToString();
                lblGirisTarihi.Text = read["tarih"].ToString();
            }
            db.Close();

            
            DateTime giris, cıkıs;
            giris = DateTime.Parse(lblGirisTarihi.Text);
            cıkıs = DateTime.Parse(lblCıkısTarihi.Text);
            
            TimeSpan fark;
            fark = cıkıs - giris;
            lblSure.Text = fark.TotalHours.ToString("0.00");
            lblTutar.Text = (double.Parse(lblSure.Text) * (120)).ToString();
            
        }

        private void btnAracCıkıs_Click(object sender, EventArgs e)
        {
            db.Open();
            SqlCommand komut = new SqlCommand("delete from arac_otopark_kaydı where plaka='"+txtPlaka.Text+"'", db);
            komut.ExecuteNonQuery();
            SqlCommand komut2= new SqlCommand("update arac_durumu set durum='bos' where parkyeri='" + txtParkYeri2.Text + "'", db);
            komut2.ExecuteNonQuery();
            SqlCommand komut3 = new SqlCommand("insert into satis(parkyeri,plaka,giris_tarihi,cikis_tarihi,sure,tutar,iskonto,net_tutar) values(@parkyeri,@plaka,@giris_tarihi,@cikis_tarihi,@sure,@tutar,@iskonto,@net_tutar)", db);

            if (txtİskonto.Text == "" || txtİskonto.Text == null)
            {
                txtİskonto.Text = "0";
            }

            komut3.Parameters.AddWithValue("@parkyeri",txtParkYeri2.Text);
            komut3.Parameters.AddWithValue("@plaka", txtPlaka.Text);
            komut3.Parameters.AddWithValue("@giris_tarihi", lblGirisTarihi.Text);
            komut3.Parameters.AddWithValue("@cikis_tarihi", lblCıkısTarihi.Text);
            komut3.Parameters.AddWithValue("@sure", double.Parse(lblSure.Text));
            komut3.Parameters.AddWithValue("@tutar", double.Parse(lblTutar.Text));
            komut3.Parameters.AddWithValue("@iskonto", double.Parse(txtİskonto.Text));
            komut3.Parameters.AddWithValue("@net_tutar", double.Parse(lblNetTutar.Text));

            komut3.ExecuteNonQuery();

            db.Close();
            MessageBox.Show("Araç Çıkışı Yapıldı");
            foreach(Control item in groupBox1.Controls)
            {
                if(item is TextBox)
                {
                    item.Text = "";
                    txtParkYeri.Text = "";
                    cmbParkYeri.Text = "";
                    cmbPlaka.Text = "";
                }
            }
            cmbPlaka.Items.Clear();
            cmbParkYeri.Items.Clear();
            DoluYerler();
            Plakalar();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblCıkısTarihi.Text = DateTime.Now.ToString();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            frmAnaSayfa iptal = new frmAnaSayfa();
            iptal.ShowDialog();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            hesapla();
        }
        private void hesapla()
        {
            if (txtİskonto.Text == "")
            {
                lblNetTutar.Text = (double.Parse(lblTutar.Text) - 0).ToString();
            }
            else
            {
                double iskonto;
                iskonto = double.Parse(txtİskonto.Text);
                lblNetTutar.Text = (double.Parse(lblTutar.Text) - double.Parse(txtİskonto.Text)).ToString();
            }
        }

    }
}
