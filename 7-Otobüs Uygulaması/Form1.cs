using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7_Otobüs_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 muavin = new Form2();
            muavin.Show();
            this.Hide();
                 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 yolcu = new Form3();
            yolcu.Show();
            this.Hide();
        }
    }
}
