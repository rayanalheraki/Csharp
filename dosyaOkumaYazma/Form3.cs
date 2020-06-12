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
    public partial class Form3 : Form
    {
       
        public void bold(string x)
        {
            int s1 = richTextBox1.Text.IndexOf(x);
            int s2 = x.Length;
            richTextBox1.Select(s1, s2);
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Bold);
        }
        public void regular(string x)
        {
            int s1 = richTextBox1.Text.IndexOf(x);
            int s2 = x.Length;
            richTextBox1.Select(s1, s2);
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Regular);
        }
        public void kirmizi(string x)
        {
            int c1 = richTextBox1.Text.IndexOf(x);
            int c2 = x.Length;
            richTextBox1.Select(c1, c2);
            richTextBox1.SelectionColor = Color.Red;
        }
        public void mavi(string x)
        {
            int e1 = richTextBox1.Text.IndexOf(x);
            int e2 = x.Length;
            richTextBox1.Select(e1,e2);
            richTextBox1.SelectionColor = Color.Blue;
        }
        public void yesil(string x)
        {
            int y1 = richTextBox1.Text.IndexOf(x);
            int y2 = x.Length;
            richTextBox1.Select(y1,y2);
            richTextBox1.SelectionColor = Color.Green;
        }
        

        public Form3()
        {
            InitializeComponent();

            FileStream dosya1 = new FileStream("veriler.txt", FileMode.Open);
            StreamReader kayitlistme = new StreamReader(dosya1);
            string metin = kayitlistme.ReadToEnd();

            string[] split = metin.Split(' ');

            richTextBox1.Text = "";

            int sayac = 1;
            for (int i = 1; i < split.Length; i++)
            {
                if (i != sayac)
                {
                    richTextBox1.Text += " "+split[i];
                }

                else if (i == sayac)
                {
                    sayac += 4;
                }
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
