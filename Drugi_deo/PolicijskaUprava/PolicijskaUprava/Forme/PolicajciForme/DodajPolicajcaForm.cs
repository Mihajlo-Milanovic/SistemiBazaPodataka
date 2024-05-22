using NHibernate.Type;
using PolicijskaUprava.Entiteti;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolicijskaUprava.Forme.PolicajciForme
{
    public partial class DodajPolicajcaForm : Form
    {
        int StanicaID;
        public DodajPolicajcaForm()
        {
            InitializeComponent();
        }
        public DodajPolicajcaForm(int stanicaID)
        {
            InitializeComponent();
            StanicaID = stanicaID;
            OnemoguciPolicajce();
            IzborPolicajca("PZaVanrednoSituacije");

        }

        void IzborPolicajca(string groupBoxName)
        {
            OnemoguciPolicajce();
            switch (groupBoxName)
            {
                case "PZaVanrednoSituacije":
                    gboxPZaVanredneSituacije.Enabled = true;
                    break;
                case "SkolskiPolicajac":
                    gboxSkolskiPolicajac.Enabled = true;
                    break;
                case "RadnikUUpravi":
                    gboxPolicajacUUpravi.Enabled = true;
                    break;
                case "PolicajacPozornik":
                    gboxPolicajacPozornik.Enabled = true;
                    break;
                case "PatrolniPolicajac":
                    gboxPatrolniPolicajac.Enabled = true;
                    break;
                default:

                    break;
            }

        }

        void OnemoguciPolicajce()
        {
            foreach (Control control in this.Controls)
            {
                if (control is GroupBox)
                {
                    GroupBox groupBox = (GroupBox)control;
                    if (groupBox.Name != "gbxTipoviPolicajaca" && groupBox.Name != "gboxPolicajac")
                        groupBox.Enabled = false;

                }
            }

        }

        private void btnSkolskiPolicajac_CheckedChanged(object sender, EventArgs e)
        {
            IzborPolicajca("SkolskiPolicajac");
        }

        private void btnPolicajacZaVanrednoSituacije_CheckedChanged(object sender, EventArgs e)
        {
            IzborPolicajca("PZaVanrednoSituacije");
        }

        private void btnRdnikUUpravi_CheckedChanged(object sender, EventArgs e)
        {
            IzborPolicajca("RadnikUUpravi");
        }

        private void btnPolicajacPozornik_CheckedChanged(object sender, EventArgs e)
        {
            IzborPolicajca("PolicajacPozornik");
        }

        private void btnPatrolniPolicajac_CheckedChanged(object sender, EventArgs e)
        {
            IzborPolicajca("PatrolniPolicajac");
        }

        private string DaZnamKojiJeGBox()
        {
            string gboxName = "gbox";
            foreach (Control control in gbxTipoviPolicajaca.Controls)
            {
                if (control is RadioButton)
                {
                    RadioButton radioButton = (RadioButton)control;

                    if (radioButton.Checked == true)
                        gboxName += radioButton.Tag.ToString();
                }
            }
            return gboxName;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            string gboxName = DaZnamKojiJeGBox();

            if (txtIme.Text == "" || txtImeRoditelja.Text == "" || txtPrezime.Text == "" || txtJMBG.Text == "" || txtAdresa.Text == ""
                 || (rbtPolicajac.Checked == false && rbtZamenik.Checked == false && rbtSef.Checked == false))
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show("Mora da se popune svi podaci za policajca!", "Poruka", buttons);
                return;
            }


            PolicijskaStanica stanica = DTOManager.VratiStanicu(StanicaID);

            if (stanica == null)
            {
                MessageBoxButtons buttonss = MessageBoxButtons.OK;
                DialogResult resultt = MessageBox.Show("Greska prilikom uzimanja stanice", "Poruka", buttonss);
                return;
            }


            Policajac policajac;

            try
            {

                policajac = new();
                switch (gboxName)
                {
                    case "gboxPZaVanrednoSituacije":

                        policajac = new PZaVanredneSituacije();

                        policajac.Tip = "POLICAJAC ZA VANREDNE SITUACIJE";
                        ((PZaVanredneSituacije)policajac).Kurs = txtKurs.Text;
                        ((PZaVanredneSituacije)policajac).Vestina = txtVestina.Text;
                        ((PZaVanredneSituacije)policajac).Datum_zavrsetka_kursa = DateTime.Now;
                        ((PZaVanredneSituacije)policajac).Sertifikat = txtSertifikat.Text;
                        ((PZaVanredneSituacije)policajac).Datum_sticanja_sertifikata = DateTime.Now;
                        break;


                    case "gboxSkolskiPolicajac":

                        policajac = new SkolskiPolicajac();
                        policajac.Tip = "SKOLSKI POLICAJAC";
                        ((SkolskiPolicajac)policajac).NazivSkole = txtNazivSkole.Text;
                        ((SkolskiPolicajac)policajac).TipSkole = txtTipSkole.Text;
                        ((SkolskiPolicajac)policajac).AdresaSkole = txtAdresaSkole.Text;
                        ((SkolskiPolicajac)policajac).KontaktIme = txtKontaktIme.Text;
                        ((SkolskiPolicajac)policajac).KontaktPrezime = txtKontaktPrezime.Text;
                        ((SkolskiPolicajac)policajac).TelefonSkole = txtTelefonSkole.Text;
                        break;


                    case "gboxRadnikUUpravi":

                        policajac = new RadnikUUpravi();
                        policajac.Tip = "RADNIK U UPRAVI";

                        ((RadnikUUpravi)policajac).Pozicija = txtPozicija.Text;

                        break;


                    case "gboxPolicajacPozornik":

                        policajac.Tip = "POLICAJAC POZORNIK";
                        policajac = new PolicajacPozornik();
                        ((PolicajacPozornik)policajac).NazivUlice = txtNazivUlice.Text;
                        break;


                    case "gboxPatrolniPolicajac":

                        policajac.Tip = "PATROLNI POZORNIK";
                        policajac = new PatrolniPolicajac();
                        ((PatrolniPolicajac)policajac).VrstaOruzja = txtVrstaOruzija.Text;
                        break;


                    default:

                        MessageBox.Show("Greska kod case za gbox****");
                        break;
                }


                policajac.Ime = txtIme.Text;
                policajac.ImeRoditelja = txtImeRoditelja.Text;
                policajac.Prezime = txtPrezime.Text;
                policajac.DatumRodjenja = dtpDatumRodjenja.Value;
                policajac.JMBG = txtJMBG.Text;
                policajac.Adresa = txtAdresa.Text;
                policajac.DatumPrijemaUSluzbu = dtpDatumPrijemaUSluzbu.Value;
                policajac.Stanica = stanica;
                policajac.SefujeStanicom = rbtSef.Checked == true ? stanica : null;
                policajac.ZamenikStanice = rbtZamenik.Checked == true ? stanica : null;

                if (DTOManager.DodajPolicajca(policajac))
                {
                    MessageBoxButtons buttonsss = MessageBoxButtons.OK;
                    DialogResult resulttt = MessageBox.Show("Uspesno je dodat policajac!", "Poruka", buttonsss);
                }
                else
                {
                    MessageBoxButtons buttonsss = MessageBoxButtons.OK;
                    DialogResult resulttt = MessageBox.Show("Greska prilikom upisivanja policajca u bazu!", "Poruka", buttonsss);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.FormatExceptionMessage());
            }
        }
    }
}
