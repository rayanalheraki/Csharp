namespace soru_1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.KDV8 = new System.Windows.Forms.RadioButton();
            this.KDV18 = new System.Windows.Forms.RadioButton();
            this.taksit_sayisi = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lable_toplam = new System.Windows.Forms.Label();
            this.lable_taksit = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(86, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 24);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox1_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(86, 89);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(204, 24);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox2_KeyPress);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(86, 151);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(204, 24);
            this.textBox3.TabIndex = 2;
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox3_KeyPress);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(86, 207);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(204, 24);
            this.textBox4.TabIndex = 3;
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox4_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Telefon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tutar";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(438, 69);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(302, 162);
            this.textBox5.TabIndex = 8;
            this.textBox5.TextChanged += new System.EventHandler(this.TextBox5_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(435, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Adres";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // KDV8
            // 
            this.KDV8.AutoSize = true;
            this.KDV8.Location = new System.Drawing.Point(86, 265);
            this.KDV8.Name = "KDV8";
            this.KDV8.Size = new System.Drawing.Size(81, 21);
            this.KDV8.TabIndex = 10;
            this.KDV8.TabStop = true;
            this.KDV8.Text = "%8 KDV";
            this.KDV8.UseVisualStyleBackColor = true;
            this.KDV8.CheckedChanged += new System.EventHandler(this.KDV8_CheckedChanged);
            // 
            // KDV18
            // 
            this.KDV18.AutoSize = true;
            this.KDV18.Location = new System.Drawing.Point(86, 292);
            this.KDV18.Name = "KDV18";
            this.KDV18.Size = new System.Drawing.Size(89, 21);
            this.KDV18.TabIndex = 11;
            this.KDV18.TabStop = true;
            this.KDV18.Text = "%18 KDV";
            this.KDV18.UseVisualStyleBackColor = true;
            // 
            // taksit_sayisi
            // 
            this.taksit_sayisi.FormattingEnabled = true;
            this.taksit_sayisi.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.taksit_sayisi.Location = new System.Drawing.Point(438, 285);
            this.taksit_sayisi.Name = "taksit_sayisi";
            this.taksit_sayisi.Size = new System.Drawing.Size(121, 24);
            this.taksit_sayisi.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(328, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 39);
            this.button1.TabIndex = 13;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(435, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "taksit sayisi";
            // 
            // lable_toplam
            // 
            this.lable_toplam.AutoSize = true;
            this.lable_toplam.Location = new System.Drawing.Point(289, 404);
            this.lable_toplam.Name = "lable_toplam";
            this.lable_toplam.Size = new System.Drawing.Size(46, 17);
            this.lable_toplam.TabIndex = 15;
            this.lable_toplam.Text = "lable 1";
            this.lable_toplam.Click += new System.EventHandler(this.Label7_Click);
            // 
            // lable_taksit
            // 
            this.lable_taksit.AutoSize = true;
            this.lable_taksit.Location = new System.Drawing.Point(546, 404);
            this.lable_taksit.Name = "lable_taksit";
            this.lable_taksit.Size = new System.Drawing.Size(46, 17);
            this.lable_taksit.TabIndex = 16;
            this.lable_taksit.Text = "lable 2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(224, 404);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Toplam=";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(449, 404);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "Taksit Miktari= ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lable_taksit);
            this.Controls.Add(this.lable_toplam);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.taksit_sayisi);
            this.Controls.Add(this.KDV18);
            this.Controls.Add(this.KDV8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton KDV8;
        private System.Windows.Forms.RadioButton KDV18;
        private System.Windows.Forms.ComboBox taksit_sayisi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lable_toplam;
        private System.Windows.Forms.Label lable_taksit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

