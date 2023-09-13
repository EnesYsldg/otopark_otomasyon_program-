
namespace Otopark_Otomasyonu
{
    partial class frmAnaSayfa
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnaSayfa));
            this.btnAracKayıt = new System.Windows.Forms.Button();
            this.btnAracYer = new System.Windows.Forms.Button();
            this.btnAracCıkıs = new System.Windows.Forms.Button();
            this.btnCıkıs = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSatısListe = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAracKayıt
            // 
            this.btnAracKayıt.BackColor = System.Drawing.Color.Yellow;
            this.btnAracKayıt.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAracKayıt.Location = new System.Drawing.Point(356, 76);
            this.btnAracKayıt.Name = "btnAracKayıt";
            this.btnAracKayıt.Size = new System.Drawing.Size(328, 40);
            this.btnAracKayıt.TabIndex = 0;
            this.btnAracKayıt.Text = "Araç Otopark Kayıt Sayfası";
            this.btnAracKayıt.UseVisualStyleBackColor = false;
            this.btnAracKayıt.Click += new System.EventHandler(this.btnAracKayıt_Click);
            // 
            // btnAracYer
            // 
            this.btnAracYer.BackColor = System.Drawing.Color.YellowGreen;
            this.btnAracYer.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAracYer.Location = new System.Drawing.Point(356, 134);
            this.btnAracYer.Name = "btnAracYer";
            this.btnAracYer.Size = new System.Drawing.Size(328, 40);
            this.btnAracYer.TabIndex = 1;
            this.btnAracYer.Text = "Araç Otopark Yerleri";
            this.btnAracYer.UseVisualStyleBackColor = false;
            this.btnAracYer.Click += new System.EventHandler(this.btnAracYer_Click);
            // 
            // btnAracCıkıs
            // 
            this.btnAracCıkıs.BackColor = System.Drawing.Color.Ivory;
            this.btnAracCıkıs.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAracCıkıs.Location = new System.Drawing.Point(356, 190);
            this.btnAracCıkıs.Name = "btnAracCıkıs";
            this.btnAracCıkıs.Size = new System.Drawing.Size(328, 40);
            this.btnAracCıkıs.TabIndex = 2;
            this.btnAracCıkıs.Text = "Araç Otopark Çıkış Sayfası";
            this.btnAracCıkıs.UseVisualStyleBackColor = false;
            this.btnAracCıkıs.Click += new System.EventHandler(this.btnAracCıkıs_Click);
            // 
            // btnCıkıs
            // 
            this.btnCıkıs.BackColor = System.Drawing.Color.Red;
            this.btnCıkıs.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCıkıs.Location = new System.Drawing.Point(356, 315);
            this.btnCıkıs.Name = "btnCıkıs";
            this.btnCıkıs.Size = new System.Drawing.Size(328, 40);
            this.btnCıkıs.TabIndex = 3;
            this.btnCıkıs.Text = "Çıkış";
            this.btnCıkıs.UseVisualStyleBackColor = false;
            this.btnCıkıs.Click += new System.EventHandler(this.btnCıkıs_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(332, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "OTOPARK KONTROL SİSTEMİ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSatısListe
            // 
            this.btnSatısListe.BackColor = System.Drawing.Color.LightBlue;
            this.btnSatısListe.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSatısListe.Location = new System.Drawing.Point(356, 252);
            this.btnSatısListe.Name = "btnSatısListe";
            this.btnSatısListe.Size = new System.Drawing.Size(328, 40);
            this.btnSatısListe.TabIndex = 6;
            this.btnSatısListe.Text = "Satış Listeleme Sayfası";
            this.btnSatısListe.UseVisualStyleBackColor = false;
            this.btnSatısListe.Click += new System.EventHandler(this.btnSatısListe_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 381);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // frmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(731, 405);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSatısListe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCıkıs);
            this.Controls.Add(this.btnAracCıkıs);
            this.Controls.Add(this.btnAracYer);
            this.Controls.Add(this.btnAracKayıt);
            this.Font = new System.Drawing.Font("Monotype Corsiva", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "frmAnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Otopark Otomasyonu Ana Sayfa";
            this.Load += new System.EventHandler(this.frmAnaSayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAracKayıt;
        private System.Windows.Forms.Button btnAracYer;
        private System.Windows.Forms.Button btnAracCıkıs;
        private System.Windows.Forms.Button btnCıkıs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSatısListe;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

