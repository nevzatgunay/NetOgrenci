using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace NetOgrenci
{
    public partial class Form2 : Form
    {
        public string tc;
        int sure=1200;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection();
            baglanti.ConnectionString = "Provider=Microsoft.Jet.OleDb.4.0;Data Source=okul.mdb";
            OleDbCommand komut = new OleDbCommand();
            komut.CommandText = "Select * from ogrenciler where T_C_KimlikNo=" + tc;
            komut.Connection = baglanti;


            
            baglanti.Open();
            OleDbDataReader oku = komut.ExecuteReader();

            if (oku.Read())
            {
                lbl_ogr_no.Text = oku[0].ToString();
                lbl_ad.Text = oku[1].ToString();
                lbl_soyad.Text = oku[2].ToString();
                lbl_bolum.Text = oku[3].ToString();
                lbl_sinif.Text = oku[9].ToString();
                pictureBox1.Image = new Bitmap("resim\\"+tc + ".jpg"); 

            }
            oku.Close();
            baglanti.Close();

            timer1.Start();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure--;
            int dakika = sure / 60;
            int saniye = sure - dakika * 60;
            lbl_sure.Text = dakika.ToString() + ":" + saniye.ToString();

            if (sure < 60)
                lbl_sure.ForeColor = Color.Red;

            if (sure == 0)
            {
                this.Close();
            }
        }

        private void Form2_Resize(object sender, EventArgs e)
        {
            groupBox1.Top = this.Height - groupBox1.Height-15;
        }
    }
}
