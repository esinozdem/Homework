
namespace KahveEvi
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCustomerClear = new System.Windows.Forms.Button();
            this.txtMusteriKodu = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnMusteriKaydet = new System.Windows.Forms.Button();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtAdiSoyadi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbDrink = new System.Windows.Forms.ComboBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lstOrder = new System.Windows.Forms.ListBox();
            this.btnOrderTotal = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.rbTall = new System.Windows.Forms.RadioButton();
            this.rbGrande = new System.Windows.Forms.RadioButton();
            this.rbVenti = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rbSoy = new System.Windows.Forms.RadioButton();
            this.rbLean = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.chk2x = new System.Windows.Forms.CheckBox();
            this.chk1x = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nuCount = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuCount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(288, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kahve Zinciri";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 66);
            this.panel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nuCount);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.btnCalculate);
            this.groupBox1.Controls.Add(this.cmbDrink);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 304);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 195);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(14, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "İçecek";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCustomerClear);
            this.groupBox2.Controls.Add(this.txtMusteriKodu);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btnMusteriKaydet);
            this.groupBox2.Controls.Add(this.txtAdres);
            this.groupBox2.Controls.Add(this.txtTelefon);
            this.groupBox2.Controls.Add(this.txtAdiSoyadi);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(333, 226);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Müşteri Bilgileri";
            // 
            // btnCustomerClear
            // 
            this.btnCustomerClear.Location = new System.Drawing.Point(233, 178);
            this.btnCustomerClear.Name = "btnCustomerClear";
            this.btnCustomerClear.Size = new System.Drawing.Size(83, 31);
            this.btnCustomerClear.TabIndex = 9;
            this.btnCustomerClear.Text = "Temizle";
            this.btnCustomerClear.UseVisualStyleBackColor = true;
            this.btnCustomerClear.Click += new System.EventHandler(this.btnCustomerClear_Click);
            // 
            // txtMusteriKodu
            // 
            this.txtMusteriKodu.Location = new System.Drawing.Point(109, 19);
            this.txtMusteriKodu.Name = "txtMusteriKodu";
            this.txtMusteriKodu.Size = new System.Drawing.Size(207, 20);
            this.txtMusteriKodu.TabIndex = 8;
            this.txtMusteriKodu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMusteriKodu_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(9, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Müşteri Kodu:";
            // 
            // btnMusteriKaydet
            // 
            this.btnMusteriKaydet.Location = new System.Drawing.Point(109, 178);
            this.btnMusteriKaydet.Name = "btnMusteriKaydet";
            this.btnMusteriKaydet.Size = new System.Drawing.Size(118, 31);
            this.btnMusteriKaydet.TabIndex = 6;
            this.btnMusteriKaydet.Text = "Müşteri Kaydet";
            this.btnMusteriKaydet.UseVisualStyleBackColor = true;
            this.btnMusteriKaydet.Click += new System.EventHandler(this.btnMusteriKaydet_Click);
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(109, 105);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(207, 67);
            this.txtAdres.TabIndex = 5;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(109, 79);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(207, 20);
            this.txtTelefon.TabIndex = 4;
            this.txtTelefon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTelefon_KeyDown);
            // 
            // txtAdiSoyadi
            // 
            this.txtAdiSoyadi.Location = new System.Drawing.Point(109, 48);
            this.txtAdiSoyadi.Name = "txtAdiSoyadi";
            this.txtAdiSoyadi.Size = new System.Drawing.Size(207, 20);
            this.txtAdiSoyadi.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(9, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Adres:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(8, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Telefon:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(9, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Adı Soyadı:";
            // 
            // cmbDrink
            // 
            this.cmbDrink.FormattingEnabled = true;
            this.cmbDrink.Location = new System.Drawing.Point(94, 23);
            this.cmbDrink.Name = "cmbDrink";
            this.cmbDrink.Size = new System.Drawing.Size(137, 21);
            this.cmbDrink.TabIndex = 3;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(94, 158);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(221, 31);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Hesapla";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstOrder);
            this.groupBox3.Location = new System.Drawing.Point(369, 91);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(369, 331);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sipariş Detayı";
            // 
            // lstOrder
            // 
            this.lstOrder.FormattingEnabled = true;
            this.lstOrder.Location = new System.Drawing.Point(6, 12);
            this.lstOrder.Name = "lstOrder";
            this.lstOrder.Size = new System.Drawing.Size(357, 303);
            this.lstOrder.TabIndex = 0;
            // 
            // btnOrderTotal
            // 
            this.btnOrderTotal.Location = new System.Drawing.Point(369, 461);
            this.btnOrderTotal.Name = "btnOrderTotal";
            this.btnOrderTotal.Size = new System.Drawing.Size(217, 32);
            this.btnOrderTotal.TabIndex = 6;
            this.btnOrderTotal.Text = "Siparişi Tamamla";
            this.btnOrderTotal.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotal.ForeColor = System.Drawing.Color.Red;
            this.lblTotal.Location = new System.Drawing.Point(371, 425);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(131, 21);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "Toplam : 0.00 TL";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbVenti);
            this.groupBox4.Controls.Add(this.rbGrande);
            this.groupBox4.Controls.Add(this.rbTall);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Location = new System.Drawing.Point(6, 53);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(309, 99);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ekstra";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Boyut";
            // 
            // rbTall
            // 
            this.rbTall.AutoSize = true;
            this.rbTall.Location = new System.Drawing.Point(241, 76);
            this.rbTall.Name = "rbTall";
            this.rbTall.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rbTall.Size = new System.Drawing.Size(42, 17);
            this.rbTall.TabIndex = 8;
            this.rbTall.Text = "Tall";
            this.rbTall.UseVisualStyleBackColor = true;
            // 
            // rbGrande
            // 
            this.rbGrande.AutoSize = true;
            this.rbGrande.Location = new System.Drawing.Point(165, 76);
            this.rbGrande.Name = "rbGrande";
            this.rbGrande.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rbGrande.Size = new System.Drawing.Size(60, 17);
            this.rbGrande.TabIndex = 9;
            this.rbGrande.Text = "Grande";
            this.rbGrande.UseVisualStyleBackColor = true;
            // 
            // rbVenti
            // 
            this.rbVenti.AutoSize = true;
            this.rbVenti.Checked = true;
            this.rbVenti.Location = new System.Drawing.Point(88, 76);
            this.rbVenti.Name = "rbVenti";
            this.rbVenti.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rbVenti.Size = new System.Drawing.Size(49, 17);
            this.rbVenti.TabIndex = 10;
            this.rbVenti.TabStop = true;
            this.rbVenti.Text = "Venti";
            this.rbVenti.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(64, 195);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(328, 38);
            this.panel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rbSoy);
            this.panel3.Controls.Add(this.rbLean);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(18, 389);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(255, 33);
            this.panel3.TabIndex = 8;
            // 
            // rbSoy
            // 
            this.rbSoy.AutoSize = true;
            this.rbSoy.Location = new System.Drawing.Point(165, 11);
            this.rbSoy.Name = "rbSoy";
            this.rbSoy.Size = new System.Drawing.Size(49, 17);
            this.rbSoy.TabIndex = 9;
            this.rbSoy.Text = "Soya";
            this.rbSoy.UseVisualStyleBackColor = true;
            // 
            // rbLean
            // 
            this.rbLean.AutoSize = true;
            this.rbLean.Location = new System.Drawing.Point(88, 11);
            this.rbLean.Name = "rbLean";
            this.rbLean.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rbLean.Size = new System.Drawing.Size(56, 17);
            this.rbLean.TabIndex = 8;
            this.rbLean.Text = "Yağsız";
            this.rbLean.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Süt";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.chk2x);
            this.panel4.Controls.Add(this.chk1x);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(6, 52);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(255, 45);
            this.panel4.TabIndex = 9;
            // 
            // chk2x
            // 
            this.chk2x.AutoSize = true;
            this.chk2x.Location = new System.Drawing.Point(165, 16);
            this.chk2x.Name = "chk2x";
            this.chk2x.Size = new System.Drawing.Size(37, 17);
            this.chk2x.TabIndex = 6;
            this.chk2x.Text = "2x";
            this.chk2x.UseVisualStyleBackColor = true;
            // 
            // chk1x
            // 
            this.chk1x.AutoSize = true;
            this.chk1x.Location = new System.Drawing.Point(88, 13);
            this.chk1x.Name = "chk1x";
            this.chk1x.Size = new System.Drawing.Size(37, 17);
            this.chk1x.TabIndex = 5;
            this.chk1x.Text = "1x";
            this.chk1x.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Shot";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // nuCount
            // 
            this.nuCount.Location = new System.Drawing.Point(247, 23);
            this.nuCount.Name = "nuCount";
            this.nuCount.Size = new System.Drawing.Size(42, 20);
            this.nuCount.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 539);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnOrderTotal);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "ra";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnMusteriKaydet;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtAdiSoyadi;
        private System.Windows.Forms.TextBox txtMusteriKodu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCustomerClear;
        private System.Windows.Forms.ComboBox cmbDrink;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lstOrder;
        private System.Windows.Forms.Button btnOrderTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton rbVenti;
        private System.Windows.Forms.RadioButton rbGrande;
        private System.Windows.Forms.RadioButton rbTall;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckBox chk2x;
        private System.Windows.Forms.CheckBox chk1x;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rbSoy;
        private System.Windows.Forms.RadioButton rbLean;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nuCount;
    }
}

