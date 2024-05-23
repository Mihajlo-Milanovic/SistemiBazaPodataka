namespace PolicijskaUprava.Forme.PolicajciForme
{
    partial class DodajPolicajcaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gbxTipoviPolicajaca = new GroupBox();
            btnPolicajacZaVanrednoSituacije = new RadioButton();
            btnPatrolniPolicajac = new RadioButton();
            btnSkolskiPolicajac = new RadioButton();
            btnPolicajacPozornik = new RadioButton();
            btnRdnikUUpravi = new RadioButton();
            lblIme = new Label();
            txtIme = new TextBox();
            dtpDatumRodjenja = new DateTimePicker();
            label3 = new Label();
            txtImeRoditelja = new TextBox();
            label4 = new Label();
            txtPrezime = new TextBox();
            label5 = new Label();
            txtJMBG = new TextBox();
            label6 = new Label();
            txtAdresa = new TextBox();
            label7 = new Label();
            label8 = new Label();
            dtpDatumPrijemaUSluzbu = new DateTimePicker();
            gboxPolicajac = new GroupBox();
            chbSef = new CheckBox();
            chbZamenik = new CheckBox();
            gboxPatrolniPolicajac = new GroupBox();
            label20 = new Label();
            txtVrstaOruzija = new TextBox();
            gboxPolicajacPozornik = new GroupBox();
            label19 = new Label();
            txtNazivUlice = new TextBox();
            gboxPolicajacUUpravi = new GroupBox();
            label18 = new Label();
            txtPozicija = new TextBox();
            gboxSkolskiPolicajac = new GroupBox();
            label16 = new Label();
            label12 = new Label();
            txtKontaktPrezime = new TextBox();
            label13 = new Label();
            txtTelefonSkole = new TextBox();
            txtTipSkole = new TextBox();
            label17 = new Label();
            txtNazivSkole = new TextBox();
            label14 = new Label();
            label15 = new Label();
            txtAdresaSkole = new TextBox();
            txtKontaktIme = new TextBox();
            gboxPZaVanredneSituacije = new GroupBox();
            label1 = new Label();
            dtpDatumSticanjaSertifikata = new DateTimePicker();
            txtKurs = new TextBox();
            label11 = new Label();
            txtVestina = new TextBox();
            dtpDatumZavrsetkaKursa = new DateTimePicker();
            label2 = new Label();
            label9 = new Label();
            txtSertifikat = new TextBox();
            label10 = new Label();
            btnDodaj = new Button();
            gbxTipoviPolicajaca.SuspendLayout();
            gboxPolicajac.SuspendLayout();
            gboxPatrolniPolicajac.SuspendLayout();
            gboxPolicajacPozornik.SuspendLayout();
            gboxPolicajacUUpravi.SuspendLayout();
            gboxSkolskiPolicajac.SuspendLayout();
            gboxPZaVanredneSituacije.SuspendLayout();
            SuspendLayout();
            // 
            // gbxTipoviPolicajaca
            // 
            gbxTipoviPolicajaca.Controls.Add(btnPolicajacZaVanrednoSituacije);
            gbxTipoviPolicajaca.Controls.Add(btnPatrolniPolicajac);
            gbxTipoviPolicajaca.Controls.Add(btnSkolskiPolicajac);
            gbxTipoviPolicajaca.Controls.Add(btnPolicajacPozornik);
            gbxTipoviPolicajaca.Controls.Add(btnRdnikUUpravi);
            gbxTipoviPolicajaca.Location = new System.Drawing.Point(14, 107);
            gbxTipoviPolicajaca.Margin = new Padding(3, 4, 3, 4);
            gbxTipoviPolicajaca.Name = "gbxTipoviPolicajaca";
            gbxTipoviPolicajaca.Padding = new Padding(3, 4, 3, 4);
            gbxTipoviPolicajaca.Size = new System.Drawing.Size(293, 223);
            gbxTipoviPolicajaca.TabIndex = 6;
            gbxTipoviPolicajaca.TabStop = false;
            gbxTipoviPolicajaca.Text = "Tip policajca";
            // 
            // btnPolicajacZaVanrednoSituacije
            // 
            btnPolicajacZaVanrednoSituacije.AutoSize = true;
            btnPolicajacZaVanrednoSituacije.Location = new System.Drawing.Point(38, 44);
            btnPolicajacZaVanrednoSituacije.Margin = new Padding(3, 4, 3, 4);
            btnPolicajacZaVanrednoSituacije.Name = "btnPolicajacZaVanrednoSituacije";
            btnPolicajacZaVanrednoSituacije.Size = new System.Drawing.Size(230, 24);
            btnPolicajacZaVanrednoSituacije.TabIndex = 0;
            btnPolicajacZaVanrednoSituacije.TabStop = true;
            btnPolicajacZaVanrednoSituacije.Tag = "PZaVanrednoSituacije";
            btnPolicajacZaVanrednoSituacije.Text = "Policajac za vanredne situacije";
            btnPolicajacZaVanrednoSituacije.UseVisualStyleBackColor = true;
            btnPolicajacZaVanrednoSituacije.CheckedChanged += btnPolicajacZaVanrednoSituacije_CheckedChanged;
            // 
            // btnPatrolniPolicajac
            // 
            btnPatrolniPolicajac.AutoSize = true;
            btnPatrolniPolicajac.Location = new System.Drawing.Point(38, 177);
            btnPatrolniPolicajac.Margin = new Padding(3, 4, 3, 4);
            btnPatrolniPolicajac.Name = "btnPatrolniPolicajac";
            btnPatrolniPolicajac.Size = new System.Drawing.Size(144, 24);
            btnPatrolniPolicajac.TabIndex = 4;
            btnPatrolniPolicajac.TabStop = true;
            btnPatrolniPolicajac.Tag = "PatrolniPolicajac";
            btnPatrolniPolicajac.Text = "Patrolni policajac";
            btnPatrolniPolicajac.UseVisualStyleBackColor = true;
            btnPatrolniPolicajac.CheckedChanged += btnPatrolniPolicajac_CheckedChanged;
            // 
            // btnSkolskiPolicajac
            // 
            btnSkolskiPolicajac.AutoSize = true;
            btnSkolskiPolicajac.Location = new System.Drawing.Point(38, 77);
            btnSkolskiPolicajac.Margin = new Padding(3, 4, 3, 4);
            btnSkolskiPolicajac.Name = "btnSkolskiPolicajac";
            btnSkolskiPolicajac.Size = new System.Drawing.Size(139, 24);
            btnSkolskiPolicajac.TabIndex = 1;
            btnSkolskiPolicajac.TabStop = true;
            btnSkolskiPolicajac.Tag = "SkolskiPolicajac";
            btnSkolskiPolicajac.Text = "Skolski policajac";
            btnSkolskiPolicajac.UseVisualStyleBackColor = true;
            btnSkolskiPolicajac.CheckedChanged += btnSkolskiPolicajac_CheckedChanged;
            // 
            // btnPolicajacPozornik
            // 
            btnPolicajacPozornik.AutoSize = true;
            btnPolicajacPozornik.Location = new System.Drawing.Point(38, 144);
            btnPolicajacPozornik.Margin = new Padding(3, 4, 3, 4);
            btnPolicajacPozornik.Name = "btnPolicajacPozornik";
            btnPolicajacPozornik.Size = new System.Drawing.Size(150, 24);
            btnPolicajacPozornik.TabIndex = 3;
            btnPolicajacPozornik.TabStop = true;
            btnPolicajacPozornik.Tag = "PolicajacPozornik";
            btnPolicajacPozornik.Text = "Policajac pozornik";
            btnPolicajacPozornik.UseVisualStyleBackColor = true;
            btnPolicajacPozornik.CheckedChanged += btnPolicajacPozornik_CheckedChanged;
            // 
            // btnRdnikUUpravi
            // 
            btnRdnikUUpravi.AutoSize = true;
            btnRdnikUUpravi.Location = new System.Drawing.Point(38, 111);
            btnRdnikUUpravi.Margin = new Padding(3, 4, 3, 4);
            btnRdnikUUpravi.Name = "btnRdnikUUpravi";
            btnRdnikUUpravi.Size = new System.Drawing.Size(132, 24);
            btnRdnikUUpravi.TabIndex = 2;
            btnRdnikUUpravi.TabStop = true;
            btnRdnikUUpravi.Tag = "RadnikUUpravi";
            btnRdnikUUpravi.Text = "Radnik u upravi";
            btnRdnikUUpravi.UseVisualStyleBackColor = true;
            btnRdnikUUpravi.CheckedChanged += btnRdnikUUpravi_CheckedChanged;
            // 
            // lblIme
            // 
            lblIme.AutoSize = true;
            lblIme.Location = new System.Drawing.Point(126, 39);
            lblIme.Name = "lblIme";
            lblIme.Size = new System.Drawing.Size(37, 20);
            lblIme.TabIndex = 7;
            lblIme.Text = "Ime:";
            // 
            // txtIme
            // 
            txtIme.Location = new System.Drawing.Point(177, 39);
            txtIme.Margin = new Padding(3, 4, 3, 4);
            txtIme.Name = "txtIme";
            txtIme.Size = new System.Drawing.Size(114, 27);
            txtIme.TabIndex = 8;
            // 
            // dtpDatumRodjenja
            // 
            dtpDatumRodjenja.Location = new System.Drawing.Point(177, 155);
            dtpDatumRodjenja.Margin = new Padding(3, 4, 3, 4);
            dtpDatumRodjenja.Name = "dtpDatumRodjenja";
            dtpDatumRodjenja.Size = new System.Drawing.Size(228, 27);
            dtpDatumRodjenja.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(114, 193);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(49, 20);
            label3.TabIndex = 12;
            label3.Text = "JMBG:";
            // 
            // txtImeRoditelja
            // 
            txtImeRoditelja.Location = new System.Drawing.Point(177, 77);
            txtImeRoditelja.Margin = new Padding(3, 4, 3, 4);
            txtImeRoditelja.Name = "txtImeRoditelja";
            txtImeRoditelja.Size = new System.Drawing.Size(114, 27);
            txtImeRoditelja.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(73, 77);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(97, 20);
            label4.TabIndex = 13;
            label4.Text = "Ime roditelja:";
            // 
            // txtPrezime
            // 
            txtPrezime.Location = new System.Drawing.Point(177, 116);
            txtPrezime.Margin = new Padding(3, 4, 3, 4);
            txtPrezime.Name = "txtPrezime";
            txtPrezime.Size = new System.Drawing.Size(114, 27);
            txtPrezime.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(101, 116);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(65, 20);
            label5.TabIndex = 15;
            label5.Text = "Prezime:";
            // 
            // txtJMBG
            // 
            txtJMBG.Location = new System.Drawing.Point(177, 193);
            txtJMBG.Margin = new Padding(3, 4, 3, 4);
            txtJMBG.Name = "txtJMBG";
            txtJMBG.Size = new System.Drawing.Size(114, 27);
            txtJMBG.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(55, 155);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(116, 20);
            label6.TabIndex = 17;
            label6.Text = "Datum rodjenja:";
            // 
            // txtAdresa
            // 
            txtAdresa.Location = new System.Drawing.Point(177, 232);
            txtAdresa.Margin = new Padding(3, 4, 3, 4);
            txtAdresa.Name = "txtAdresa";
            txtAdresa.Size = new System.Drawing.Size(114, 27);
            txtAdresa.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(107, 231);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(58, 20);
            label7.TabIndex = 19;
            label7.Text = "Adresa:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(5, 268);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(170, 20);
            label8.TabIndex = 21;
            label8.Text = "Datum prijema u sluzbu:";
            // 
            // dtpDatumPrijemaUSluzbu
            // 
            dtpDatumPrijemaUSluzbu.Location = new System.Drawing.Point(177, 268);
            dtpDatumPrijemaUSluzbu.Margin = new Padding(3, 4, 3, 4);
            dtpDatumPrijemaUSluzbu.Name = "dtpDatumPrijemaUSluzbu";
            dtpDatumPrijemaUSluzbu.Size = new System.Drawing.Size(228, 27);
            dtpDatumPrijemaUSluzbu.TabIndex = 23;
            // 
<<<<<<< HEAD
=======
            // rbtPolicajac
            // 
            rbtPolicajac.AutoSize = true;
            rbtPolicajac.Location = new System.Drawing.Point(177, 307);
            rbtPolicajac.Margin = new Padding(3, 4, 3, 4);
            rbtPolicajac.Name = "rbtPolicajac";
            rbtPolicajac.Size = new System.Drawing.Size(88, 24);
            rbtPolicajac.TabIndex = 27;
            rbtPolicajac.TabStop = true;
            rbtPolicajac.Text = "Policajac";
            rbtPolicajac.UseVisualStyleBackColor = true;
            // 
            // rbtZamenik
            // 
            rbtZamenik.AutoSize = true;
            rbtZamenik.Location = new System.Drawing.Point(177, 340);
            rbtZamenik.Margin = new Padding(3, 4, 3, 4);
            rbtZamenik.Name = "rbtZamenik";
            rbtZamenik.Size = new System.Drawing.Size(87, 24);
            rbtZamenik.TabIndex = 28;
            rbtZamenik.TabStop = true;
            rbtZamenik.Text = "Zamenik";
            rbtZamenik.UseVisualStyleBackColor = true;
            // 
            // rbtSef
            // 
            rbtSef.AutoSize = true;
            rbtSef.Location = new System.Drawing.Point(176, 373);
            rbtSef.Margin = new Padding(3, 4, 3, 4);
            rbtSef.Name = "rbtSef";
            rbtSef.Size = new System.Drawing.Size(51, 24);
            rbtSef.TabIndex = 29;
            rbtSef.TabStop = true;
            rbtSef.Text = "Sef";
            rbtSef.UseVisualStyleBackColor = true;
            // 
>>>>>>> 2618830652c68d717e88e1ca7c2cc2bfcce2412d
            // gboxPolicajac
            // 
            gboxPolicajac.Controls.Add(chbSef);
            gboxPolicajac.Controls.Add(chbZamenik);
            gboxPolicajac.Controls.Add(lblIme);
            gboxPolicajac.Controls.Add(txtIme);
            gboxPolicajac.Controls.Add(dtpDatumRodjenja);
            gboxPolicajac.Controls.Add(label3);
            gboxPolicajac.Controls.Add(dtpDatumPrijemaUSluzbu);
            gboxPolicajac.Controls.Add(label4);
            gboxPolicajac.Controls.Add(label8);
            gboxPolicajac.Controls.Add(txtImeRoditelja);
            gboxPolicajac.Controls.Add(txtAdresa);
            gboxPolicajac.Controls.Add(label5);
            gboxPolicajac.Controls.Add(label7);
            gboxPolicajac.Controls.Add(txtPrezime);
            gboxPolicajac.Controls.Add(txtJMBG);
            gboxPolicajac.Controls.Add(label6);
            gboxPolicajac.Location = new System.Drawing.Point(331, 16);
            gboxPolicajac.Margin = new Padding(3, 4, 3, 4);
            gboxPolicajac.Name = "gboxPolicajac";
            gboxPolicajac.Padding = new Padding(3, 4, 3, 4);
            gboxPolicajac.Size = new System.Drawing.Size(422, 412);
            gboxPolicajac.TabIndex = 30;
            gboxPolicajac.TabStop = false;
            gboxPolicajac.Text = "Policajac";
            // 
            // chbSef
            // 
            chbSef.AutoSize = true;
            chbSef.Location = new System.Drawing.Point(155, 253);
            chbSef.Name = "chbSef";
            chbSef.Size = new System.Drawing.Size(42, 19);
            chbSef.TabIndex = 31;
            chbSef.Text = "Sef";
            chbSef.UseVisualStyleBackColor = true;
            chbSef.CheckedChanged += chbSef_CheckedChanged_1;
            // 
            // chbZamenik
            // 
            chbZamenik.AutoSize = true;
            chbZamenik.Location = new System.Drawing.Point(155, 230);
            chbZamenik.Name = "chbZamenik";
            chbZamenik.Size = new System.Drawing.Size(72, 19);
            chbZamenik.TabIndex = 30;
            chbZamenik.Text = "Zamenik";
            chbZamenik.UseVisualStyleBackColor = true;
            chbZamenik.CheckedChanged += chbZamenik_CheckedChanged;
            // 
            // gboxPatrolniPolicajac
            // 
            gboxPatrolniPolicajac.Controls.Add(label20);
            gboxPatrolniPolicajac.Controls.Add(txtVrstaOruzija);
            gboxPatrolniPolicajac.Location = new System.Drawing.Point(415, 749);
            gboxPatrolniPolicajac.Margin = new Padding(3, 4, 3, 4);
            gboxPatrolniPolicajac.Name = "gboxPatrolniPolicajac";
            gboxPatrolniPolicajac.Padding = new Padding(3, 4, 3, 4);
            gboxPatrolniPolicajac.Size = new System.Drawing.Size(229, 97);
            gboxPatrolniPolicajac.TabIndex = 59;
            gboxPatrolniPolicajac.TabStop = false;
            gboxPatrolniPolicajac.Text = "Patrolni policajac";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new System.Drawing.Point(11, 45);
            label20.Name = "label20";
            label20.Size = new System.Drawing.Size(89, 20);
            label20.TabIndex = 38;
            label20.Text = "Vrsta oruzja:";
            // 
            // txtVrstaOruzija
            // 
            txtVrstaOruzija.Location = new System.Drawing.Point(99, 45);
            txtVrstaOruzija.Margin = new Padding(3, 4, 3, 4);
            txtVrstaOruzija.Name = "txtVrstaOruzija";
            txtVrstaOruzija.Size = new System.Drawing.Size(114, 27);
            txtVrstaOruzija.TabIndex = 39;
            // 
            // gboxPolicajacPozornik
            // 
            gboxPolicajacPozornik.Controls.Add(label19);
            gboxPolicajacPozornik.Controls.Add(txtNazivUlice);
            gboxPolicajacPozornik.Location = new System.Drawing.Point(733, 749);
            gboxPolicajacPozornik.Margin = new Padding(3, 4, 3, 4);
            gboxPolicajacPozornik.Name = "gboxPolicajacPozornik";
            gboxPolicajacPozornik.Padding = new Padding(3, 4, 3, 4);
            gboxPolicajacPozornik.Size = new System.Drawing.Size(229, 100);
            gboxPolicajacPozornik.TabIndex = 58;
            gboxPolicajacPozornik.TabStop = false;
            gboxPolicajacPozornik.Text = "Policajac pozornik";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new System.Drawing.Point(11, 48);
            label19.Name = "label19";
            label19.Size = new System.Drawing.Size(84, 20);
            label19.TabIndex = 38;
            label19.Text = "Naziv ulice:";
            // 
            // txtNazivUlice
            // 
            txtNazivUlice.Location = new System.Drawing.Point(95, 48);
            txtNazivUlice.Margin = new Padding(3, 4, 3, 4);
            txtNazivUlice.Name = "txtNazivUlice";
            txtNazivUlice.Size = new System.Drawing.Size(114, 27);
            txtNazivUlice.TabIndex = 39;
            // 
            // gboxPolicajacUUpravi
            // 
            gboxPolicajacUUpravi.Controls.Add(label18);
            gboxPolicajacUUpravi.Controls.Add(txtPozicija);
            gboxPolicajacUUpravi.Location = new System.Drawing.Point(77, 752);
            gboxPolicajacUUpravi.Margin = new Padding(3, 4, 3, 4);
            gboxPolicajacUUpravi.Name = "gboxPolicajacUUpravi";
            gboxPolicajacUUpravi.Padding = new Padding(3, 4, 3, 4);
            gboxPolicajacUUpravi.Size = new System.Drawing.Size(229, 97);
            gboxPolicajacUUpravi.TabIndex = 57;
            gboxPolicajacUUpravi.TabStop = false;
            gboxPolicajacUUpravi.Text = "Radnik u upravi";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new System.Drawing.Point(31, 48);
            label18.Name = "label18";
            label18.Size = new System.Drawing.Size(62, 20);
            label18.TabIndex = 38;
            label18.Text = "Pozicija:";
            // 
            // txtPozicija
            // 
            txtPozicija.Location = new System.Drawing.Point(95, 48);
            txtPozicija.Margin = new Padding(3, 4, 3, 4);
            txtPozicija.Name = "txtPozicija";
            txtPozicija.Size = new System.Drawing.Size(114, 27);
            txtPozicija.TabIndex = 39;
            // 
            // gboxSkolskiPolicajac
            // 
            gboxSkolskiPolicajac.Controls.Add(label16);
            gboxSkolskiPolicajac.Controls.Add(label12);
            gboxSkolskiPolicajac.Controls.Add(txtKontaktPrezime);
            gboxSkolskiPolicajac.Controls.Add(label13);
            gboxSkolskiPolicajac.Controls.Add(txtTelefonSkole);
            gboxSkolskiPolicajac.Controls.Add(txtTipSkole);
            gboxSkolskiPolicajac.Controls.Add(label17);
            gboxSkolskiPolicajac.Controls.Add(txtNazivSkole);
            gboxSkolskiPolicajac.Controls.Add(label14);
            gboxSkolskiPolicajac.Controls.Add(label15);
            gboxSkolskiPolicajac.Controls.Add(txtAdresaSkole);
            gboxSkolskiPolicajac.Controls.Add(txtKontaktIme);
            gboxSkolskiPolicajac.Location = new System.Drawing.Point(606, 453);
            gboxSkolskiPolicajac.Margin = new Padding(3, 4, 3, 4);
            gboxSkolskiPolicajac.Name = "gboxSkolskiPolicajac";
            gboxSkolskiPolicajac.Padding = new Padding(3, 4, 3, 4);
            gboxSkolskiPolicajac.Size = new System.Drawing.Size(355, 272);
            gboxSkolskiPolicajac.TabIndex = 56;
            gboxSkolskiPolicajac.TabStop = false;
            gboxSkolskiPolicajac.Text = "Skolski policajac";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new System.Drawing.Point(23, 189);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(121, 20);
            label16.TabIndex = 47;
            label16.Text = "Kontakt prezime:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(54, 35);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(87, 20);
            label12.TabIndex = 39;
            label12.Text = "Naziv skole:";
            // 
            // txtKontaktPrezime
            // 
            txtKontaktPrezime.Location = new System.Drawing.Point(143, 189);
            txtKontaktPrezime.Margin = new Padding(3, 4, 3, 4);
            txtKontaktPrezime.Name = "txtKontaktPrezime";
            txtKontaktPrezime.Size = new System.Drawing.Size(114, 27);
            txtKontaktPrezime.TabIndex = 48;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(69, 73);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(71, 20);
            label13.TabIndex = 41;
            label13.Text = "Tip skole:";
            // 
            // txtTelefonSkole
            // 
            txtTelefonSkole.Location = new System.Drawing.Point(143, 228);
            txtTelefonSkole.Margin = new Padding(3, 4, 3, 4);
            txtTelefonSkole.Name = "txtTelefonSkole";
            txtTelefonSkole.Size = new System.Drawing.Size(114, 27);
            txtTelefonSkole.TabIndex = 50;
            // 
            // txtTipSkole
            // 
            txtTipSkole.Location = new System.Drawing.Point(143, 73);
            txtTipSkole.Margin = new Padding(3, 4, 3, 4);
            txtTipSkole.Name = "txtTipSkole";
            txtTipSkole.Size = new System.Drawing.Size(114, 27);
            txtTipSkole.TabIndex = 42;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new System.Drawing.Point(43, 228);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(99, 20);
            label17.TabIndex = 49;
            label17.Text = "Telefon skole:";
            // 
            // txtNazivSkole
            // 
            txtNazivSkole.Location = new System.Drawing.Point(143, 35);
            txtNazivSkole.Margin = new Padding(3, 4, 3, 4);
            txtNazivSkole.Name = "txtNazivSkole";
            txtNazivSkole.Size = new System.Drawing.Size(114, 27);
            txtNazivSkole.TabIndex = 40;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new System.Drawing.Point(46, 112);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(96, 20);
            label14.TabIndex = 43;
            label14.Text = "Adresa skole:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new System.Drawing.Point(48, 151);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(92, 20);
            label15.TabIndex = 45;
            label15.Text = "Kontakt ime:";
            // 
            // txtAdresaSkole
            // 
            txtAdresaSkole.Location = new System.Drawing.Point(143, 112);
            txtAdresaSkole.Margin = new Padding(3, 4, 3, 4);
            txtAdresaSkole.Name = "txtAdresaSkole";
            txtAdresaSkole.Size = new System.Drawing.Size(114, 27);
            txtAdresaSkole.TabIndex = 44;
            // 
            // txtKontaktIme
            // 
            txtKontaktIme.Location = new System.Drawing.Point(143, 151);
            txtKontaktIme.Margin = new Padding(3, 4, 3, 4);
            txtKontaktIme.Name = "txtKontaktIme";
            txtKontaktIme.Size = new System.Drawing.Size(114, 27);
            txtKontaktIme.TabIndex = 46;
            // 
            // gboxPZaVanredneSituacije
            // 
            gboxPZaVanredneSituacije.Controls.Add(label1);
            gboxPZaVanredneSituacije.Controls.Add(dtpDatumSticanjaSertifikata);
            gboxPZaVanredneSituacije.Controls.Add(txtKurs);
            gboxPZaVanredneSituacije.Controls.Add(label11);
            gboxPZaVanredneSituacije.Controls.Add(txtVestina);
            gboxPZaVanredneSituacije.Controls.Add(dtpDatumZavrsetkaKursa);
            gboxPZaVanredneSituacije.Controls.Add(label2);
            gboxPZaVanredneSituacije.Controls.Add(label9);
            gboxPZaVanredneSituacije.Controls.Add(txtSertifikat);
            gboxPZaVanredneSituacije.Controls.Add(label10);
            gboxPZaVanredneSituacije.Location = new System.Drawing.Point(77, 453);
            gboxPZaVanredneSituacije.Margin = new Padding(3, 4, 3, 4);
            gboxPZaVanredneSituacije.Name = "gboxPZaVanredneSituacije";
            gboxPZaVanredneSituacije.Padding = new Padding(3, 4, 3, 4);
            gboxPZaVanredneSituacije.Size = new System.Drawing.Size(415, 272);
            gboxPZaVanredneSituacije.TabIndex = 55;
            gboxPZaVanredneSituacije.TabStop = false;
            gboxPZaVanredneSituacije.Text = "Policajac za vanredne situacije";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(134, 25);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(40, 20);
            label1.TabIndex = 30;
            label1.Text = "Kurs:";
            // 
            // dtpDatumSticanjaSertifikata
            // 
            dtpDatumSticanjaSertifikata.CustomFormat = "MM/dd/yyyy";
            dtpDatumSticanjaSertifikata.Format = DateTimePickerFormat.Custom;
            dtpDatumSticanjaSertifikata.Location = new System.Drawing.Point(178, 180);
            dtpDatumSticanjaSertifikata.Margin = new Padding(3, 4, 3, 4);
            dtpDatumSticanjaSertifikata.Name = "dtpDatumSticanjaSertifikata";
            dtpDatumSticanjaSertifikata.Size = new System.Drawing.Size(228, 27);
            dtpDatumSticanjaSertifikata.TabIndex = 36;
            // 
            // txtKurs
            // 
            txtKurs.Location = new System.Drawing.Point(178, 25);
            txtKurs.Margin = new Padding(3, 4, 3, 4);
            txtKurs.Name = "txtKurs";
            txtKurs.Size = new System.Drawing.Size(114, 27);
            txtKurs.TabIndex = 31;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(11, 180);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(180, 20);
            label11.TabIndex = 37;
            label11.Text = "Datum sticanja sertifikata:";
            // 
            // txtVestina
            // 
            txtVestina.Location = new System.Drawing.Point(178, 64);
            txtVestina.Margin = new Padding(3, 4, 3, 4);
            txtVestina.Name = "txtVestina";
            txtVestina.Size = new System.Drawing.Size(114, 27);
            txtVestina.TabIndex = 33;
            // 
            // dtpDatumZavrsetkaKursa
            // 
            dtpDatumZavrsetkaKursa.CustomFormat = "MM/dd/yyyy";
            dtpDatumZavrsetkaKursa.Format = DateTimePickerFormat.Custom;
            dtpDatumZavrsetkaKursa.Location = new System.Drawing.Point(178, 103);
            dtpDatumZavrsetkaKursa.Margin = new Padding(3, 4, 3, 4);
            dtpDatumZavrsetkaKursa.Name = "dtpDatumZavrsetkaKursa";
            dtpDatumZavrsetkaKursa.Size = new System.Drawing.Size(228, 27);
            dtpDatumZavrsetkaKursa.TabIndex = 30;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(121, 64);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(59, 20);
            label2.TabIndex = 32;
            label2.Text = "Vestina:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(111, 141);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(71, 20);
            label9.TabIndex = 34;
            label9.Text = "Sertifikat:";
            // 
            // txtSertifikat
            // 
            txtSertifikat.Location = new System.Drawing.Point(178, 141);
            txtSertifikat.Margin = new Padding(3, 4, 3, 4);
            txtSertifikat.Name = "txtSertifikat";
            txtSertifikat.Size = new System.Drawing.Size(114, 27);
            txtSertifikat.TabIndex = 35;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(29, 103);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(160, 20);
            label10.TabIndex = 31;
            label10.Text = "Datum zavrsetka kursa:";
            // 
            // btnDodaj
            // 
            btnDodaj.BackColor = System.Drawing.Color.DeepSkyBlue;
            btnDodaj.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            btnDodaj.FlatAppearance.BorderSize = 3;
            btnDodaj.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(0, 0, 64);
            btnDodaj.FlatStyle = FlatStyle.Flat;
            btnDodaj.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 238);
            btnDodaj.Location = new System.Drawing.Point(794, 352);
            btnDodaj.Margin = new Padding(5, 4, 5, 4);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new System.Drawing.Size(198, 76);
            btnDodaj.TabIndex = 60;
            btnDodaj.Text = "Dodatj ";
            btnDodaj.UseVisualStyleBackColor = false;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // DodajPolicajcaForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.Color.SkyBlue;
            ClientSize = new System.Drawing.Size(1025, 881);
            Controls.Add(btnDodaj);
            Controls.Add(gboxPatrolniPolicajac);
            Controls.Add(gboxPolicajacPozornik);
            Controls.Add(gboxPolicajacUUpravi);
            Controls.Add(gboxSkolskiPolicajac);
            Controls.Add(gboxPZaVanredneSituacije);
            Controls.Add(gboxPolicajac);
            Controls.Add(gbxTipoviPolicajaca);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DodajPolicajcaForm";
            Text = "DodajPolicajcaForm";
            gbxTipoviPolicajaca.ResumeLayout(false);
            gbxTipoviPolicajaca.PerformLayout();
            gboxPolicajac.ResumeLayout(false);
            gboxPolicajac.PerformLayout();
            gboxPatrolniPolicajac.ResumeLayout(false);
            gboxPatrolniPolicajac.PerformLayout();
            gboxPolicajacPozornik.ResumeLayout(false);
            gboxPolicajacPozornik.PerformLayout();
            gboxPolicajacUUpravi.ResumeLayout(false);
            gboxPolicajacUUpravi.PerformLayout();
            gboxSkolskiPolicajac.ResumeLayout(false);
            gboxSkolskiPolicajac.PerformLayout();
            gboxPZaVanredneSituacije.ResumeLayout(false);
            gboxPZaVanredneSituacije.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbxTipoviPolicajaca;
        private RadioButton btnPolicajacZaVanrednoSituacije;
        private RadioButton btnPatrolniPolicajac;
        private RadioButton btnSkolskiPolicajac;
        private RadioButton btnPolicajacPozornik;
        private RadioButton btnRdnikUUpravi;
        private Label lblIme;
        private TextBox txtIme;
        private DateTimePicker dtpDatumRodjenja;
        private Label label3;
        private TextBox txtImeRoditelja;
        private Label label4;
        private TextBox txtPrezime;
        private Label label5;
        private TextBox txtJMBG;
        private Label label6;
        private TextBox txtAdresa;
        private Label label7;
        private Label label8;
        private DateTimePicker dtpDatumPrijemaUSluzbu;
        private GroupBox gboxPolicajac;
        private GroupBox gboxPatrolniPolicajac;
        private Label label20;
        private TextBox txtVrstaOruzija;
        private GroupBox gboxPolicajacPozornik;
        private Label label19;
        private TextBox txtNazivUlice;
        private GroupBox gboxPolicajacUUpravi;
        private Label label18;
        private TextBox txtPozicija;
        private GroupBox gboxSkolskiPolicajac;
        private Label label16;
        private Label label12;
        private TextBox txtKontaktPrezime;
        private Label label13;
        private TextBox txtTelefonSkole;
        private TextBox txtTipSkole;
        private Label label17;
        private TextBox txtNazivSkole;
        private Label label14;
        private Label label15;
        private TextBox txtAdresaSkole;
        private TextBox txtKontaktIme;
        private GroupBox gboxPZaVanredneSituacije;
        private Label label1;
        private DateTimePicker dtpDatumSticanjaSertifikata;
        private TextBox txtKurs;
        private Label label11;
        private TextBox txtVestina;
        private DateTimePicker dtpDatumZavrsetkaKursa;
        private Label label2;
        private Label label9;
        private TextBox txtSertifikat;
        private Label label10;
        private Button btnDodaj;
        private CheckBox chbSef;
        private CheckBox chbZamenik;
    }
}