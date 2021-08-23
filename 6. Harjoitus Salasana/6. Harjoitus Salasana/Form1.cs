using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6._Harjoitus_Salasana
{
    public partial class SalasanaForm : Form
    {
        public SalasanaForm()
        {
            InitializeComponent();
        }

        private void TarkistaTB_Click(object sender, EventArgs e)
        {
            if(KayttajaTB.Text == "MicoStrom" && SalasanaTB.Text == "Ilmarisentie18")
            {
                SalasanaPanel.Visible = false;
                SalasanaOikeinPanel.Visible = true;
            }
            else
            {
                VirheviestiLB.Text = "Käyttäjätunnus tai salasana virheellinen!";
                VirheviestiLB.Visible = true;
            }
        }
    }
    }
