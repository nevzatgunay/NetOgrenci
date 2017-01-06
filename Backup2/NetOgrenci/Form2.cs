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
            webBrowser1.Navigate("www.luleburgazmyo.com");

            foreach (Control ctrl in groupBox2.Controls)
            {
                ctrl.MouseHover += new EventHandler(Controls_MouseHover);
                ctrl.MouseLeave += new EventHandler(Controls_MouseLeave);
            }

           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure--;
            int dakika = sure / 60;
            int saniye = sure - dakika * 60;
            lbl_sure.Text = dakika.ToString().PadLeft(2, '0') + ":" + saniye.ToString().PadLeft(2, '0');

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
            webBrowser1.Height = this.Height - groupBox2.Height -60;
            webBrowser1.Width = this.Width - 7;
            lbl_durum.Top = this.Height - lbl_durum.Height - 220;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_lmyo_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.luleburgazmyo.com");
           
        }

        private void btn_luzep_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.luleburgazmyo.com/moodle/");
            
        }

        private void btn_uni_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.kirklareli.edu.tr");
            
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
            
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
        }

        private void lbl_koseli_sol_Click(object sender, EventArgs e)
        {
            SendKeys.Send(lbl_koseli_sol.Text);
        }

        private void lbl_koseli_sag_Click(object sender, EventArgs e)
        {
            SendKeys.Send(lbl_koseli_sag.Text);
        }

        private void lbl_sol_Click(object sender, EventArgs e)
        {
           
        }

        private void lbl_sag_Click(object sender, EventArgs e)
        {
            
        }

        private void lbl_suslu_sol_Click(object sender, EventArgs e)
        {
          
        }

        private void lbl_suslu_sag_Click(object sender, EventArgs e)
        {
            
        }

        private void lbl_kucuktur_Click(object sender, EventArgs e)
        {
            SendKeys.Send(lbl_kucuktur.Text);
        }

        private void lbl_buyuktur_Click(object sender, EventArgs e)
        {
            SendKeys.Send(lbl_buyuktur.Text);
        }

        private void lbl_diyez_Click(object sender, EventArgs e)
        {
            SendKeys.Send(lbl_diyez.Text);
        }

        private void lbl_soru_Click(object sender, EventArgs e)
        {
            SendKeys.Send(lbl_soru.Text);
        }

        private void lbl_ampersand_Click(object sender, EventArgs e)
        {
            SendKeys.Send(lbl_ampersand.Text);
        }

        private void lbl_unlem_Click(object sender, EventArgs e)
        {
            SendKeys.Send(lbl_unlem.Text);
        }

        private void lbl_dolar_Click(object sender, EventArgs e)
        {
            SendKeys.Send(lbl_dolar.Text);
        }

        private void lbl_ters_slaş_Click(object sender, EventArgs e)
        {
            SendKeys.Send(lbl_ters_slaş.Text);
        }

        private void lbl_esittir_Click(object sender, EventArgs e)
        {
            SendKeys.Send(lbl_esittir.Text);
        }

        private void lbl_sıfır_Click(object sender, EventArgs e)
        {
            SendKeys.Send(lbl_sıfır.Text);
        }

        private void lbl_bir_Click(object sender, EventArgs e)
        {
            SendKeys.Send(lbl_bir.Text);
        }

        private void lbl_iki_Click(object sender, EventArgs e)
        {
            SendKeys.Send(lbl_iki.Text);
        }

        private void lbl_uc_Click(object sender, EventArgs e)
        {
            SendKeys.Send(lbl_uc.Text);
        }

        private void lbl_dort_Click(object sender, EventArgs e)
        {
            SendKeys.Send(lbl_dort.Text);
        }

        private void lbl_bes_Click(object sender, EventArgs e)
        {
            SendKeys.Send(lbl_bes.Text);
        }

        private void lbl_alti_Click(object sender, EventArgs e)
        {
            SendKeys.Send(lbl_alti.Text);
        }

        private void lbl_yedi_Click(object sender, EventArgs e)
        {
            SendKeys.Send(lbl_yedi.Text);
        }

        private void lbl_sekiz_Click(object sender, EventArgs e)
        {
            SendKeys.Send(lbl_sekiz.Text);
        }

        private void lbl_dokuz_Click(object sender, EventArgs e)
        {
            SendKeys.Send(lbl_dokuz.Text);
        }

        private void lbl_slaş_Click(object sender, EventArgs e)
        {
            SendKeys.Send(lbl_slaş.Text);
        }

        private void lbl_yıldız_Click(object sender, EventArgs e)
        {
            SendKeys.Send(lbl_yıldız.Text);
        }

        private void lbl_arti_Click(object sender, EventArgs e)
        {
            SendKeys.Send(lbl_arti.Text);
        }

        private void lbl_tire_Click(object sender, EventArgs e)
        {
            SendKeys.Send(lbl_tire.Text);
        }

        private void lbl_a_Click(object sender, EventArgs e)
        {
            SendKeys.Send(lbl_a.Text);
        }

        private void lbl_b_Click(object sender, EventArgs e)
        {
            SendKeys.Send(lbl_b.Text);
        }

        private void lbl_c_Click(object sender, EventArgs e)
        {
            SendKeys.Send(lbl_c.Text);
        }

        private void lbl_ç_Click(object sender, EventArgs e)
        {
            SendKeys.Send(lbl_ç.Text);
        }

        private void lbl_d_Click(object sender, EventArgs e)
        {
            SendKeys.Send(lbl_d.Text);
        }

        private void lbl_e_Click(object sender, EventArgs e)
        {
            SendKeys.Send(lbl_e.Text);
        }

        private void lbl_f_Click(object sender, EventArgs e)
        {
            SendKeys.Send(lbl_f.Text);
        }

        private void lbl_g_Click(object sender, EventArgs e)
        {
            SendKeys.Send(lbl_g.Text);
        }

        private void lbl_ğ_Click(object sender, EventArgs e)
        {
            SendKeys.Send(lbl_ğ.Text);
        }

        private void lbl_h_Click(object sender, EventArgs e)
        {
            SendKeys.Send(lbl_h.Text);
        }

        private void lbl_ı_Click(object sender, EventArgs e)
        {
            SendKeys.Send(lbl_ı.Text);
        }

        private void lbl_i_Click(object sender, EventArgs e)
        {
            SendKeys.Send(lbl_i.Text);
        }

        private void lbl_j_Click(object sender, EventArgs e)
        {
            SendKeys.Send(lbl_j.Text);
        }

        private void lbl_k_Click(object sender, EventArgs e)
        {
            SendKeys.Send(lbl_k.Text);
        }

        private void lbl_l_Click(object sender, EventArgs e)
        {
            SendKeys.Send(lbl_l.Text);
        }

        private void lbl_m_Click(object sender, EventArgs e)
        {
            SendKeys.Send(lbl_m.Text);
        }

        private void lbl_n_Click(object sender, EventArgs e)
        {
            SendKeys.Send(lbl_n.Text);
        }

        private void lbl_o_Click(object sender, EventArgs e)
        {
            SendKeys.Send(lbl_o.Text);
        }

        private void lbl_ö_Click(object sender, EventArgs e)
        {
            SendKeys.Send(lbl_ö.Text);
        }

        private void lbl_p_Click(object sender, EventArgs e)
        {
            SendKeys.Send(lbl_p.Text);
        }

        private void lbl_q_Click(object sender, EventArgs e)
        {
            SendKeys.Send(lbl_q.Text);
        }

        private void lbl_r_Click(object sender, EventArgs e)
        {
            SendKeys.Send(lbl_r.Text);
        }

        private void lbl_s_Click(object sender, EventArgs e)
        {
            SendKeys.Send(lbl_s.Text);
        }

        private void lbl_ş_Click(object sender, EventArgs e)
        {
            SendKeys.Send(lbl_ş.Text);
        }

        private void lbl_t_Click(object sender, EventArgs e)
        {
            SendKeys.Send(lbl_t.Text);
        }

        private void lbl_u_Click(object sender, EventArgs e)
        {
            SendKeys.Send(lbl_u.Text);
        }

        private void lbl_ü_Click(object sender, EventArgs e)
        {
            SendKeys.Send(lbl_ü.Text);
        }

        private void lbl_w_Click(object sender, EventArgs e)
        {
            SendKeys.Send(lbl_w.Text);
        }

        private void lbl_v_Click(object sender, EventArgs e)
        {
            SendKeys.Send(lbl_v.Text);
        }

        private void lbl_y_Click(object sender, EventArgs e)
        {
            SendKeys.Send(lbl_y.Text);
        }

        private void lbl_x_Click(object sender, EventArgs e)
        {
            SendKeys.Send(lbl_x.Text);
        }

        private void lbl_z_Click(object sender, EventArgs e)
        {
            SendKeys.Send(lbl_z.Text);
        }

        private void lbl_nokta_Click(object sender, EventArgs e)
        {
            SendKeys.Send(lbl_nokta.Text);
        }

        private void lbl_ikinokta_Click(object sender, EventArgs e)
        {
            SendKeys.Send(lbl_ikinokta.Text);
        }

        private void lbl_cizgi_Click(object sender, EventArgs e)
        {
            SendKeys.Send(lbl_cizgi.Text);
        }

        private void lbl_alttire_Click(object sender, EventArgs e)
        {
            SendKeys.Send(lbl_alttire.Text);
        }

        private void lbl_tırnak_Click(object sender, EventArgs e)
        {
            SendKeys.Send(lbl_tırnak.Text);
        }

        private void label24_Click(object sender, EventArgs e)
        {
            SendKeys.Send("  ");
        }

        private void label15_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{BACKSPACE}");
        }

        private void lbl_enter_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{ENTER}");
        }

        private void label33_Click(object sender, EventArgs e)
        {
            if (lbl_a.Text == "a")
            {
                lbl_a.Text = "A";
                lbl_b.Text = "B";
                lbl_c.Text = "C";
                lbl_ç.Text = "Ç";
                lbl_d.Text = "D";
                lbl_e.Text = "E";
                lbl_f.Text = "F";
                lbl_g.Text = "G";
                lbl_ğ.Text = "Ğ";
                lbl_h.Text = "H";
                lbl_ı.Text = "I";
                lbl_i.Text = "İ";
                lbl_j.Text = "J";
                lbl_k.Text = "K";
                lbl_l.Text = "L";
                lbl_m.Text = "M";
                lbl_n.Text = "N";
                lbl_o.Text = "O";
                lbl_ö.Text = "Ö";
                lbl_p.Text = "P";
                lbl_q.Text = "Q";
                lbl_r.Text = "R";
                lbl_s.Text = "S";
                lbl_ş.Text = "Ş";
                lbl_t.Text = "T";
                lbl_u.Text = "U";
                lbl_ü.Text = "Ü";
                lbl_w.Text = "W";
                lbl_v.Text = "V";
                lbl_y.Text = "Y";
                lbl_x.Text = "X";
                lbl_z.Text = "Z";            
            
            }
            else if (lbl_a.Text == "A")
            {
                lbl_a.Text = "a";
                lbl_b.Text = "b";
                lbl_c.Text = "c";
                lbl_ç.Text = "ç";
                lbl_d.Text = "d";
                lbl_e.Text = "e";
                lbl_f.Text = "f";
                lbl_g.Text = "g";
                lbl_ğ.Text = "ğ";
                lbl_h.Text = "h";
                lbl_ı.Text = "ı";
                lbl_i.Text = "i";
                lbl_j.Text = "j";
                lbl_k.Text = "k";
                lbl_l.Text = "l";
                lbl_m.Text = "m";
                lbl_n.Text = "n";
                lbl_o.Text = "o";
                lbl_ö.Text = "ö";
                lbl_p.Text = "p";
                lbl_q.Text = "q";
                lbl_r.Text = "r";
                lbl_s.Text = "s";
                lbl_ş.Text = "ş";
                lbl_t.Text = "t";
                lbl_u.Text = "u";
                lbl_ü.Text = "ü";
                lbl_w.Text = "w";
                lbl_v.Text = "v";
                lbl_y.Text = "y";
                lbl_x.Text = "x";
                lbl_z.Text = "z"; 
            }
        }

        private void Form2_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                return ;
        }

        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            lbl_durum.Text = webBrowser1.StatusText;
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            txt_adres.Text = e.Url.AbsoluteUri.ToString();
            lbl_durum.Text = webBrowser1.StatusText;
        }

        private void lbl_virgul_Click(object sender, EventArgs e)
        {
            SendKeys.Send(lbl_virgul.Text);
        }

        private void lbl_noktali_virgul_Click(object sender, EventArgs e)
        {
            SendKeys.Send(lbl_noktali_virgul.Text);
        }

        private void webBrowser1_NewWindow(object sender, CancelEventArgs e)
        {
            webBrowser1.Navigate(webBrowser1.StatusText);
            e.Cancel=true;
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            lbl_durum.Text = webBrowser1.StatusText;
        }

        void Controls_MouseLeave(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            ctrl.ForeColor = Color.Black;

        }

        void Controls_MouseHover(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            ctrl.ForeColor = Color.Red;
        }





       




        

    }
}
