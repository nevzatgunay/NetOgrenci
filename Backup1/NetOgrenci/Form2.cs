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
            txt_adres.Focus();
            webBrowser1.Navigate("www.luleburgazmyo.com");
            txt_adres.Text = "www.luleburgazmyo.com";
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
            groupBox2.Top = this.Height - groupBox2.Height - 15;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_lmyo_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.luleburgazmyo.com");
            txt_adres.Text = "www.luleburgazmyo.com";
        }

        private void btn_luzep_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.luleburgazmyo.com/moodle/");
            txt_adres.Text = "www.luleburgazmyo.com/moodle/";
        }

        private void btn_uni_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.kirklareli.edu.tr");
            txt_adres.Text = "www.kirklareli.edu.tr";
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
            txt_adres.Text = webBrowser1.GoBack().ToString();
        }

        private void btn_git_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(txt_adres.Text);
        }

        private void btn_ileri_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void btn_dur_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void btn_yenile_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                return;
        }

        private void btn_google_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.google.com.tr");
            txt_adres.Text = "www.google.com.tr";
        }


        private void label7_Click(object sender, EventArgs e)
        {
            SendKeys.Send(lbl_q.Text);
        }

        private void lbl_w_Click(object sender, EventArgs e)
        {
            SendKeys.Send(lbl_w".Text);
        }

    }
}
