using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            const double CLASS2 = 53.00;    //value for 2nd class
            const double CLASS1 = 87.46;    //value for 1st class
            const double RAILRUN = 2.50;

            double theClass = 0;
            if (radioButton1.Checked)       //radio button 2nd class
                theClass = CLASS2;
            if (radioButton2.Checked)       //radio button 1st class
                theClass = CLASS1;

            int nrTickets = int.Parse(textBox1.Text);
            int nrRailRun = int.Parse(textBox2.Text);

            double price = nrTickets * theClass + nrRailRun * RAILRUN;

            textBox3.Text = price.ToString("0.00");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox3.ReadOnly = true;
        }
    }
}
