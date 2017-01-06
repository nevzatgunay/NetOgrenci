namespace NetOgrenci
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbl_saat = new System.Windows.Forms.Label();
            this.tmr_saat = new System.Windows.Forms.Timer(this.components);
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.txt_ogrenci = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lbl_kullanım = new System.Windows.Forms.Label();
            this.lbl_hakkında = new System.Windows.Forms.Label();
            this.tmr_kapat = new System.Windows.Forms.Timer(this.components);
            this.lbl_mesaj = new System.Windows.Forms.Label();
            this.lbl_yedi = new System.Windows.Forms.Label();
            this.lbl_sekiz = new System.Windows.Forms.Label();
            this.lbl_dokuz = new System.Windows.Forms.Label();
            this.lbl_dort = new System.Windows.Forms.Label();
            this.lbl_bes = new System.Windows.Forms.Label();
            this.lbl_alti = new System.Windows.Forms.Label();
            this.lbl_bir = new System.Windows.Forms.Label();
            this.lbl_iki = new System.Windows.Forms.Label();
            this.lbl_uc = new System.Windows.Forms.Label();
            this.lbl_sil = new System.Windows.Forms.Label();
            this.lbl_gir = new System.Windows.Forms.Label();
            this.lbl_sıfır = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 195);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(365, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "NetÖğrenci Sistemine Hoş Geldiniz";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(445, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(264, 103);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dateTimePicker1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePicker1.Location = new System.Drawing.Point(393, 163);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(344, 40);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.TabStop = false;
            // 
            // lbl_saat
            // 
            this.lbl_saat.AutoSize = true;
            this.lbl_saat.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_saat.Location = new System.Drawing.Point(508, 253);
            this.lbl_saat.Name = "lbl_saat";
            this.lbl_saat.Size = new System.Drawing.Size(0, 33);
            this.lbl_saat.TabIndex = 3;
            // 
            // tmr_saat
            // 
            this.tmr_saat.Enabled = true;
            this.tmr_saat.Interval = 1000;
            // 
            // webBrowser1
            // 
            this.webBrowser1.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser1.Location = new System.Drawing.Point(122, 374);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScrollBarsEnabled = false;
            this.webBrowser1.Size = new System.Drawing.Size(601, 374);
            this.webBrowser1.TabIndex = 5;
            this.webBrowser1.Url = new System.Uri("", System.UriKind.Relative);
            this.webBrowser1.NewWindow += new System.ComponentModel.CancelEventHandler(this.webBrowser1_NewWindow);
            // 
            // txt_ogrenci
            // 
            this.txt_ogrenci.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ogrenci.Location = new System.Drawing.Point(514, 210);
            this.txt_ogrenci.MaxLength = 11;
            this.txt_ogrenci.Name = "txt_ogrenci";
            this.txt_ogrenci.Size = new System.Drawing.Size(223, 40);
            this.txt_ogrenci.TabIndex = 6;
            this.txt_ogrenci.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_ogrenci.TextChanged += new System.EventHandler(this.txt_ogrenci_TextChanged);
            this.txt_ogrenci.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_ogrenci_KeyDown);
            this.txt_ogrenci.Leave += new System.EventHandler(this.txt_ogrenci_Leave);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(953, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(187, 195);
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // lbl_kullanım
            // 
            this.lbl_kullanım.AutoSize = true;
            this.lbl_kullanım.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kullanım.Location = new System.Drawing.Point(12, 833);
            this.lbl_kullanım.Name = "lbl_kullanım";
            this.lbl_kullanım.Size = new System.Drawing.Size(69, 19);
            this.lbl_kullanım.TabIndex = 8;
            this.lbl_kullanım.Text = "Kullanım";
            this.lbl_kullanım.Click += new System.EventHandler(this.lbl_kullanım_Click);
            // 
            // lbl_hakkında
            // 
            this.lbl_hakkında.AutoSize = true;
            this.lbl_hakkında.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_hakkında.Location = new System.Drawing.Point(91, 833);
            this.lbl_hakkında.Name = "lbl_hakkında";
            this.lbl_hakkında.Size = new System.Drawing.Size(73, 19);
            this.lbl_hakkında.TabIndex = 8;
            this.lbl_hakkında.Text = "Hakkında";
            this.lbl_hakkında.Click += new System.EventHandler(this.lbl_hakkında_Click);
            // 
            // tmr_kapat
            // 
            this.tmr_kapat.Enabled = true;
            this.tmr_kapat.Interval = 1000;
            this.tmr_kapat.Tick += new System.EventHandler(this.tmr_kapat_Tick);
            // 
            // lbl_mesaj
            // 
            this.lbl_mesaj.AutoSize = true;
            this.lbl_mesaj.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_mesaj.ForeColor = System.Drawing.Color.Red;
            this.lbl_mesaj.Location = new System.Drawing.Point(388, 298);
            this.lbl_mesaj.Name = "lbl_mesaj";
            this.lbl_mesaj.Size = new System.Drawing.Size(65, 26);
            this.lbl_mesaj.TabIndex = 9;
            this.lbl_mesaj.Text = "label2";
            // 
            // lbl_yedi
            // 
            this.lbl_yedi.AutoSize = true;
            this.lbl_yedi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_yedi.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_yedi.Location = new System.Drawing.Point(922, 405);
            this.lbl_yedi.Name = "lbl_yedi";
            this.lbl_yedi.Size = new System.Drawing.Size(36, 42);
            this.lbl_yedi.TabIndex = 10;
            this.lbl_yedi.Text = "7";
            this.lbl_yedi.Click += new System.EventHandler(this.lbl_yedi_Click);
            // 
            // lbl_sekiz
            // 
            this.lbl_sekiz.AutoSize = true;
            this.lbl_sekiz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_sekiz.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sekiz.Location = new System.Drawing.Point(971, 405);
            this.lbl_sekiz.Name = "lbl_sekiz";
            this.lbl_sekiz.Size = new System.Drawing.Size(36, 42);
            this.lbl_sekiz.TabIndex = 11;
            this.lbl_sekiz.Text = "8";
            this.lbl_sekiz.Click += new System.EventHandler(this.lbl_sekiz_Click);
            // 
            // lbl_dokuz
            // 
            this.lbl_dokuz.AutoSize = true;
            this.lbl_dokuz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_dokuz.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_dokuz.Location = new System.Drawing.Point(1016, 405);
            this.lbl_dokuz.Name = "lbl_dokuz";
            this.lbl_dokuz.Size = new System.Drawing.Size(36, 42);
            this.lbl_dokuz.TabIndex = 12;
            this.lbl_dokuz.Text = "9";
            this.lbl_dokuz.Click += new System.EventHandler(this.lbl_dokuz_Click);
            // 
            // lbl_dort
            // 
            this.lbl_dort.AutoSize = true;
            this.lbl_dort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_dort.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_dort.Location = new System.Drawing.Point(922, 455);
            this.lbl_dort.Name = "lbl_dort";
            this.lbl_dort.Size = new System.Drawing.Size(36, 42);
            this.lbl_dort.TabIndex = 13;
            this.lbl_dort.Text = "4";
            this.lbl_dort.Click += new System.EventHandler(this.lbl_dort_Click);
            // 
            // lbl_bes
            // 
            this.lbl_bes.AutoSize = true;
            this.lbl_bes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_bes.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_bes.Location = new System.Drawing.Point(971, 455);
            this.lbl_bes.Name = "lbl_bes";
            this.lbl_bes.Size = new System.Drawing.Size(36, 42);
            this.lbl_bes.TabIndex = 14;
            this.lbl_bes.Text = "5";
            this.lbl_bes.Click += new System.EventHandler(this.lbl_bes_Click);
            // 
            // lbl_alti
            // 
            this.lbl_alti.AutoSize = true;
            this.lbl_alti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_alti.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_alti.Location = new System.Drawing.Point(1016, 455);
            this.lbl_alti.Name = "lbl_alti";
            this.lbl_alti.Size = new System.Drawing.Size(36, 42);
            this.lbl_alti.TabIndex = 15;
            this.lbl_alti.Text = "6";
            this.lbl_alti.Click += new System.EventHandler(this.lbl_alti_Click);
            // 
            // lbl_bir
            // 
            this.lbl_bir.AutoSize = true;
            this.lbl_bir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_bir.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_bir.Location = new System.Drawing.Point(922, 506);
            this.lbl_bir.Name = "lbl_bir";
            this.lbl_bir.Size = new System.Drawing.Size(36, 42);
            this.lbl_bir.TabIndex = 16;
            this.lbl_bir.Text = "1";
            this.lbl_bir.Click += new System.EventHandler(this.lbl_bir_Click);
            // 
            // lbl_iki
            // 
            this.lbl_iki.AutoSize = true;
            this.lbl_iki.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_iki.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_iki.Location = new System.Drawing.Point(971, 506);
            this.lbl_iki.Name = "lbl_iki";
            this.lbl_iki.Size = new System.Drawing.Size(36, 42);
            this.lbl_iki.TabIndex = 17;
            this.lbl_iki.Text = "2";
            this.lbl_iki.Click += new System.EventHandler(this.lbl_iki_Click);
            // 
            // lbl_uc
            // 
            this.lbl_uc.AutoSize = true;
            this.lbl_uc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_uc.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_uc.Location = new System.Drawing.Point(1016, 506);
            this.lbl_uc.Name = "lbl_uc";
            this.lbl_uc.Size = new System.Drawing.Size(36, 42);
            this.lbl_uc.TabIndex = 18;
            this.lbl_uc.Text = "3";
            this.lbl_uc.Click += new System.EventHandler(this.lbl_uc_Click);
            // 
            // lbl_sil
            // 
            this.lbl_sil.AutoSize = true;
            this.lbl_sil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_sil.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sil.Location = new System.Drawing.Point(911, 556);
            this.lbl_sil.Name = "lbl_sil";
            this.lbl_sil.Size = new System.Drawing.Size(53, 42);
            this.lbl_sil.TabIndex = 19;
            this.lbl_sil.Text = "Sil";
            this.lbl_sil.Click += new System.EventHandler(this.lbl_sil_Click);
            // 
            // lbl_gir
            // 
            this.lbl_gir.AutoSize = true;
            this.lbl_gir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_gir.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_gir.Location = new System.Drawing.Point(1016, 556);
            this.lbl_gir.Name = "lbl_gir";
            this.lbl_gir.Size = new System.Drawing.Size(61, 42);
            this.lbl_gir.TabIndex = 20;
            this.lbl_gir.Text = "Gir";
            this.lbl_gir.Click += new System.EventHandler(this.lbl_gir_Click);
            // 
            // lbl_sıfır
            // 
            this.lbl_sıfır.AutoSize = true;
            this.lbl_sıfır.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_sıfır.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sıfır.Location = new System.Drawing.Point(971, 556);
            this.lbl_sıfır.Name = "lbl_sıfır";
            this.lbl_sıfır.Size = new System.Drawing.Size(36, 42);
            this.lbl_sıfır.TabIndex = 21;
            this.lbl_sıfır.Text = "0";
            this.lbl_sıfır.Click += new System.EventHandler(this.lbl_sıfır_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(906, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 39);
            this.label2.TabIndex = 22;
            this.label2.Text = "Numaratör";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(390, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 42);
            this.label3.TabIndex = 23;
            this.label3.Text = "T.C No:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1152, 864);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_sıfır);
            this.Controls.Add(this.lbl_gir);
            this.Controls.Add(this.lbl_sil);
            this.Controls.Add(this.lbl_uc);
            this.Controls.Add(this.lbl_iki);
            this.Controls.Add(this.lbl_bir);
            this.Controls.Add(this.lbl_alti);
            this.Controls.Add(this.lbl_bes);
            this.Controls.Add(this.lbl_dort);
            this.Controls.Add(this.lbl_dokuz);
            this.Controls.Add(this.lbl_sekiz);
            this.Controls.Add(this.lbl_yedi);
            this.Controls.Add(this.lbl_mesaj);
            this.Controls.Add(this.lbl_hakkında);
            this.Controls.Add(this.lbl_kullanım);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.txt_ogrenci);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.lbl_saat);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NetÖğrenci";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbl_saat;
        private System.Windows.Forms.WebBrowser webBrowser1;
        public System.Windows.Forms.TextBox txt_ogrenci;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lbl_kullanım;
        private System.Windows.Forms.Label lbl_hakkında;
        private System.Windows.Forms.Timer tmr_kapat;
        private System.Windows.Forms.Label lbl_mesaj;
        private System.Windows.Forms.Label lbl_yedi;
        private System.Windows.Forms.Label lbl_sekiz;
        private System.Windows.Forms.Label lbl_dokuz;
        private System.Windows.Forms.Label lbl_dort;
        private System.Windows.Forms.Label lbl_bes;
        private System.Windows.Forms.Label lbl_alti;
        private System.Windows.Forms.Label lbl_bir;
        private System.Windows.Forms.Label lbl_iki;
        private System.Windows.Forms.Label lbl_uc;
        private System.Windows.Forms.Label lbl_sil;
        private System.Windows.Forms.Label lbl_gir;
        private System.Windows.Forms.Label lbl_sıfır;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;


    }
}

