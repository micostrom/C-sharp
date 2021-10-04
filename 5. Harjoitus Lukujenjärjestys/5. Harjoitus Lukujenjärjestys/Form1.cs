using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5._Harjoitus_Lukujenjärjestys
{
    public partial class Lukujenjarjestys : Form
    {
        List<int> jono = new List<int>();
        public Lukujenjarjestys()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (UusilukuTB.Text == "-999")
                {
                    VastausLB.Text = "";
                    int[] taulukko = jono.ToArray();
                    Array.Sort(taulukko);
                    foreach (var jasen in taulukko)
                    {
                        VastausLB.Text += jasen + " ";
                    }
                    VastausLB.Visible = true;
                }
                else
                {
                    jono.Add(Int32.Parse(UusilukuTB.Text));
                    UusilukuTB.Text = "";
                }
            }
        }
    }
}