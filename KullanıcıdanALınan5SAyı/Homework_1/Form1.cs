using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_1
{
    public partial class Form1 : Form
    {
        //Kulanıcıdan İstenilen 5 Sayının Karesinin Toplamını Hesaplama
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Lütfen Sayı Ekleyiniz!");
        }
        
       int toplam=0;

        

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            
            foreach (var item in listBox1.Items)
            {
                toplam += Convert.ToInt32(item) * Convert.ToInt32(item);
            }
            listBox1.Items.Add("Girdiğiniz Sayıların Karesinin Toplamı:" +toplam.ToString());

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(Convert.ToInt32(txtSayi1.Text));
            if (listBox1.Items.Count > 5)
            {
                MessageBox.Show("Sadece 5 sayı Girebilirsiniz.");
            }
        }
       

    }

    
}

