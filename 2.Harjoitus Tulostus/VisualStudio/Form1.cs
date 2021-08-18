using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualStudio
{
    public partial class NappulaBT : Form
    {
        public NappulaBT()
        {
            InitializeComponent();
        }

        private void NappiBT_Click(object sender, EventArgs e)
        {
            string teksti = TekstiTB.Text;
            ToinenLB.Text = teksti;
            ToinenLB.Visible = true;
        }
    }
}
