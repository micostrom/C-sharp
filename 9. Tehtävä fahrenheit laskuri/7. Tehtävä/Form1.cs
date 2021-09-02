using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7.Tehtävä
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MuunnaBT_Click(object sender, EventArgs e)
        {
            double c = 0.0, f = 0.0;
            f = Convert.ToDouble(FahrenheitTB.Text);
            c = (5.0 / 9) * (f - 32);
            CelsiuksetTB.Text = c.ToString();
        }
    }
}
