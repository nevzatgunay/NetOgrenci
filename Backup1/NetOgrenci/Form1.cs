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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tmr_saat.Tick += new EventHandler(tmr_saat_Tick);
            tmr_saat_Tick(sender, e);
            string path2 = System.AppDomain.CurrentDomain.BaseDirectory + "imagerotator\\galeri.html";
            webBrowser1.Navigate(path2);
            txt_ogrenci.Focus();
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
                OleDbConnection baglanti = new OleDbConnection();
                baglanti.ConnectionString = "Provider=Microsoft.Jet.OleDb.4.0;Data Source=okul.mdb";
                OleDbCommand komut = new OleDbCommand();
                komut.CommandText="Select * from ogrenciler where T_C_KimlikNo=" + txt_ogrenci.Text;
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
                    else if (DateTime.Now > Convert.ToDateTime(oku[12]).AddHours(1))
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
                        MessageBox.Show(Convert.ToDateTime(oku[12]).AddHours(1).ToString() + "'e Kadar Bekleyiniz!","Bilgi");
                        txt_ogrenci.Text = "";
                        oku.Close();
                        baglanti.Close();
                    }
                }
                else
                {
                    MessageBox.Show(Convert.ToDateTime(oku[12]).AddHours(1).ToString() + "'e Kadar Bekleyiniz!","Bilgi");
                    txt_ogrenci.Text = "";
                    oku.Close();
                    baglanti.Close();
                }

                
                

            }
        }

        private void txt_ogrenci_Leave(object sender, EventArgs e)
        {
            txt_ogrenci.Focus();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
                this.Close();

            
            
        }

        private void txt_ogrenci_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_kullanım_Click(object sender, EventArgs e)
        {
            Form frm3 = new Form3();
            frm3.ShowDialog();
        }

        private void lbl_hakkında_Click(object sender, EventArgs e)
        {
            Form frm4 = new Form4();
            frm4.ShowDialog();
        }

       

    }
}
