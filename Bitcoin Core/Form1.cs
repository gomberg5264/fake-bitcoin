using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bitcoin_Core
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Hide inputs on initial load
            textBox1.Hide();
            numericUpDown1.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Nav_Overview Click
            this.BackgroundImage = new Bitmap(@"./images/bit11.png");

            textBox1.Hide();
            numericUpDown1.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Nav_Send Click
            this.BackgroundImage = new Bitmap(@"./images/bit21.png");

            textBox1.Show();
            numericUpDown1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Send Clicked
        }
    }
}
