using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Benzin_Otomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbDepo_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        string path = @"D:\depo.txt";
        double D_benzin95 = 0, D_benzin97 = 0, D_dizel = 0, D_euroDizel = 0, D_Lpg = 0;
        double E_benzin95 = 0, E_benzin97 = 0, E_dizel = 0, E_euroDizel = 0, E_Lpg = 0;
        double F_benzin95 = 0, F_benzin97 = 0, F_dizel = 0, F_euroDizel = 0, F_Lpg = 0;
        double S_benzin95 = 0, S_benzin97 = 0, S_dizel = 0, S_euroDizel = 0, S_Lpg = 0;
        string[] depo_bilgileri;
        string[] fiyat_bilgileri;

        private void txt_depo_oku() //Depodaki bilgileri txtden okuyacak.
        {
            //FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            //StreamReader sw = new StreamReader(fs);
            //string yazi = sw.ReadLine();
            //depo_bilgileri= 
            //while (yazi !=null)
            //{
            //    label6.Text = D_benzin95.ToString("N");
            //    label7.Text = D_benzin97.ToString("N");
            //    label8.Text = D_dizel.ToString("N");
            //    label9.Text = D_euroDizel.ToString("N");
            //    label10.Text = D_Lpg.ToString("N");
            //    yazi = sw.ReadLine();
            //}

            FileStream fs = new FileStream(path, FileMode.OpenOrCreate,FileAccess.ReadWrite);

            StreamReader sr = new StreamReader(fs);

            depo_bilgileri = new string[5];   

            int i = 0;
            while (sr.EndOfStream != true)
            {

                depo_bilgileri[i] = sr.ReadLine();

                i = i + 1;

            }
            sr.Close();
            //fs.Close();

        }

        private void txt_depo_yaz() //Txt dosyasındakileri label'a yazdırmaya yarar.
        {
            label6.Text = D_benzin95.ToString("N");
            label7.Text = D_benzin97.ToString("N");
            label8.Text = D_dizel.ToString("N");
            label9.Text = D_euroDizel.ToString("N");
            label10.Text = D_Lpg.ToString("N");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_depo_oku();
            txt_depo_yaz();
        }
    }
}
