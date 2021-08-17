using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1p03_przelicznik
{
    public partial class Form1 : Form
    {
        int pln = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            pln = hScrollBar1.Value;
            label1.Text = pln.ToString() + " PLN";
        }
    }
}
