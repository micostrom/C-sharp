using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20.Harjoitus_CRUD
{
    public partial class Form1 : Form
    {
        OPISKELIJA joulupukki = new OPISKELIJA();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TietotauluDG.DataSource = joulupukki.HaeOpiskelijat();
        }

        private void TyhjennaBT_Click(object sender, EventArgs e)
        {
            IDTB.Text = "";
            EtunimiTB.Text = "";
            SukunimiTB.Text = "";
            PuhelinTB.Text = "";
            SahkopostiTB.Text = "";
            OpiskelijanroTB.Text = "";


        }

        private void TallennaBT_Click(object sender, EventArgs e)
        {
            string enimi = EtunimiTB.Text;
            string snimi = SukunimiTB.Text;
            string puhelin = PuhelinTB.Text;
            string email = SahkopostiTB.Text;
            int oNro = Int32.Parse(OpiskelijanroTB.Text);

            if (enimi.Trim().Equals("") || snimi.Trim().Equals("") || puhelin.Trim().Equals("") || email.Trim().Equals("") || oNro.Equals(""))
            {
                MessageBox.Show("VIRHE - Vaaditut kentät- Etu- ja sukunimi, puhelin, sähköposti ja opiskelijanumero", "Tyhjä kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Boolean lisaaAsiakas = joulupukki.LisaaOpiskelija(enimi, snimi, puhelin, email, oNro);
                if (lisaaAsiakas)
                {
                    MessageBox.Show("Uusi opiskelija lisätty onnistuneesti", "Opiskelijan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Uutta opiskelijaa ei pystytty lisäämään", "Opiskelijan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            TietotauluDG.DataSource = joulupukki.HaeOpiskelijat();
        }

        private void PaivitaBT_Click(object sender, EventArgs e)
        {
            string enimi = EtunimiTB.Text;
            string snimi = SukunimiTB.Text;
            string puhelin = PuhelinTB.Text;
            string email = SahkopostiTB.Text;
            int oNro = Int32.Parse(OpiskelijanroTB.Text);
            int oid = Int32.Parse(IDTB.Text);

            if (oid.Equals("") || enimi.Trim().Equals("") || snimi.Trim().Equals("") || email.Trim().Equals("") || oNro.Equals(""))
            {
                MessageBox.Show("VIRHE - vaaditut kentät - ID, Etu- ja sukunimi, puhelin, sähköposti ja opiskelijanumero", "Tyhjä kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Boolean lisaaAsiakas = joulupukki.muokkaaOpiskelijaa(oid, enimi, snimi, puhelin, email, oNro);
                if (lisaaAsiakas)
                {
                    MessageBox.Show("Opiskelija päivitetty onnistuneesti", "Opiskleijan päivitys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Opiskelijaa ei pystytty päivittävmään onnistuneesti", "Opiskelijan päivitys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void PoistaBT_Click(object sender, EventArgs e)
        {
            string enimi = EtunimiTB.Text;
            string snimi = SukunimiTB.Text;
            string puhelin = PuhelinTB.Text;
            string email = SahkopostiTB.Text;
            int oNro = Int32.Parse(OpiskelijanroTB.Text);
            int oid = Int32.Parse(IDTB.Text);
        }
    }
}
