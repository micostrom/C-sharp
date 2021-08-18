using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.Harjoitus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LaskeBT_Click(object sender, EventArgs e)
        {
            float luku1, luku2, vastaus;
            string merkki;
            luku1 = float.Parse(LukuyksiTB.Text);
            luku2 = float.Parse(LukukaksiTB.Text);
            merkki = LaskutoimitusCB.Text;
            switch(merkki)
            {
                case "+":
                    vastaus = luku1 + luku2;
                    break;
                case "-":
                    vastaus = luku1 - luku2;
                    break;
                case "*":
                    vastaus = luku1 * luku2;
                    break;
                case "/":
                    vastaus = luku1 / luku2;
                    break;
                default:
                    vastaus = 0;
                    break;
            }
            VastausLB.Text = Convert.ToString(vastaus);
            VastausLB.Visible = true;
        }
    }
}
