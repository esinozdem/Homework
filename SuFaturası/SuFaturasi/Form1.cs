using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuFaturasi
{
    public partial class Form1 : Form
    {
        //SU FATURASI
        // Suyun birim metreküp fiyatı kullanıldığı yere göre değişkenlik göstermektedir.
        //Eğer kullanım yeri Mesken ise suyun birim fiyatı=>0.7'tür.
        //Eğer kullanım yeri Umumi ise suyun birim fiyatı =>0.3'tür.
        //Ayrıca kurumda artık su ücreti alınmaktadır. Sadece meskenkullanıcılarından toplam kullanılan suyun %30'u kadar ekstra'dan hesaplanır ve yine artık su metreküpü başına 0.2 tl ücret alınmaktadır.
        public Form1()
        {
            InitializeComponent();
        }
        int sonindex, ilkindex;
            double suMiktari;

        private void button1_Click(object sender, EventArgs e)
        {

            sonindex = Convert.ToInt32(txtIlkIndex.Text);
            ilkindex = Convert.ToInt32(txtSonIndex.Text);
            string AdSoyad = Convert.ToString(txtAd.Text);
            double suMiktari  = (ilkindex-sonindex);
            lstAdSoyad.Items.Add(AdSoyad.ToString());
            lstKSuMiktari.Items.Add(suMiktari.ToString());
            if (rbMesken.Checked == true)
            {
                double fatura;
                fatura = (suMiktari * 0.7)+(suMiktari*0.2);
                lstFaturaTutari.Items.Add(fatura);
            }
            if (rbUmumi.Checked == true)
            {
                double fatura;
                fatura = suMiktari * 0.3;
                lstFaturaTutari.Items.Add(fatura);
            }
            else
            {
                MessageBox.Show("Lütfen Düzgün Sayı Girişi Yapınız.");
            }

            
        }

        
    }
}
