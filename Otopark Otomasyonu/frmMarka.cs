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
    public partial class frmMarka : Form
    {
        public frmMarka()
        {
            InitializeComponent();
        }
        SqlConnection db = new SqlConnection("Data Source=ENES\\SQLEXPRESS;Initial Catalog=AracOtopark;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            db.Open();
            SqlCommand komut = new SqlCommand("insert into marka_bilgi(marka) values('" + textBox1.Text + "')",db);
            komut.ExecuteNonQuery();
            db.Close();
            MessageBox.Show("Marka Eklendi");
            textBox1.Clear(); 
        }

        private void frmMarka_Load(object sender, EventArgs e)
        {

        }
    }
}
