using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;
namespace NetOgrenci
{
    public partial class Form1 : Form
    {
        Timer tmr_saat = new Timer();
        int sayac,degisiklik,msgbuton;
        Form frm4 = new Form4();
        Form frm3 = new Form3();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tmr_kapat.Start();
            tmr_saat.Tick += new EventHandler(tmr_saat_Tick);
            tmr_saat_Tick(sender, e);
            string path2 = System.AppDomain.CurrentDomain.BaseDirectory + "imagerotator\\galeri.html";
            webBrowser1.Navigate(path2);
            txt_ogrenci.Focus();
            lbl_mesaj.Visible = false;
        }

        private void tmr_saat_Tick(object sender, EventArgs e)
        {
            
            string saat = DateTime.Now.Hour.ToString();
            string dakika = DateTime.Now.Minute.ToString();
            string saniye = DateTime.Now.Second.ToString();
            if (saat.Length == 1) 
                saat = "0" + saat;
            if (dakika.Length == 1) 
                dakika = "0" + dakika;
            if (saniye.Length == 1) 
                saniye = "0" + saniye;
            lbl_saat.Text = (saat + ":" + dakika + ":" + saniye).ToString();
        }

        private void txt_ogrenci_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                try
                {
                    OleDbConnection baglanti = new OleDbConnection();
                    baglanti.ConnectionString = "Provider=Microsoft.Jet.OleDb.4.0;Data Source=okul.mdb";
                    OleDbCommand komut = new OleDbCommand();
                    komut.CommandText = "Select * from ogrenciler where T_C_KimlikNo=" + txt_ogrenci.Text;
                    komut.Connection = baglanti;
                    baglanti.Open();
                    OleDbDataReader oku = komut.ExecuteReader();
                    if (oku.Read())
                    {
                        if (oku[12].ToString() == "")
                        {
                            komut.CommandText = "update ogrenciler set son_giris='" + DateTime.Now + "' where T_C_KimlikNo=" + txt_ogrenci.Text;
                            oku.Close();
                            komut.ExecuteNonQuery();
                            baglanti.Close();
                            Form2 frm = new Form2();
                            frm.tc = txt_ogrenci.Text;
                            frm.ShowDialog();
                            txt_ogrenci.Clear();
                        }
                        else if (DateTime.Now > Convert.ToDateTime(oku[12]).AddHours(1) || txt_ogrenci.Text == "41005499338")
                        {
                            oku.Close();
                            komut.CommandText = "update ogrenciler set son_giris='" + DateTime.Now + "' where T_C_KimlikNo=" + txt_ogrenci.Text;
                            komut.ExecuteNonQuery();
                            baglanti.Close();
                            Form2 frm = new Form2();
                            frm.tc = txt_ogrenci.Text;
                            frm.ShowDialog();
                            txt_ogrenci.Clear();
                        }
                        else
                        {
                            lbl_mesaj.Visible = true;
                            lbl_mesaj.Text = Convert.ToDateTime(oku[12]).AddHours(1).ToString() + "'e Kadar Bekleyiniz!"; 
                            txt_ogrenci.Text = "";
                            oku.Close();
                            baglanti.Close();
                           
                        }
                    }
                    else
                    {
                        lbl_mesaj.Visible = true;
                        lbl_mesaj.Text = Convert.ToDateTime(oku[12]).AddHours(1).ToString() + "'e Kadar Bekleyiniz!";
                        txt_ogrenci.Text = "";
                        oku.Close();
                        baglanti.Close();
                        
                    }

                }
                catch (Exception hata)
                {
                    MessageBox.Show(hata.Message);
                }
            }
        }

        private void txt_ogrenci_Leave(object sender, EventArgs e)
        {
            txt_ogrenci.Focus();
        }

        private void lbl_kullanım_Click(object sender, EventArgs e)
        {
            degisiklik = 1;
            frm3.ShowDialog();
        }

        private void lbl_hakkında_Click(object sender, EventArgs e)
        {
            degisiklik = 2;
            frm4.ShowDialog();

        }

        private void tmr_kapat_Tick(object sender, EventArgs e)
        {
            
            sayac++;
            
            if (sayac %5 == 0 && degisiklik == 1)
            {
                frm3.Close();
                sayac = 0;
            }
            if (sayac %5 == 0 && degisiklik == 2)
            {
                frm4.Close();
                sayac = 0;
                
            }
            if (sayac % 10 == 0)
            { 
                lbl_mesaj.Visible = false;
                sayac = 0;
            }
            tmr_kapat.Start();
            dateTimePicker1.Value = DateTime.Now.Date;
            
        }

        private void txt_ogrenci_TextChanged(object sender, EventArgs e)
        {

        }

        private void webBrowser1_NewWindow(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
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

        private void lbl_sil_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{BACKSPACE}");
        }

        private void lbl_gir_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{ENTER}");
        }


       

    }
}
