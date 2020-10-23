using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab01p03_suwak
{
    public partial class Form1 : Form
    {
        int kwota = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            kwota = hScrollBar1.Value;
            label1.Text = kwota.ToString() + " PLN";
            label2.Text = (kwota / 4.5).ToString() + " EURO" ; 
        }
    }
}
