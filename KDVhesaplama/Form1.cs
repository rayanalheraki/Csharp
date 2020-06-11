using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace soru_1
{
    /*
     *   KDV hesaplayan program
     */
    public partial class Form1 : Form
    {
        public string NewLine { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //sadece harflar ve space yazabilmek icin

            if (!char.IsControl(e.KeyChar)&& !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //sadece harflar ve space yazabilmek icin
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            //sadece rakamlar yazabilmek icin

            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        float kdv_mektari;
        float toplam;
        float tutar;
        private void Button1_Click(object sender, EventArgs e)
        {

            //ad ve soyad ve telefon adres textbox'una yazdirma

            textBox5.Text = textBox1.Text + " " + textBox2.Text 
                            +Environment.NewLine+ textBox3.Text ;

            //tutar, taksit sayisi ve KDV  bos olmamasi testi

            if (textBox4.Text=="") 
            {
                MessageBox.Show("Tutar giriniz lutfen.");
                return; 
            }
            if(KDV18.Checked==false && KDV8.Checked==false)
            {
                MessageBox.Show("KDV seciniz.");
                return;
            }
            if(taksit_sayisi.SelectedItem ==null)
            {
                MessageBox.Show("taksit sayisi giriniz seciniz.");
                return;               
            }

            //toplam ve taksit miktari hesaplama ve yazdirma

            tutar = float.Parse(textBox4.Text);
            
            if (KDV8.Checked==true)
            {
                kdv_mektari = (tutar * 8 / 100);
                toplam = tutar + kdv_mektari;
                lable_toplam.Text = toplam.ToString();
                
            }
            else if(KDV18.Checked==true)
            {
                //toplam icin 
                kdv_mektari = (tutar * 18 / 100);           
                toplam = tutar + kdv_mektari ;
                lable_toplam.Text = toplam.ToString();
                
            }
            //taksit miktari icin 
            float tmiktari = toplam / Int16.Parse(taksit_sayisi.SelectedItem.ToString());
            lable_taksit.Text = tmiktari.ToString();
        }

        private void KDV8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            //numaralar ve nokta yazabilmek icin
            if (!char.IsControl(e.KeyChar)  && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            //noktayi bir kere yazabilmek icin
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }
    }
}
