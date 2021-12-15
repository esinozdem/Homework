using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KahveEvi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Tupple max 7 tane alır.
        List<Tuple<string, string, string, string>> customerList = new List<Tuple<string, string, string, string>>();
        //List<string> drinks =new List<string>() { "Misto", "Americano", "Bianco", "Cappucino", "Macchiato", "Con Panna", "Mocha" ,"Çay","Hot Chocolate","Chai Tea Latte"};
        List<(string customerCode, decimal price, string producName)> orders = new List<(string customerCode, decimal price, string productName)>();

        List<(int id, string drinkName, decimal price)> drinks = new List<(int, string, decimal)>(){
        (0,"Misto",4.5m),
        (1,"Americano",5.75m),
        (2,"Bianco",5.75m),
        (3,"Cappucino",6m),
        (4,"Macchiato",7.5m),
        (5,"Con Panna",8m),
        (6,"Mocha",7.5m),
        (7,"Tea",3m),
        (8,"Hot Chocolate", 4.5m),
        };
        //Seçilen müşteriii 
        Tuple<string, string, string, string> selectedCustomer;
        private void Form1_Load(object sender, EventArgs e)
        {
            FillControl();
        }

        private void FillControl()
        {
            FillDrinks();
            nuCount.Value = 1;
        }

        private void FillDrinks()
        {
            cmbDrink.Items.Clear();


            foreach (var drink in drinks)
            {
                cmbDrink.Items.Add(drink.drinkName);
            }
            cmbDrink.SelectedIndex = 0;

        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (cmbDrink.SelectedIndex == -1)
            {
                MessageBox.Show("İçecek Seçimi Yapmalısınız..");
                cmbDrink.Focus();
                return;
            }
            if (selectedCustomer == null)
            {
                MessageBox.Show("Seçili bir müşteri yok seçim yapın veya yeni müşteri kaydedin.");
                txtMusteriKodu.Focus();
                return;
            }

            decimal drinkTotal = SelectedDrinkTotal();
            string productName = SelectedDrinkListBox(drinkTotal);

            //Siparişi orders içine ekliyoruz...
            var order = (selectedCustomer.Item1, drinkTotal, productName);
            orders.Add(order);
            TotalLabelUpdate();

        }
        public void SelectedDrinkFormClear()
        {
            cmbDrink.SelectedIndex = 0;
            chk1x.Checked = false;

        }
        

        private void TotalLabelUpdate()
        {
            decimal total = 0;
            foreach (var item in orders)
            {
                total += item.price;
            }
            lblTotal.Text = $"Toplam Tutar=> {total.ToString("N2")}";
            
        }

        public decimal SelectedDrinkTotal()
        {
            decimal total = 0; //Toplam hesaplanacak değer
            decimal count = nuCount.Value; // adet
            decimal drinkPrice = drinks[cmbDrink.SelectedIndex].price;
            if (chk1x.Checked)
                drinkPrice += 0.75m;
            if (chk2x.Checked)
                drinkPrice += 0.75m;

            //Süt Seçimi
            if (rbLean.Checked || rbSoy.Checked)
                drinkPrice += 0.50m;

            // Boyut SEçimi
            if (rbVenti.Checked)
                drinkPrice *= 1.75m;
            else if (rbGrande.Checked)
                drinkPrice *= 1.25m;
            else drinkPrice *= 1;

            total = drinkPrice * count;
            return total;
        }

        public void AddSelectedDrinkListBox(decimal totalPrice)
        {
            string drinkName = drinks[cmbDrink.SelectedIndex].drinkName;
            decimal count = nuCount.Value;

            //Shot Seçimi
            string shot = "";
            if (chk1x.Checked)
                shot += "1X";
            if (chk2x.Checked)
                shot += "2X";

            //Süt Seçimi
            string milk = "";
            if (rbLean.Checked)
                milk = "Yağsız";
            else if (rbSoy.Checked)
                milk = "Soya";

            //İçecek Boyutu
            string drinkSize = "";
            if (rbGrande.Checked)
                drinkSize = "Grande";
            else if (rbTall.Checked)
                drinkSize = "Tall";
            else if (rbVenti.Checked)
                drinkSize = "Venti";

            string item= ($"{drinkName} {shot} {milk} {drinkSize}x{count}= {totalPrice.ToString("N2")}");
            
            lstOrder.Items.Add(item);
            return item;

            //N2= Virgülden sonra iki hane dönüştürerek ekrana yaz.
        }
        //Müşteri kaydetme başarılı ise selectedCustomer atama yapıyor.
        private void btnMusteriKaydet_Click(object sender, EventArgs e)
        {
            string customerCode = GenrateCustomerCode();
            string customerName = txtAdiSoyadi.Text;
            string customerPhone = txtTelefon.Text;
            string customerAdress = txtAdres.Text;


            bool isCustomerRecord = CheckCustomer(customerPhone);
            if (isCustomerRecord)
            {
                MessageBox.Show("Müşteri İçerde Var.");
            }
            else
            {
                Tuple<string, string, string, string> customer = Tuple.Create(customerCode, customerName, customerPhone, customerAdress);
                customerList.Add(customer);
                FillCustomer(customer); // Kayıt işleminden sonra müşteri alanlarını güncelledim.
                customer = selectedCustomer;
                MessageBox.Show("Yeni Mşteri Kaydedildi.");
            }
        }
        public void FillCustomer(Tuple<string, string, string, string> customer)
        {
            txtMusteriKodu.Text = customer.Item1;
            txtAdiSoyadi.Text = customer.Item2;
            txtTelefon.Text = customer.Item3;
            txtAdres.Text = customer.Item4;
        }
        public string GenrateCustomerCode() // Kendimiz müşteri kodu ürettik.
        {
            //Müşteri Kodu kaç karakterli olsun ??
            // MN9999999 => Milyon tane kod üretmek istiyorum.
            string customerCode = "MN";
            int lastCustomerItem = customerList.Count + 1;
            customerCode += lastCustomerItem.ToString().PadLeft(7, '0'); // Padleft 7 ye kadar tamamlar gerisinide 0'la doldurur.
            return customerCode;
        }

        public bool CheckCustomer(string phone)
        {
            bool result = false;
            foreach (var customer in customerList)
            {
                if (customer.Item3 == phone)
                {
                    result = true;
                    break;
                }

            }
            return result;
        }

        private void txtTelefon_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                string phone = txtTelefon.Text;
                var customer = FindCustomerPhone(phone);
                if (customer.Item1 != null)
                {
                    //Eğer müşteri bulunduysa;
                    selectedCustomer = customer;
                    FillCustomer(customer);
                }
            }
        }

        private void txtMusteriKodu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string customerCode = txtMusteriKodu.Text;
                var customer = FindCustomerCode(customerCode);
                if (customer.Item1 != null)
                {
                    selectedCustomer = customer;
                    FillCustomer(customer);
                }
            }
        }


        public Tuple<string, string, string, string> FindCustomerPhone(string phone)
        {
            Tuple<string, string, string, string> returnValue
                = Tuple.Create<string, string, string, string>(null, null, null, null);
            for (int i = 0; i < customerList.Count; i++)
            {
                var customeritem = customerList[i];
                if (customeritem.Item3 == phone)
                {
                    returnValue = customeritem;
                    break;
                }

            }
            return returnValue; // Metodun geriye döneceği değer= returnvalue
        }
        public Tuple<string, string, string, string> FindCustomerCode(string customerCode)
        {
            Tuple<string, string, string, string> returnValue
                = Tuple.Create<string, string, string, string>(null, null, null, null);
            for (int i = 0; i < customerList.Count; i++)
            {
                var customerItem = customerList[i]; // herbir elemanı customerıtemın içine at.
                if (customerItem.Item1 == customerCode)
                {
                    returnValue = customerItem;
                    break;
                }
            }
            return returnValue;
        }
        private void CustomerClear()
        {
            txtMusteriKodu.Clear();
            txtAdiSoyadi.Clear();
            txtTelefon.Clear();
            txtAdres.Clear();
            selectedCustomer = null; //Müşteri seçimini burada null yapıyoruz çünkü ekranı temizledik.
        }
        private void btnCustomerClear_Click(object sender, EventArgs e)
        {
            CustomerClear();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


    }
}
