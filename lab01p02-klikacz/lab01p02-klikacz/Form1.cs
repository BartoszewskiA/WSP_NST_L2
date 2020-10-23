using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab01p02_klikacz
{
    public partial class Form1 : Form
    {
        int ile = 0;

        public Form1()
        {
            InitializeComponent();
            label1.Text = ile.ToString();
            pokoloruj();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ile++;
            label1.Text = ile.ToString();
            pokoloruj();
        }

        private void pokoloruj()
        {
            if (ile > 0) label1.ForeColor = Color.Green;
            else if (ile == 0) label1.ForeColor = Color.Black;
            else label1.ForeColor = Color.Red;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ile--;
            label1.Text = ile.ToString();
            pokoloruj();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ile = 0;
            label1.Text = ile.ToString();
            pokoloruj();
        }
    }
}
