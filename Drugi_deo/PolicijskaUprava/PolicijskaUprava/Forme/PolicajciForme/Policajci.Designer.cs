namespace PolicijskaUprava.Forme
{
    partial class Policajci
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
            ListaPolicajaca.Location = new System.Drawing.Point(13, 12);
            ListaPolicajaca.Margin = new Padding(4, 3, 4, 3);
            ListaPolicajaca.MultiSelect = false;
            ListaPolicajaca.Name = "ListaPolicajaca";
            ListaPolicajaca.Size = new System.Drawing.Size(1125, 285);
            ListaPolicajaca.TabIndex = 1;
            ListaPolicajaca.UseCompatibleStateImageBehavior = false;
            ListaPolicajaca.View = View.Details;
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
            btnObrisiPolicajca.Location = new System.Drawing.Point(13, 303);
            btnObrisiPolicajca.Margin = new Padding(4, 3, 4, 3);
            btnObrisiPolicajca.Name = "btnObrisiPolicajca";
            btnObrisiPolicajca.Size = new System.Drawing.Size(187, 57);
            btnObrisiPolicajca.TabIndex = 5;
            btnObrisiPolicajca.Text = "Obrisi policajca";
            btnObrisiPolicajca.UseVisualStyleBackColor = false;
            btnObrisiPolicajca.Click += btnDodajPolicajca_Click_1;
            // 
            // Policajci
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.Color.SkyBlue;
            ClientSize = new System.Drawing.Size(1151, 450);
            Controls.Add(btnObrisiPolicajca);
            Controls.Add(ListaPolicajaca);
            Name = "Policajci";
            Text = "Policajci";
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
    }
}