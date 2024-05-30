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
    public partial class AzurirajPolicajcaForm : Form
    {
        public Policajac Policajac;
        public AzurirajPolicajcaForm()
        {
            InitializeComponent();
        }
        public AzurirajPolicajcaForm(int policajacId)
        {
            InitializeComponent();
            Policajac = DTOManager.VratiPolicajca(policajacId);
            PopuniPodatke();
        }

        public void PopuniPodatke()
        {
            string Tip = Policajac.Tip;
            ZabraniPristipSvimaOsim(Tip);

            txtIme.Text = Policajac.Ime;
            txtImeRoditelja.Text = Policajac.ImeRoditelja;
            txtPrezime.Text = Policajac.Prezime;
            dtpDatumRodjenja.Value = Policajac.DatumRodjenja;
            txtJMBG.Text = Policajac.JMBG;
            txtAdresa.Text = Policajac.Adresa;
            dtpDatumPrijemaUSluzbu.Value = Policajac.DatumPrijemaUSluzbu;
            //chbSef.Checked = Policajac.SefujeStanicom == null ? false : true;
            //chbZamenik.Checked = Policajac.ZamenikStanice == null ? false : true;

            switch (Tip)
            {
                case "POLICAJAC ZA VANREDNE SITUACIJE":
                    txtKurs.Text = ((PZaVanredneSituacije)Policajac).Kurs;
                    txtVestina.Text = ((PZaVanredneSituacije)Policajac).Vestina;
                    dtpDatumZavrsetkaKursa.Value = ((PZaVanredneSituacije)Policajac).DatumZavrsetkaKursa;
                    txtSertifikat.Text = ((PZaVanredneSituacije)Policajac).Sertifikat;
                    dtpDatumSticanjaSertifikata.Value = ((PZaVanredneSituacije)Policajac).DatumSticanjaSertifikata;
                    break;

                case "SKOLSKI POLICAJAC":
                    txtNazivSkole.Text = ((SkolskiPolicajac)Policajac).NazivSkole;
                    txtTipSkole.Text = ((SkolskiPolicajac)Policajac).TipSkole;
                    txtAdresaSkole.Text = ((SkolskiPolicajac)Policajac).AdresaSkole;
                    txtKontaktIme.Text = ((SkolskiPolicajac)Policajac).KontaktIme;
                    txtKontaktPrezime.Text = ((SkolskiPolicajac)Policajac).KontaktPrezime;
                    txtTelefonSkole.Text = ((SkolskiPolicajac)Policajac).TelefonSkole;
                    break;

                case "POLICAJAC POZORNIK":
                    txtNazivUlice.Text = ((PolicajacPozornik)Policajac).NazivUlice;
                    break;

                case "RADNIK U UPRAVI":
                    txtPozicija.Text = ((RadnikUUpravi)Policajac).Pozicija;
                    break;

                case "PATROLNI POLICAJAC":
                    txtVrstaOruzija.Text = ((PatrolniPolicajac)Policajac).VrstaOruzja;
                    break;


            }
        }
        public void ZabraniPristipSvimaOsim(string Tip)
        {

            foreach (Control control in this.Controls)
            {
                if (control is System.Windows.Forms.GroupBox)
                {
                    System.Windows.Forms.GroupBox groupBox = (System.Windows.Forms.GroupBox)control;
                    if (groupBox.Name != "gboxPolicajac")
                        groupBox.Enabled = false;

                }
            }
            switch (Tip)
            {
                case "POLICAJAC ZA VANREDNE SITUACIJE":
                    gboxPZaVanredneSituacije.Enabled = true;
                    break;

                case "SKOLSKI POLICAJAC":
                    gboxSkolskiPolicajac.Enabled = true;
                    break;

                case "POLICAJAC POZORNIK":
                    gboxPolicajacPozornik.Enabled = true;
                    break;

                case "RADNIK U UPRAVI":
                    gboxPolicajacUUpravi.Enabled = true;
                    break;

                case "PATROLNI POLICAJAC":
                    gboxPatrolniPolicajac.Enabled = true;
                    break;


            }
        }
        private string DaZnamKojiJeGBox()
        {

            foreach (Control control in this.Controls)
            {
                if (control is GroupBox groupBox)
                {
                    if (groupBox.Enabled && groupBox.Name != "gboxPolicajac")
                    {
                        return groupBox.Name;
                    }
                }
            }
            return null;

        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            string gboxName = DaZnamKojiJeGBox();

            if (gboxName == null)
                return;

            if (txtIme.Text == "" || txtImeRoditelja.Text == "" || txtPrezime.Text == "" || txtJMBG.Text == "" || txtAdresa.Text == "")
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show("Mora da se popune svi podaci za policajca!", "Poruka", buttons);
                return;
            }
            //if (chbSef.Checked == true && DTOManager.ProveriDaliimaSefa(Policajac.Stanica.Id) != Policajac.Id)
            //{
            //    MessageBoxButtons buttons = MessageBoxButtons.OK;
            //    DialogResult result = MessageBox.Show("Stanica vec ima sefa!", "Poruka", buttons);
            //    return;
            //}



            try
            {

                switch (gboxName)
                {
                    case "gboxPZaVanredneSituacije":

                        ((PZaVanredneSituacije)Policajac).Kurs = txtKurs.Text;
                        ((PZaVanredneSituacije)Policajac).Vestina = txtVestina.Text;
                        ((PZaVanredneSituacije)Policajac).DatumZavrsetkaKursa = dtpDatumZavrsetkaKursa.Value;
                        ((PZaVanredneSituacije)Policajac).Sertifikat = txtSertifikat.Text;
                        ((PZaVanredneSituacije)Policajac).DatumSticanjaSertifikata = dtpDatumSticanjaSertifikata.Value;
                        break;


                    case "gboxSkolskiPolicajac":


                        ((SkolskiPolicajac)Policajac).NazivSkole = txtNazivSkole.Text;
                        ((SkolskiPolicajac)Policajac).TipSkole = txtTipSkole.Text;
                        ((SkolskiPolicajac)Policajac).AdresaSkole = txtAdresaSkole.Text;
                        ((SkolskiPolicajac)Policajac).KontaktIme = txtKontaktIme.Text;
                        ((SkolskiPolicajac)Policajac).KontaktPrezime = txtKontaktPrezime.Text;
                        ((SkolskiPolicajac)Policajac).TelefonSkole = txtTelefonSkole.Text;
                        break;


                    case "gboxPolicajacUUpravi":



                        ((RadnikUUpravi)Policajac).Pozicija = txtPozicija.Text;

                        break;


                    case "gboxPolicajacPozornik":

                        ((PolicajacPozornik)Policajac).NazivUlice = txtNazivUlice.Text;
                        break;


                    case "gboxPatrolniPolicajac":


                        ((PatrolniPolicajac)Policajac).VrstaOruzja = txtVrstaOruzija.Text;
                        break;


                    default:

                        MessageBox.Show("Greska kod case za gbox****");
                        break;
                }


                Policajac.Ime = txtIme.Text;
                Policajac.ImeRoditelja = txtImeRoditelja.Text;
                Policajac.Prezime = txtPrezime.Text;
                Policajac.DatumRodjenja = dtpDatumRodjenja.Value;
                Policajac.JMBG = txtJMBG.Text;
                Policajac.Adresa = txtAdresa.Text;
                Policajac.DatumPrijemaUSluzbu = dtpDatumPrijemaUSluzbu.Value;
                //Policajac.Stanica = Policajac.Stanica;
                Policajac.SefujeStanicom = null;// chbSef.Checked == true ? Policajac.Stanica : null;
                Policajac.ZamenikStanice = null;// chbZamenik.Checked == true ? Policajac.Stanica : null;

                if (DTOManager.UpdatePolicajca(Policajac))
                {
                    MessageBoxButtons buttonsss = MessageBoxButtons.OK;
                    DialogResult resulttt = MessageBox.Show("Uspesno je izmenjen policajac!", "Poruka", buttonsss);
                    this.Close();
                }
                else
                {
                    MessageBoxButtons buttonsss = MessageBoxButtons.OK;
                    DialogResult resulttt = MessageBox.Show("Greska prilikom izmene policajca u bazu!", "Poruka", buttonsss);

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.FormatExceptionMessage());
            }
        }

        //private void chbZamenik_CheckedChanged(object sender, EventArgs e)
        //{

        //    if (chbZamenik.Checked)
        //    {
        //        chbSef.Checked = false;
        //    }
        //}

        //private void chbSef_CheckedChanged(object sender, EventArgs e)
        //{

        //    if (chbSef.Checked)
        //    {
        //        chbZamenik.Checked = false;
        //    }
        //}
    }

}
