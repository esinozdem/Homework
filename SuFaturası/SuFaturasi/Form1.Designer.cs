
namespace SuFaturasi
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
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSonIndex = new System.Windows.Forms.TextBox();
            this.txtIlkIndex = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lstAdSoyad = new System.Windows.Forms.ListBox();
            this.lstKSuMiktari = new System.Windows.Forms.ListBox();
            this.lstFaturaTutari = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbUmumi = new System.Windows.Forms.RadioButton();
            this.rbMesken = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(111, 32);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(246, 20);
            this.txtAd.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(28, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adı Soyadı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(28, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Son Index:";
            // 
            // txtSonIndex
            // 
            this.txtSonIndex.Location = new System.Drawing.Point(111, 75);
            this.txtSonIndex.Name = "txtSonIndex";
            this.txtSonIndex.Size = new System.Drawing.Size(246, 20);
            this.txtSonIndex.TabIndex = 3;
            // 
            // txtIlkIndex
            // 
            this.txtIlkIndex.Location = new System.Drawing.Point(111, 117);
            this.txtIlkIndex.Name = "txtIlkIndex";
            this.txtIlkIndex.Size = new System.Drawing.Size(246, 20);
            this.txtIlkIndex.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(37, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "İlk Index:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(231, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 26);
            this.button1.TabIndex = 9;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstAdSoyad
            // 
            this.lstAdSoyad.FormattingEnabled = true;
            this.lstAdSoyad.ItemHeight = 15;
            this.lstAdSoyad.Location = new System.Drawing.Point(12, 250);
            this.lstAdSoyad.Name = "lstAdSoyad";
            this.lstAdSoyad.Size = new System.Drawing.Size(102, 229);
            this.lstAdSoyad.TabIndex = 10;
            // 
            // lstKSuMiktari
            // 
            this.lstKSuMiktari.FormattingEnabled = true;
            this.lstKSuMiktari.ItemHeight = 15;
            this.lstKSuMiktari.Location = new System.Drawing.Point(130, 250);
            this.lstKSuMiktari.Name = "lstKSuMiktari";
            this.lstKSuMiktari.Size = new System.Drawing.Size(102, 229);
            this.lstKSuMiktari.TabIndex = 11;
            // 
            // lstFaturaTutari
            // 
            this.lstFaturaTutari.FormattingEnabled = true;
            this.lstFaturaTutari.ItemHeight = 15;
            this.lstFaturaTutari.Location = new System.Drawing.Point(255, 250);
            this.lstFaturaTutari.Name = "lstFaturaTutari";
            this.lstFaturaTutari.Size = new System.Drawing.Size(102, 229);
            this.lstFaturaTutari.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Ad Soyad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(127, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Kul. Su Miktarı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(252, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Fatura Tutarı";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbMesken);
            this.groupBox1.Controls.Add(this.rbUmumi);
            this.groupBox1.Location = new System.Drawing.Point(40, 152);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 45);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanım Yeri";
            // 
            // rbUmumi
            // 
            this.rbUmumi.AutoSize = true;
            this.rbUmumi.Location = new System.Drawing.Point(71, 19);
            this.rbUmumi.Name = "rbUmumi";
            this.rbUmumi.Size = new System.Drawing.Size(55, 19);
            this.rbUmumi.TabIndex = 0;
            this.rbUmumi.TabStop = true;
            this.rbUmumi.Text = "Umumi";
            this.rbUmumi.UseVisualStyleBackColor = true;
            // 
            // rbMesken
            // 
            this.rbMesken.AutoSize = true;
            this.rbMesken.Location = new System.Drawing.Point(181, 19);
            this.rbMesken.Name = "rbMesken";
            this.rbMesken.Size = new System.Drawing.Size(58, 19);
            this.rbMesken.TabIndex = 1;
            this.rbMesken.TabStop = true;
            this.rbMesken.Text = "Mesken";
            this.rbMesken.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 502);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lstFaturaTutari);
            this.Controls.Add(this.lstKSuMiktari);
            this.Controls.Add(this.lstAdSoyad);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIlkIndex);
            this.Controls.Add(this.txtSonIndex);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAd);
            this.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Su Faturası";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSonIndex;
        private System.Windows.Forms.TextBox txtIlkIndex;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lstAdSoyad;
        private System.Windows.Forms.ListBox lstKSuMiktari;
        private System.Windows.Forms.ListBox lstFaturaTutari;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbMesken;
        private System.Windows.Forms.RadioButton rbUmumi;
    }
}

