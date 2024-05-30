namespace PolicijskaUprava.Forme.PolicajciForme
{
    public partial class DodajPolicajcaForm : Form
    {
        int StanicaID;
       
        public DodajPolicajcaForm()
        {
            InitializeComponent();
            //StanicaID = stanicaID;
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
                if (control is System.Windows.Forms.GroupBox)
                {
                    System.Windows.Forms.GroupBox groupBox = (System.Windows.Forms.GroupBox)control;
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
                if (control is System.Windows.Forms.RadioButton)
                {
                    System.Windows.Forms.RadioButton radioButton = (System.Windows.Forms.RadioButton)control;

                    if (radioButton.Checked == true)
                        gboxName += radioButton.Tag.ToString();
                }
            }
            return gboxName;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            string gboxName = DaZnamKojiJeGBox();

            if (txtIme.Text == "" || txtImeRoditelja.Text == "" || txtPrezime.Text == "" || txtJMBG.Text == "" || txtAdresa.Text == "")
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show("Mora da se popune svi podaci za policajca!", "Poruka", buttons);
                return;
            }
            //if (chbSef.Checked == true && DTOManager.ProveriDaliimaSefa(StanicaID) != -1)
            //{
            //    MessageBoxButtons buttons = MessageBoxButtons.OK;
            //    DialogResult result = MessageBox.Show("Stanica vec ima sefa!", "Poruka", buttons);
            //    return;
            //}


            //PolicijskaStanica stanica = DTOManager.VratiStanicu(StanicaID);

            //if (stanica == null)
            //{
            //    MessageBoxButtons buttonss = MessageBoxButtons.OK;
            //    DialogResult resultt = MessageBox.Show("Greska prilikom uzimanja stanice", "Poruka", buttonss);
            //    return;
            //}


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
                        ((PZaVanredneSituacije)policajac).DatumZavrsetkaKursa = dtpDatumZavrsetkaKursa.Value;
                        ((PZaVanredneSituacije)policajac).Sertifikat = txtSertifikat.Text;
                        ((PZaVanredneSituacije)policajac).DatumSticanjaSertifikata = dtpDatumSticanjaSertifikata.Value;
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

                        policajac = new PolicajacPozornik();
                        policajac.Tip = "POLICAJAC POZORNIK";
                        ((PolicajacPozornik)policajac).NazivUlice = txtNazivUlice.Text;
                        break;


                    case "gboxPatrolniPolicajac":

                        policajac = new PatrolniPolicajac();
                        policajac.Tip = "PATROLNI POLICAJAC";
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
                policajac.Stanica = null;
                policajac.SefujeStanicom = null;// chbSef.Checked == true ? stanica : null;
                policajac.ZamenikStanice = null;//s chbZamenik.Checked == true ? stanica : null;

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
            this.Close();
        }


        //private void chbZamenik_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (chbZamenik.Checked)
        //    {
        //        chbSef.Checked = false;
        //    }
        //    //chbZamenik.Checked = !chbZamenik.Checked;
        //}

        //private void chbSef_CheckedChanged_1(object sender, EventArgs e)
        //{
        //    if (chbSef.Checked)
        //    {
        //        chbZamenik.Checked = false;
        //    }
        //    //chbSef.Checked = true;
        //}

        //private void chbZamenik_CheckedChanged_1(object sender, EventArgs e)
        //{
        //    if (chbZamenik.Checked)
        //        chbSef.Checked = false;
        //}

        //private void chbSef_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (chbSef.Checked)
        //        chbZamenik.Checked = false;
        //}
    }
}
