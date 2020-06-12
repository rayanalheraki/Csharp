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

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 kayitEkle = new Form2();
            kayitEkle.ShowDialog();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 kayitListeme = new Form3();
            kayitListeme.ShowDialog();
            Close();
        }
    }
}
