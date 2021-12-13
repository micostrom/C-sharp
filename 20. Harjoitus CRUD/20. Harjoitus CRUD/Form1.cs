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
    // Tämän luokan avulla määritetään nappien tehtävät
    public partial class Form1 : Form
    {
        // Luodaan uusi 
        OPISKELIJA opiskelija = new OPISKELIJA();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TietotauluDG.DataSource = opiskelija.haeOpiskelijat();
        }

        // Taulukon tyhjennys
        private void TyhjennaBT_Click(object sender, EventArgs e)
        {
            IDTB.Text = "";
            EtunimiTB.Text = "";
            SukunimiTB.Text = "";
            PuhelinTB.Text = "";
            SahkopostiTB.Text = "";
            OpiskelijanroTB.Text = "";


        }

        // Taulukon tallennus
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
                Boolean lisaaAsiakas = opiskelija.lisaaOpiskelija(enimi, snimi, puhelin, email, oNro);
                if (lisaaAsiakas)
                {
                    MessageBox.Show("Uusi opiskelija lisätty onnistuneesti", "Opiskelijan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Uutta opiskelijaa ei pystytty lisäämään", "Opiskelijan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            TietotauluDG.DataSource = opiskelija.haeOpiskelijat();
        }
        // Nappi opiskelijan tietojen päivttämiseksi
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
                Boolean lisaaAsiakas = opiskelija.muokkaaOpiskelijaa( oid, enimi, snimi, puhelin, email, oNro);
                if (lisaaAsiakas)
                {
                    MessageBox.Show("Opiskelija päivitetty onnistuneesti", "Opiskleijan päivitys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Opiskelijaa ei pystytty päivittävmään onnistuneesti", "Opiskelijan päivitys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            TietotauluDG.DataSource = opiskelija.haeOpiskelijat();
        }
        // Luodaan nappi opiskelijoiden poistamiseksi
        private void PoistaBT_Click(object sender, EventArgs e)
        {
            string ktunnus = IDTB.Text;
            if (opiskelija.poistaOpiskelija(ktunnus))
            {
                TietotauluDG.DataSource = opiskelija.haeOpiskelijat();
                MessageBox.Show("Opiskelija poistettu onnistuneesti", "Opiskelijan poisto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Opiskelijaa ei pystytty poistamaan", "Opiskelijan poisto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            TyhjennaBT.PerformClick();
        }
        // napauttamastasi kentästä siiryy nimi, sukunimi yms. oikeille paikoille taulukkoon
        private void TietotauluDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IDTB.Text = TietotauluDG.CurrentRow.Cells[0].Value.ToString();
            EtunimiTB.Text = TietotauluDG.CurrentRow.Cells[1].Value.ToString();
            SukunimiTB.Text = TietotauluDG.CurrentRow.Cells[2].Value.ToString();
            PuhelinTB.Text = TietotauluDG.CurrentRow.Cells[3].Value.ToString();
            SahkopostiTB.Text = TietotauluDG.CurrentRow.Cells[4].Value.ToString();
            OpiskelijanroTB.Text = TietotauluDG.CurrentRow.Cells[5].Value.ToString();
        }
    }
}