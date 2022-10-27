using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrunStok
{
    public partial class homePage : Form
    {
        public homePage()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            int urunSayisi = Int32.Parse(txtSepettekiUrunSayisi.Text);
            int tutar = Int32.Parse(txtSepetTutari.Text) + Int32.Parse(txtFiyatUrun1.Text);
            urunSayisi++;
            txtSepettekiUrunSayisi.Text = urunSayisi.ToString();
            txtSepetTutari.Text = tutar.ToString();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            int urunSayisi = Int32.Parse(txtSepettekiUrunSayisi.Text);
            int tutar = Int32.Parse(txtSepetTutari.Text) + Int32.Parse(txtFiyatUrun2.Text);
            urunSayisi++;
            txtSepettekiUrunSayisi.Text = urunSayisi.ToString();
            txtSepetTutari.Text = tutar.ToString();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            int urunSayisi = Int32.Parse(txtSepettekiUrunSayisi.Text);
            int tutar = Int32.Parse(txtSepetTutari.Text) + Int32.Parse(txtFiyatUrun3.Text);
            urunSayisi++;
            txtSepettekiUrunSayisi.Text = urunSayisi.ToString();
            txtSepetTutari.Text = tutar.ToString();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            int urunSayisi = Int32.Parse(txtSepettekiUrunSayisi.Text);
            int tutar = Int32.Parse(txtSepetTutari.Text) + Int32.Parse(txtFiyatUrun4.Text);
            urunSayisi++;
            txtSepettekiUrunSayisi.Text = urunSayisi.ToString();
            txtSepetTutari.Text = tutar.ToString();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            int urunSayisi = Int32.Parse(txtSepettekiUrunSayisi.Text);
            int tutar = Int32.Parse(txtSepetTutari.Text) + Int32.Parse(txtFiyatUrun5.Text);
            urunSayisi++;
            txtSepettekiUrunSayisi.Text = urunSayisi.ToString();
            txtSepetTutari.Text = tutar.ToString();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            int urunSayisi = Int32.Parse(txtSepettekiUrunSayisi.Text);
            int tutar = Int32.Parse(txtSepetTutari.Text) + Int32.Parse(txtFiyatUrun6.Text);
            urunSayisi++;
            txtSepettekiUrunSayisi.Text = urunSayisi.ToString();
            txtSepetTutari.Text = tutar.ToString();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            int urunSayisi = Int32.Parse(txtSepettekiUrunSayisi.Text);
            int tutar = Int32.Parse(txtSepetTutari.Text) + Int32.Parse(txtFiyatUrun7.Text);
            urunSayisi++;
            txtSepettekiUrunSayisi.Text = urunSayisi.ToString();
            txtSepetTutari.Text = tutar.ToString();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            int urunSayisi = Int32.Parse(txtSepettekiUrunSayisi.Text);
            int tutar = Int32.Parse(txtSepetTutari.Text) + Int32.Parse(txtFiyatUrun8.Text);
            urunSayisi++;
            txtSepettekiUrunSayisi.Text = urunSayisi.ToString();
            txtSepetTutari.Text = tutar.ToString();

            
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
