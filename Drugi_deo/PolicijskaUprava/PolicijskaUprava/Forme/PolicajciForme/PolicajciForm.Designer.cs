namespace PolicijskaUprava.Forme
{
    partial class PolicajciForm
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
            ListaPolicajaca = new ListView();
            ID = new ColumnHeader();
            Ime = new ColumnHeader();
            Ime_roditelja = new ColumnHeader();
            Prezime = new ColumnHeader();
            JMBG = new ColumnHeader();
            Datum_rodjenja = new ColumnHeader();
            Adresa = new ColumnHeader();
            Datum_prijema_u_sluzbu = new ColumnHeader();
            Policijska_stanica = new ColumnHeader();
            Sefuje_stanicom = new ColumnHeader();
            Je_zamenik_u_stanici = new ColumnHeader();
            Tip = new ColumnHeader();
            btnObrisiPolicajca = new Button();
            btnUnapredjenja = new Button();
            btnObrazovanje = new Button();
            SuspendLayout();
            // 
            // ListaPolicajaca
            // 
            ListaPolicajaca.Columns.AddRange(new ColumnHeader[] { ID, Ime, Ime_roditelja, Prezime, JMBG, Datum_rodjenja, Adresa, Datum_prijema_u_sluzbu, Policijska_stanica, Sefuje_stanicom, Je_zamenik_u_stanici, Tip });
            ListaPolicajaca.ForeColor = System.Drawing.SystemColors.MenuText;
            ListaPolicajaca.FullRowSelect = true;
            ListaPolicajaca.GridLines = true;
            ListaPolicajaca.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            ListaPolicajaca.ImeMode = ImeMode.NoControl;
            ListaPolicajaca.Location = new System.Drawing.Point(15, 16);
            ListaPolicajaca.Margin = new Padding(5, 4, 5, 4);
            ListaPolicajaca.MultiSelect = false;
            ListaPolicajaca.Name = "ListaPolicajaca";
<<<<<<< HEAD
            ListaPolicajaca.Size = new System.Drawing.Size(1136, 285);
=======
            ListaPolicajaca.Size = new System.Drawing.Size(1285, 379);
>>>>>>> 2618830652c68d717e88e1ca7c2cc2bfcce2412d
            ListaPolicajaca.TabIndex = 1;
            ListaPolicajaca.UseCompatibleStateImageBehavior = false;
            ListaPolicajaca.View = View.Details;
            ListaPolicajaca.SelectedIndexChanged += ListaPolicajaca_SelectedIndexChanged;
            // 
            // ID
            // 
            ID.Text = "ID";
            // 
            // Ime
            // 
            Ime.Text = "Ime";
            // 
            // Ime_roditelja
            // 
            Ime_roditelja.Text = "Ime roditelja";
            Ime_roditelja.Width = 80;
            // 
            // Prezime
            // 
            Prezime.Text = "Prezime";
            // 
            // JMBG
            // 
            JMBG.Text = "JMBG";
            // 
            // Datum_rodjenja
            // 
            Datum_rodjenja.Text = "Datum rodjenja";
            Datum_rodjenja.Width = 100;
            // 
            // Adresa
            // 
            Adresa.Text = "Adresa";
            // 
            // Datum_prijema_u_sluzbu
            // 
            Datum_prijema_u_sluzbu.Text = "Datum prijema u sluzbu";
            Datum_prijema_u_sluzbu.Width = 145;
            // 
            // Policijska_stanica
            // 
            Policijska_stanica.Text = "Policijska stanica";
            Policijska_stanica.Width = 105;
            // 
            // Sefuje_stanicom
            // 
            Sefuje_stanicom.Text = "Sefuje stanicom";
            Sefuje_stanicom.Width = 100;
            // 
            // Je_zamenik_u_stanici
            // 
            Je_zamenik_u_stanici.Text = "Zamenik u stanici";
            Je_zamenik_u_stanici.Width = 110;
            // 
            // Tip
            // 
            Tip.Text = "Tip";
            Tip.Width = 190;
            // 
            // btnObrisiPolicajca
            // 
            btnObrisiPolicajca.BackColor = System.Drawing.Color.DeepSkyBlue;
            btnObrisiPolicajca.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            btnObrisiPolicajca.FlatAppearance.BorderSize = 3;
            btnObrisiPolicajca.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(0, 0, 64);
            btnObrisiPolicajca.FlatStyle = FlatStyle.Flat;
            btnObrisiPolicajca.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 238);
            btnObrisiPolicajca.Location = new System.Drawing.Point(15, 404);
            btnObrisiPolicajca.Margin = new Padding(5, 4, 5, 4);
            btnObrisiPolicajca.Name = "btnObrisiPolicajca";
            btnObrisiPolicajca.Size = new System.Drawing.Size(214, 76);
            btnObrisiPolicajca.TabIndex = 5;
            btnObrisiPolicajca.Text = "Obrisi policajca";
            btnObrisiPolicajca.UseVisualStyleBackColor = false;
            btnObrisiPolicajca.Click += btnObrisiPolicajca_Click_1;
            // 
