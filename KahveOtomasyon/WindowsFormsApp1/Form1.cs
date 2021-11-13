using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Core.CustomExtension;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double toplamsiparisler = 0;
        string[] kahveler = { "Misto", "Americano", "Bianco", "Cappucino", "Macchiato" };
        decimal[] kahvefiyatlari = { 4.5m, 5.75m, 6, 7.5m, 6.75m};
        string[] kahveboyutlari = { "Tall", "Grande", "Venti" };
        decimal[] kahvebotukatsayi = { 1, 1.25m, 1.75m };
        string[] sogukicecekler = { "Kola", "Fanta", "Sprite", "Maden Suyu", "Su" };
        decimal[] sogukfiyatlar = { 5.5m,5.5m,5.5m,5.5m,5.5m };
        string[] sicakicecekler = { "Çay", "Hot Chocolate", "Chai Tea Latte" };
        decimal[] sicakfiyatlar = { 3, 4.5m, 6.5m };
        decimal toplam = 0;
        string adet;

        private void Form1_Load(object sender, EventArgs e)
        {
            FillForm();
        }

        private void FillForm()
        {
            cmbKahve.FillDataSource(kahveler);
            cmbSogukicecek.FillDataSource(sogukicecekler);
            cmbSicakicecek.FillDataSource(sicakicecekler);

        }
        

        private void cmbKahve_SelectedIndexChanged(object sender, EventArgs e)
        {
            Siparisler.Items.Clear();
            if (cmbKahve.SelectedIndex>0)
            {
                string secilenItem = cmbKahve.SelectedItem.ToString();
                switch (secilenItem)
                {
                    case "Misto":
                        for (int i = 0; i < kahveler.Length; i++)
                        {
                            if (kahveler[i]=="Misto")
                            {
                                toplam += kahvefiyatlari[i];
                            }
                        }
                        break;
                    case "Americano":
                        for (int i = 0; i < kahveler.Length; i++)
                        {
                            if (kahveler[i]=="Americano")
                            {
                                toplam += kahvefiyatlari[i];
                            }
                        }
                        break;

                    case "Bianco":
                        for (int i = 0; i < kahveler.Length; i++)
                        {
                            if (kahveler[i]== "Bianco")
                            {
                                toplam += kahvefiyatlari[i];
                            }
                        }
                        break;

                    case "Cappucino":
                        for (int i = 0; i < kahveler.Length; i++)
                        {
                            if (kahveler[i]=="Cappucino")
                            {
                                toplam += kahvefiyatlari[i];
                            }
                        }
                        break;
                    case "Macchiato":
                        for (int i = 0; i < kahveler.Length; i++)
                        {
                            if (kahveler[i]=="Macchiato")
                            {
                                toplam += kahvefiyatlari[i];
                            }
                        }
                        break;

                    default:
                        break;
                        

                }
            }
            Siparisler.Items.Add(toplam);
        }

        private void cb1x_CheckedChanged(object sender, EventArgs e)
        {
            Siparisler.Items.Clear();
            if (cb1x.Checked == true)
            {
               
                toplam += Convert.ToDecimal(0.75);


            }

        }
        private void cb2x_CheckedChanged(object sender, EventArgs e)
        {
            Siparisler.Items.Clear();
            if (cb2x.Checked == true)
            {

                toplam += Convert.ToDecimal(1.50);

            }
        }
        private void rbYagsiz_CheckedChanged(object sender, EventArgs e)
        {
            if (rbYagsiz.Checked == true)
            {

                Siparisler.Items.Add(rbYagsiz);

            }
        }


        private void cmbSogukicecek_SelectedIndexChanged(object sender, EventArgs e)
        {
            Siparisler.Items.Clear();
            if (cmbKahve.SelectedIndex > 0)
            {
                string secilenItem = cmbSicakicecek.SelectedItem.ToString();
                switch (secilenItem)
                {
                    case "Çay":
                        for (int i = 0; i < sicakicecekler.Length; i++)
                        {
                            if (sicakicecekler[i] == "Çay")
                            {
                                
                                toplam += sicakfiyatlar[i];
                            }
                        }
                        break;
                    case "Hot Cholocate":
                        for (int i = 0; i < sicakicecekler.Length; i++)
                        {
                            if (sicakicecekler[i] == "Hot Cholocate")
                            {
                                toplam += sicakfiyatlar[i];
                            }
                        }
                        break;

                    case "Chai Tea Latte":
                        for (int i = 0; i < sicakicecekler.Length; i++)
                        {
                            if (kahveler[i] == "Chai Tea Latte")
                            {
                                toplam += sicakfiyatlar[i];
                            }
                        }
                        
                        break;


                    default:
                        break;
                }
            }
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            Siparisler.Items.Add(toplam);
        }

        private void btnSiparisVer_Click(object sender, EventArgs e)
        {
            
        }
    }
}
