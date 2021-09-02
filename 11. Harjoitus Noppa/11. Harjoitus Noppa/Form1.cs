using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11.Harjoitus_Noppa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void HeitaBT_Click(object sender, EventArgs e)
        {
            piirraNoppa(Noppa01BT);
            piirraNoppa(Noppa02PB);
        }
        private void piirraNoppa(PictureBox Noppabox)
        {
            Random satunnainen = new Random();
            int noppa = satunnainen.Next(1, 7);
            switch (noppa)
            {
                case 1:
                    Noppabox.Image = Properties.Resources.Noppa1;
                    break;
                case 2:
                    Noppabox.Image = Properties.Resources.Noppa2;
                    break;
                case 3:
                    Noppabox.Image = Properties.Resources.Noppa3;
                    break;
                case 4:
                    Noppabox.Image = Properties.Resources.Noppa4;
                    break;
                case 5:
                    Noppabox.Image = Properties.Resources.Noppa5;
                    break;
                case 6:
                    Noppabox.Image = Properties.Resources.Noppa6;
                    break;


            }
        }
    }
}