<<<<<<< HEAD
            // PolicajciForm
=======
            // btnUnapredjenja
>>>>>>> 2618830652c68d717e88e1ca7c2cc2bfcce2412d
            // 
            btnUnapredjenja.BackColor = System.Drawing.Color.DeepSkyBlue;
            btnUnapredjenja.FlatStyle = FlatStyle.Flat;
            btnUnapredjenja.Location = new System.Drawing.Point(1086, 402);
            btnUnapredjenja.Name = "btnUnapredjenja";
            btnUnapredjenja.Size = new System.Drawing.Size(214, 76);
            btnUnapredjenja.TabIndex = 6;
            btnUnapredjenja.Text = "Unapredjenja izabranog policajca";
            btnUnapredjenja.UseVisualStyleBackColor = false;
            btnUnapredjenja.Click += btnUnapredjenja_Click;
            // 
            // btnObrazovanje
            // 
            btnObrazovanje.BackColor = System.Drawing.Color.DeepSkyBlue;
            btnObrazovanje.FlatStyle = FlatStyle.Flat;
            btnObrazovanje.Location = new System.Drawing.Point(1089, 501);
            btnObrazovanje.Name = "btnObrazovanje";
            btnObrazovanje.Size = new System.Drawing.Size(214, 76);
            btnObrazovanje.TabIndex = 7;
            btnObrazovanje.Text = "Obrazovanje izabranog policajca";
            btnObrazovanje.UseVisualStyleBackColor = false;
            btnObrazovanje.Click += btnObrazovanje_Click;
            // 
            // PolicajciForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.Color.SkyBlue;
<<<<<<< HEAD
            ClientSize = new System.Drawing.Size(1179, 450);
            Controls.Add(btnObrisiPolicajca);
            Controls.Add(ListaPolicajaca);
=======
            ClientSize = new System.Drawing.Size(1315, 600);
            Controls.Add(btnObrazovanje);
            Controls.Add(btnUnapredjenja);
            Controls.Add(btnObrisiPolicajca);
            Controls.Add(ListaPolicajaca);
            Margin = new Padding(3, 4, 3, 4);
>>>>>>> 2618830652c68d717e88e1ca7c2cc2bfcce2412d
            Name = "PolicajciForm";
            Text = "Policajci";
            Load += PolicajciForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView ListaPolicajaca;
        private ColumnHeader ID;
        private ColumnHeader Ime;
        private ColumnHeader Ime_roditelja;
        private ColumnHeader Prezime;
        private ColumnHeader JMBG;
        private ColumnHeader Datum_rodjenja;
        private ColumnHeader Adresa;
        private ColumnHeader Datum_prijema_u_sluzbu;
        private ColumnHeader Policijska_stanica;
        private ColumnHeader Sefuje_stanicom;
        private ColumnHeader Je_zamenik_u_stanici;
        private ColumnHeader Tip;
        private Button btnObrisiPolicajca;
        private Button btnUnapredjenja;
        private Button btnObrazovanje;
    }
}