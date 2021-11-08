using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ödev1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        //Dışardan Girilen sayısal ifadenin rakam değerleri toplamını gösterme.
        private void button1_Click_1(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txtSayi.Text);
            int toplam = 0;
            string metinselSayi = sayi1.ToString();
            for (int i = 0; i < sayi1.ToString().Length; i++)
            {
                toplam += Convert.ToInt32(metinselSayi[i].ToString());
            }
            lblSonuc.Text = ("Sayı Değer Toplamı:  " +toplam.ToString());
        }
    }
}
