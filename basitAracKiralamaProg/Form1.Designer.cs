namespace soru_2
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cocukkoltuk = new System.Windows.Forms.CheckBox();
            this.navigasyon = new System.Windows.Forms.CheckBox();
            this.eksurucu = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Yas26 = new System.Windows.Forms.RadioButton();
            this.Yas1825 = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Otomobil",
            "Minivan"});
            this.comboBox1.Location = new System.Drawing.Point(32, 41);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(131, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cocukkoltuk);
            this.panel1.Controls.Add(this.navigasyon);
            this.panel1.Controls.Add(this.eksurucu);
            this.panel1.Location = new System.Drawing.Point(349, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(142, 103);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // cocukkoltuk
            // 
            this.cocukkoltuk.AutoSize = true;
            this.cocukkoltuk.Location = new System.Drawing.Point(16, 67);
            this.cocukkoltuk.Name = "cocukkoltuk";
            this.cocukkoltuk.Size = new System.Drawing.Size(119, 21);
            this.cocukkoltuk.TabIndex = 6;
            this.cocukkoltuk.Text = "Çocuk koltuğu";
            this.cocukkoltuk.UseVisualStyleBackColor = true;
            this.cocukkoltuk.CheckedChanged += new System.EventHandler(this.CheckBox3_CheckedChanged);
            // 
            // navigasyon
            // 
            this.navigasyon.AutoSize = true;
            this.navigasyon.Location = new System.Drawing.Point(16, 40);
            this.navigasyon.Name = "navigasyon";
            this.navigasyon.Size = new System.Drawing.Size(101, 21);
            this.navigasyon.TabIndex = 5;
            this.navigasyon.Text = "Navigasyon";
            this.navigasyon.UseVisualStyleBackColor = true;
            this.navigasyon.CheckedChanged += new System.EventHandler(this.CheckBox2_CheckedChanged);
            // 
            // eksurucu
            // 
            this.eksurucu.AutoSize = true;
            this.eksurucu.Location = new System.Drawing.Point(16, 13);
            this.eksurucu.Name = "eksurucu";
            this.eksurucu.Size = new System.Drawing.Size(91, 21);
            this.eksurucu.TabIndex = 4;
            this.eksurucu.Text = "Ek sürücü";
            this.eksurucu.UseVisualStyleBackColor = true;
            this.eksurucu.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = " Sürücü Yaş";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(204, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 36);
            this.button1.TabIndex = 9;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ödenecek Tutar";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(178, 160);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 24);
            this.textBox1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Yas26);
            this.panel2.Controls.Add(this.Yas1825);
            this.panel2.Location = new System.Drawing.Point(204, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(123, 63);
            this.panel2.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "EK Seçenekler";
            // 
            // Yas26
            // 
            this.Yas26.AutoSize = true;
            this.Yas26.Location = new System.Drawing.Point(8, 32);
            this.Yas26.Name = "Yas26";
            this.Yas26.Size = new System.Drawing.Size(55, 21);
            this.Yas26.TabIndex = 7;
            this.Yas26.TabStop = true;
            this.Yas26.Text = "26+";
            this.Yas26.UseVisualStyleBackColor = true;
            // 
            // Yas1825
            // 
            this.Yas1825.AutoSize = true;
            this.Yas1825.Location = new System.Drawing.Point(8, 5);
            this.Yas1825.Name = "Yas1825";
            this.Yas1825.Size = new System.Drawing.Size(74, 21);
            this.Yas1825.TabIndex = 6;
            this.Yas1825.TabStop = true;
            this.Yas1825.Text = "18 - 25";
            this.Yas1825.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 217);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cocukkoltuk;
        private System.Windows.Forms.CheckBox navigasyon;
        private System.Windows.Forms.CheckBox eksurucu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton Yas26;
        private System.Windows.Forms.RadioButton Yas1825;
        private System.Windows.Forms.Label label2;
    }
}

