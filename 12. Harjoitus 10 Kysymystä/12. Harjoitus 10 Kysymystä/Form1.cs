﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12._Harjoitus_10_Kysymystä
{
    public partial class VastaulomakeForm : Form
    {
        int laskuri = 0;
        int oikein = 0;
        string[] oikeatvastaukset = new string[] { "A", "A", "A", "A", "A", "A", "A", "A", "A", "A" };
        string[] vastaukset = new string[10];
        public VastaulomakeForm()
        {
            InitializeComponent();
            VastausARB.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            VastausBRB.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            VastausCRB.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            VastausDRB.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
        }

        private void VastaulomakeForm_Load(object sender, EventArgs e)
        {

        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton && laskuri < 10)
            {
                RadioButton radioButton = (RadioButton)sender;
                vastaukset[laskuri] = radioButton.Text;
                laskuri++;
                KysymysLB.Text = "Vastaus " + laskuri + ". kysymykseen:";
            }
            else
            {
                VastausLB.Text = "";
                VastausARB.Enabled = false;
                VastausBRB.Enabled = false;
                VastausCRB.Enabled = false;
                VastausDRB.Enabled = false;
                for (int j = 0; j < 10; j++)
                {
                    if (vastaukset[j] == oikeatvastaukset[j])
                    {
                        oikein++;
                    }
                }
                VastausLB.Text = "Oikeita vastauksia oli: " + oikein;
                VastausLB.Visible = true;
            }
            TyhjaaVastaus();
        }
        private void TyhjaaVastaus()
        {
            if(VastausARB.Checked == true)
            {
                VastausARB.Checked = false;
                laskuri--;
            }
            if (VastausBRB.Checked == true)
            {
                VastausBRB.Checked = false;
                laskuri--;
            }
            if (VastausCRB.Checked == true)
            {
                VastausCRB.Checked = false;
                laskuri--;
            }
            if (VastausDRB.Checked == true)
            {
                VastausDRB.Checked = false;
                laskuri--;
            }
        }
    }
}
