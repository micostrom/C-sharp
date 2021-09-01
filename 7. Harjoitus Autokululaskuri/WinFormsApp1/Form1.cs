using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void KilmoteriCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            double laina, nesteet, vakuutus, pesut, huollot, renkaat, muut, kilometrit, polttoneste, kustannukset;
            laina = Convert.ToDouble(LainaTB.Text);
            nesteet = Convert.ToDouble(NesteetTB.Text);
            vakuutus = Convert.ToDouble(VakuutusTB.Text);
            pesut = Convert.ToDouble(PesutTB.Text);
            huollot = Convert.ToDouble(HuollotTB.Text);
            renkaat = Convert.ToDouble(RenkaatTB.Text);
            muut = Convert.ToDouble(MuutTB.Text);
            polttoneste = Convert.ToDouble(PolttoaineTB.Text);
            kilometrit = Convert.ToDouble(KilmoteriCB.Text);
            kustannukset = (laina + nesteet + vakuutus + pesut + huollot + renkaat + muut + polttoneste) / (kilometrit / 12);
            VastausLB.Text = "Kustannukset kilometriä kohti ovat :" + kustannukset;
            VastausLB.Visible = true;
        }
    }
}
