using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4.Harjoitus
{
    public partial class Ikälaskuri : Form
    {
        public Ikälaskuri()
        {
            InitializeComponent();
        }

        private void LaskeBT_Click(object sender, EventArgs e)
        {
            DateTime synttari = SyntymaAikaDT.Value;
            DateTime nyt = DateTime.Now;
            double erotus = Math.Round((nyt - synttari).TotalDays);
            VuodetLB.Text = Math.Ceiling(erotus / 365.25) + " vuotta";
            KuukaudetLB.Text = Math.Ceiling(erotus * 12 / 365.12) + " kuukautta";
            PaivatLB.Text = (erotus + " päivää");
            TunnitLB.Text = (erotus * 24 + " tuntia");
            MinuutitLB.Text = (erotus * 24 * 60 + " minuuuttia");
            SekunnitLB.Text = (erotus * 24 * 3600 + "sekuntia");
            VuodetLB.Visible = true;
            KuukaudetLB.Visible = true;
            PaivatLB.Visible = true;
            TunnitLB.Visible = true;
            MinuutitLB.Visible = true;
            SekunnitLB.Visible = true;
        }
    }
}
