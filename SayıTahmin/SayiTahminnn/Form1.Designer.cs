
namespace SayiTahminnn
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
            this.txtSayiTahmin = new System.Windows.Forms.TextBox();
            this.btnSayiTahmin = new System.Windows.Forms.Button();
            this.lblKalanHak = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSayiTahmin
            // 
            this.txtSayiTahmin.Location = new System.Drawing.Point(68, 80);
            this.txtSayiTahmin.Name = "txtSayiTahmin";
            this.txtSayiTahmin.Size = new System.Drawing.Size(211, 20);
            this.txtSayiTahmin.TabIndex = 0;
            // 
            // btnSayiTahmin
            // 
            this.btnSayiTahmin.Location = new System.Drawing.Point(68, 133);
            this.btnSayiTahmin.Name = "btnSayiTahmin";
            this.btnSayiTahmin.Size = new System.Drawing.Size(224, 46);
            this.btnSayiTahmin.TabIndex = 1;
            this.btnSayiTahmin.Text = "Tahmin Et";
            this.btnSayiTahmin.UseVisualStyleBackColor = true;
            this.btnSayiTahmin.Click += new System.EventHandler(this.btnSayiTahmin_Click);
            // 
            // lblKalanHak
            // 
            this.lblKalanHak.AutoSize = true;
            this.lblKalanHak.Location = new System.Drawing.Point(279, 224);
            this.lblKalanHak.Name = "lblKalanHak";
            this.lblKalanHak.Size = new System.Drawing.Size(0, 13);
            this.lblKalanHak.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(327, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 43);
            this.button1.TabIndex = 4;
            this.button1.Text = "sayı üret";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 335);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblKalanHak);
            this.Controls.Add(this.btnSayiTahmin);
            this.Controls.Add(this.txtSayiTahmin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSayiTahmin;
        private System.Windows.Forms.Button btnSayiTahmin;
        private System.Windows.Forms.Label lblKalanHak;
        private System.Windows.Forms.Button button1;
    }
}

