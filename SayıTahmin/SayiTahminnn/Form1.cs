using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayiTahminnn
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();

        }
        int TutulanSayi = 0;
        private void btnSayiTahmin_Click(object sender, EventArgs e)
        {
            if (TutulanSayi <= 0)
            {
                MessageBox.Show("Lütfen Sayı Üretiniz.");
            }
            else
            {
                int TahminHakki = 1;

                int sayi = Convert.ToInt32(txtSayiTahmin.Text);
                if (TahminHakki <= 5)
                {
                    TahminHakki++;
                    while (TutulanSayi != sayi)
                    {

                        //sayi = Convert.ToInt32(txtSayiTahmin.Text);



                        if (TutulanSayi > sayi)
                        {
                            MessageBox.Show("Sayıyı Arttırınız");
                            sayi = Convert.ToInt32(txtSayiTahmin.Text);

                            break;
                        }
                        else if (TutulanSayi < sayi)
                        {
                            MessageBox.Show("Sayıyı Azaltınız.");
                            sayi = Convert.ToInt32(txtSayiTahmin.Text);
                            break;
                        }

                        MessageBox.Show("kalan tahmin hakkınız:" + TahminHakki);
                    }
                    if (TutulanSayi == sayi)
                    {
                        MessageBox.Show($"Sayıyı {TahminHakki}. Kerede Doğru Tahmin Ettiniz");

                    }
                }
                else
                {
                    MessageBox.Show("tahmn hakkınız btmiştr.");
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            TutulanSayi = rnd.Next(0, 100);
        }
    }
}
