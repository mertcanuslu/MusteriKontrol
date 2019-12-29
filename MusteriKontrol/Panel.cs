using MBll;
using MModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusteriKontrol
{
    public partial class Panel : Form
    {
        MusteriBL mbl = new MusteriBL(); 
        PaketBL pbl = new PaketBL();

        public Panel()
        {
            InitializeComponent();

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Musteri m = new Musteri();
            m.Ad = txtAd.Text;
            m.Tc = txtTc.Text;
            m.Adres = txtAdres.Text;
            m.Telefon = txtTelefon.Text;
            m.Taahut = Convert.ToString(dtTaahut.Value);
            m.PaketId = ((Paket)cmbpaket.SelectedItem).PaketId;
            mbl.MusteriEkle(m);
            RefreshCheckbox();
        }

        private void btnPaketEkle_Click(object sender, EventArgs e)
        {
            Paket p = new Paket();
            p.PaketAd = txtPaketAd.Text;
            p.PaketFiyat = txtPaketFiyat.Text;
            pbl.PaketEkle(p);
            RefreshCheckbox();

        }




        private void btnMusteriListele_Click(object sender, EventArgs e)
        {
            dgMusteriler.DataSource = mbl.MusteriListele();
        }

        private void RefreshCheckbox()
        {
            cmbpaket.DataSource = pbl.PaketleriListele();
            cmbpaket.DisplayMember = "PaketAd";
            cmbpaket.ValueMember = "PaketId";

            cmbTcList.DataSource = mbl.MusteriListele();
            cmbTcList.DisplayMember = "Tc";
            cmbTcList.ValueMember = "MusteriId";


            cmbPaketListe.DataSource = pbl.PaketleriListele();
            cmbpaket.DisplayMember = "PaketAd";
            cmbpaket.ValueMember = "PaketId";
        }

        private void Panel_Load(object sender, EventArgs e)
        {
            dgMusteriler.AutoGenerateColumns = false;

            RefreshCheckbox();
        }

        private void Panel_FormClosing(object sender, FormClosingEventArgs e)
        {
            mbl.Dispose();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            RefreshCheckbox();

        }

        private void btnMusteriKaldir_Click(object sender, EventArgs e)
        {
            mbl.MusteriKaldir((Musteri)cmbTcList.SelectedItem);
            RefreshCheckbox();

        }

        private void btnPaketKaldir_Click(object sender, EventArgs e)
        {

            pbl.PaketKaldir((Paket)cmbPaketListe.SelectedItem);
            RefreshCheckbox();

        }


    }
}
