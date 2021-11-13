using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PansiyonOtomasyon
{
    public partial class FrmYeniMusteri : Form
    {
        public FrmYeniMusteri()
        {
            InitializeComponent();
        }
        
        private void btn101_Click(object sender, EventArgs e)
        {
            txtOdaNumarası.Text = "101";
        }

        private void btn102_Click(object sender, EventArgs e)
        {
            txtOdaNumarası.Text = "102";
        }

        private void btn103_Click(object sender, EventArgs e)
        {
            txtOdaNumarası.Text = "103";
        }

        private void btn104_Click(object sender, EventArgs e)
        {
            txtOdaNumarası.Text = "104";
        }

        private void btn105_Click(object sender, EventArgs e)
        {
            txtOdaNumarası.Text = "105";
        }

        private void btn106_Click(object sender, EventArgs e)
        {
            txtOdaNumarası.Text = "106";
        }

        private void btn107_Click(object sender, EventArgs e)
        {
            txtOdaNumarası.Text = "107";
        }

        private void btn108_Click(object sender, EventArgs e)
        {
            txtOdaNumarası.Text = "108";
        }

        private void btn109_Click(object sender, EventArgs e)
        {
            txtOdaNumarası.Text = "109";
        }

        private void btnDoluOda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı Renkli Butonlar Dolu odaları Gösterir");
        }

        private void btnBosOda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeşil Renkli Butonlar Bş Odaları Gösterir.");
        }
    }
}
