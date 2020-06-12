using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

//g171210556
namespace öd2
{
   
    public partial class Form2 : Form
    {
       
        
        public Form2()
        {
            InitializeComponent();
            genel.renkler[0] = "kırmızı";
            genel.renkler[1] = "mavi";
            genel.renkler[2] = "yesil";
            //comboBox seçenekleri 
            comboBox1.Items.AddRange(genel.renkler);      
            comboBox2.Items.AddRange(genel.renkler);
            comboBox3.Items.AddRange(genel.renkler);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string harf1, harf2, harf3;
            //1.harf
            if (comboBox1.Text== genel.renkler[0])
            {
                harf1 = "k";
            }else if(comboBox1.Text == genel.renkler[1])
            {
                harf1 = "m";
            }else if(comboBox1.Text == genel.renkler[2])
            {
                harf1 = "y";
            }else
            {
                harf1 = ".";
            }
            //3.harf

            if (comboBox2.Text == genel.renkler[0])
            {
                harf2 = "k";
            }
            else if (comboBox2.Text == genel.renkler[1])
            {
                harf2 = "m";
            }
            else if (comboBox2.Text == genel.renkler[2])
            {
                harf2 = "y";
            }
            else
            {
                harf2 = ".";
            }

            //3.harf
            if (comboBox3.Text == genel.renkler[0])
            {
                harf3 = "k";
            }
            else if (comboBox3.Text == genel.renkler[1])
            {
                harf3 = "m";
            }
            else if (comboBox3.Text == genel.renkler[2])
            {
                harf3 = "y";
            }
            else
            {
                harf3 = ".";
            }

            FileStream dosya = new FileStream("veriler.txt",FileMode.Append);
            StreamWriter kayitEkleme = new StreamWriter(dosya);

            kayitEkleme.Write(" "+harf1 + harf2 + harf3 + " " + textBox1.Text + " " + textBox2.Text + " " + textBox3.Text+ "\r\n");

            kayitEkleme.Close();
            
            MessageBox.Show("basariyla eklendi :)");
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        
        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    class genel
    {
        public static string[] renkler = new string[3];
    }
}
