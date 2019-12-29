namespace MusteriKontrol
{
    partial class Panel
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cmbTcList = new System.Windows.Forms.ComboBox();
            this.btnMusteriKaldir = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbpaket = new System.Windows.Forms.ComboBox();
            this.dtTaahut = new System.Windows.Forms.DateTimePicker();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cmbPaketListe = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnPaketKaldir = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPaketFiyat = new System.Windows.Forms.TextBox();
            this.txtPaketAd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnPaketEkle = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnMusteriListele = new System.Windows.Forms.Button();
            this.dgMusteriler = new System.Windows.Forms.DataGridView();
            this.TC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Taahut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMusteriler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paketBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(359, 471);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cmbTcList);
            this.tabPage1.Controls.Add(this.btnMusteriKaldir);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.cmbpaket);
            this.tabPage1.Controls.Add(this.dtTaahut);
            this.tabPage1.Controls.Add(this.btnEkle);
            this.tabPage1.Controls.Add(this.txtTelefon);
            this.tabPage1.Controls.Add(this.txtAdres);
            this.tabPage1.Controls.Add(this.txtAd);
            this.tabPage1.Controls.Add(this.txtTc);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(351, 445);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Müşteri Ekle";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cmbTcList
            // 
            this.cmbTcList.FormattingEnabled = true;
            this.cmbTcList.Location = new System.Drawing.Point(54, 357);
            this.cmbTcList.Name = "cmbTcList";
            this.cmbTcList.Size = new System.Drawing.Size(229, 21);
            this.cmbTcList.TabIndex = 21;
            // 
            // btnMusteriKaldir
            // 
            this.btnMusteriKaldir.Location = new System.Drawing.Point(12, 384);
            this.btnMusteriKaldir.Name = "btnMusteriKaldir";
            this.btnMusteriKaldir.Size = new System.Drawing.Size(335, 53);
            this.btnMusteriKaldir.TabIndex = 20;
            this.btnMusteriKaldir.Text = "Seçili TC\'li Müşteriyi Kaldır!";
            this.btnMusteriKaldir.UseVisualStyleBackColor = true;
            this.btnMusteriKaldir.Click += new System.EventHandler(this.btnMusteriKaldir_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(5, 294);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(343, 42);
            this.label12.TabIndex = 19;
            this.label12.Text = "MÜŞTERİ KALDIR";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(24, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(303, 42);
            this.label10.TabIndex = 18;
            this.label10.Text = "MÜŞTERİ EKLE";
            // 
            // cmbpaket
            // 
            this.cmbpaket.FormattingEnabled = true;
            this.cmbpaket.Location = new System.Drawing.Point(140, 163);
            this.cmbpaket.Name = "cmbpaket";
            this.cmbpaket.Size = new System.Drawing.Size(171, 21);
            this.cmbpaket.TabIndex = 14;
            // 
            // dtTaahut
            // 
            this.dtTaahut.Location = new System.Drawing.Point(140, 196);
            this.dtTaahut.Name = "dtTaahut";
            this.dtTaahut.Size = new System.Drawing.Size(171, 20);
            this.dtTaahut.TabIndex = 13;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(42, 233);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(269, 45);
            this.btnEkle.TabIndex = 12;
            this.btnEkle.Text = "Müşteriyi Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(140, 137);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(171, 20);
            this.txtTelefon.TabIndex = 9;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(140, 112);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(171, 20);
            this.txtAdres.TabIndex = 8;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(140, 89);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(171, 20);
            this.txtAd.TabIndex = 7;
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(140, 66);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(171, 20);
            this.txtTc.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Taahüt Bitiş";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Paket: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefon: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Adres: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC: ";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cmbPaketListe);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.btnPaketKaldir);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.txtPaketFiyat);
            this.tabPage2.Controls.Add(this.txtPaketAd);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.btnPaketEkle);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(351, 445);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Paket Ekle";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cmbPaketListe
            // 
            this.cmbPaketListe.FormattingEnabled = true;
            this.cmbPaketListe.Location = new System.Drawing.Point(96, 299);
            this.cmbPaketListe.Name = "cmbPaketListe";
            this.cmbPaketListe.Size = new System.Drawing.Size(172, 21);
            this.cmbPaketListe.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(32, 223);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(297, 42);
            this.label9.TabIndex = 17;
            this.label9.Text = "PAKET KALDIR";
            // 
            // btnPaketKaldir
            // 
            this.btnPaketKaldir.Location = new System.Drawing.Point(10, 351);
            this.btnPaketKaldir.Name = "btnPaketKaldir";
            this.btnPaketKaldir.Size = new System.Drawing.Size(335, 53);
            this.btnPaketKaldir.TabIndex = 12;
            this.btnPaketKaldir.Text = "Seçili Paketi Kaldır";
            this.btnPaketKaldir.UseVisualStyleBackColor = true;
            this.btnPaketKaldir.Click += new System.EventHandler(this.btnPaketKaldir_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(55, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(257, 42);
            this.label11.TabIndex = 11;
            this.label11.Text = "PAKET EKLE";
            // 
            // txtPaketFiyat
            // 
            this.txtPaketFiyat.Location = new System.Drawing.Point(124, 92);
            this.txtPaketFiyat.Name = "txtPaketFiyat";
            this.txtPaketFiyat.Size = new System.Drawing.Size(163, 20);
            this.txtPaketFiyat.TabIndex = 4;
            // 
            // txtPaketAd
            // 
            this.txtPaketAd.Location = new System.Drawing.Point(124, 68);
            this.txtPaketAd.Name = "txtPaketAd";
            this.txtPaketAd.Size = new System.Drawing.Size(163, 20);
            this.txtPaketAd.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(54, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Paket Fiyatı: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Paket Adı: ";
            // 
            // btnPaketEkle
            // 
            this.btnPaketEkle.Location = new System.Drawing.Point(10, 133);
            this.btnPaketEkle.Name = "btnPaketEkle";
            this.btnPaketEkle.Size = new System.Drawing.Size(335, 53);
            this.btnPaketEkle.TabIndex = 0;
            this.btnPaketEkle.Text = "Paketi Ekle";
            this.btnPaketEkle.UseVisualStyleBackColor = true;
            this.btnPaketEkle.Click += new System.EventHandler(this.btnPaketEkle_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnMusteriListele);
            this.tabPage3.Controls.Add(this.dgMusteriler);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(351, 445);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Müşteri Listele";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnMusteriListele
            // 
            this.btnMusteriListele.Location = new System.Drawing.Point(8, 6);
            this.btnMusteriListele.Name = "btnMusteriListele";
            this.btnMusteriListele.Size = new System.Drawing.Size(335, 23);
            this.btnMusteriListele.TabIndex = 2;
            this.btnMusteriListele.Text = "Müşteri Listele";
            this.btnMusteriListele.UseVisualStyleBackColor = true;
            this.btnMusteriListele.Click += new System.EventHandler(this.btnMusteriListele_Click);
            // 
            // dgMusteriler
            // 
            this.dgMusteriler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgMusteriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMusteriler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TC,
            this.Ad,
            this.Adres,
            this.Telefon,
            this.Taahut,
            this.Paket});
            this.dgMusteriler.Location = new System.Drawing.Point(3, 35);
            this.dgMusteriler.Name = "dgMusteriler";
            this.dgMusteriler.Size = new System.Drawing.Size(345, 407);
            this.dgMusteriler.TabIndex = 1;
            // 
            // TC
            // 
            this.TC.DataPropertyName = "Tc";
            this.TC.HeaderText = "TC";
            this.TC.Name = "TC";
            // 
            // Ad
            // 
            this.Ad.DataPropertyName = "Ad";
            this.Ad.HeaderText = "Ad";
            this.Ad.Name = "Ad";
            // 
            // Adres
            // 
            this.Adres.DataPropertyName = "Adres";
            this.Adres.HeaderText = "Adres";
            this.Adres.Name = "Adres";
            // 
            // Telefon
            // 
            this.Telefon.DataPropertyName = "Telefon";
            this.Telefon.HeaderText = "Telefon";
            this.Telefon.Name = "Telefon";
            // 
            // Taahut
            // 
            this.Taahut.DataPropertyName = "Taahut";
            this.Taahut.HeaderText = "Taahut";
            this.Taahut.Name = "Taahut";
            // 
            // Paket
            // 
            this.Paket.DataPropertyName = "Paket";
            this.Paket.HeaderText = "Paket";
            this.Paket.Name = "Paket";
            // 
            // paketBindingSource
            // 
            this.paketBindingSource.DataSource = typeof(MModel.Paket);
            // 
            // Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 471);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Panel";
            this.Text = "Panel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Panel_FormClosing);
            this.Load += new System.EventHandler(this.Panel_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgMusteriler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paketBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DateTimePicker dtTaahut;
        private System.Windows.Forms.TextBox txtPaketFiyat;
        private System.Windows.Forms.TextBox txtPaketAd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnPaketEkle;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgMusteriler;
        private System.Windows.Forms.Button btnMusteriListele;
        private System.Windows.Forms.ComboBox cmbpaket;
        private System.Windows.Forms.BindingSource paketBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn TC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Taahut;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paket;
        private System.Windows.Forms.ComboBox cmbTcList;
        private System.Windows.Forms.Button btnMusteriKaldir;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbPaketListe;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnPaketKaldir;
        private System.Windows.Forms.Label label11;
    }
}

