﻿using System;
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
    public partial class frmSeri : Form
    {
        public frmSeri()
        {
            InitializeComponent();
        }

        SqlConnection db = new SqlConnection("Data Source=ENES\\SQLEXPRESS;Initial Catalog=AracOtopark;Integrated Security=True");

        private void frmSeri_Load(object sender, EventArgs e)
        {
            Marka();
        }

        private void Marka()
        {
            db.Open();
            SqlCommand komut = new SqlCommand("select marka from marka_bilgi", db);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboBox1.Items.Add(read["marka"].ToString());
            }
            db.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.Open();
            SqlCommand komut = new SqlCommand("insert into seri_bilgi(marka,seri) values('" + comboBox1.Text + "','" + textBox1.Text + "')", db);
            komut.ExecuteNonQuery();
            db.Close();
            MessageBox.Show("Markaya bağlı model eklendi");
            textBox1.Clear();
            comboBox1.Text = "";
            comboBox1.Items.Clear();
        }
    }
}
