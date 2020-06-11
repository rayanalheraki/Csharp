using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace soru_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }
        //genel fiyat degiskeni 
        float fiyat;
        private void Button1_Click(object sender, EventArgs e)
        {
            
            if(comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Araç türü seçiniz");
                return;
            }
            //arac turune gore fiyat secme
            if (comboBox1.SelectedItem.ToString() == "Otomobil") fiyat = 50;
            if (comboBox1.SelectedItem.ToString() == "Minivan" ) fiyat = 72;
            //fiyat artirma saritlari 
            if(Yas1825.Checked==true) fiyat = fiyat + (fiyat * 20 / 100);
            if(eksurucu.Checked==true) fiyat = fiyat + 35;
            if(navigasyon.Checked==true) fiyat = fiyat + 55;
            if(cocukkoltuk.Checked==true) fiyat = fiyat + 80;

            textBox1.Text = fiyat.ToString()+" TL";
        }
    }
}
