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
		private void InitializeComponent() {
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
			btnDodaj = new Button();
			btnAzuriraj = new Button();
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
			ListaPolicajaca.Size = new System.Drawing.Size(1331, 513);
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
			btnObrisiPolicajca.BackColor = System.Drawing.Color.SlateBlue;
			btnObrisiPolicajca.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
			btnObrisiPolicajca.FlatAppearance.BorderSize = 3;
			btnObrisiPolicajca.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(0, 0, 64);
			btnObrisiPolicajca.FlatStyle = FlatStyle.System;
			btnObrisiPolicajca.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			btnObrisiPolicajca.Location = new System.Drawing.Point(579, 537);
			btnObrisiPolicajca.Margin = new Padding(5, 4, 5, 4);
			btnObrisiPolicajca.Name = "btnObrisiPolicajca";
			btnObrisiPolicajca.Size = new System.Drawing.Size(200, 50);
			btnObrisiPolicajca.TabIndex = 5;
			btnObrisiPolicajca.Text = "Obrisi";
			btnObrisiPolicajca.UseVisualStyleBackColor = false;
			btnObrisiPolicajca.Click += btnObrisiPolicajca_Click_1;
			// 
			// btnUnapredjenja
			// 
			btnUnapredjenja.BackColor = System.Drawing.Color.SlateBlue;
			btnUnapredjenja.FlatStyle = FlatStyle.System;
			btnUnapredjenja.Location = new System.Drawing.Point(861, 538);
			btnUnapredjenja.Name = "btnUnapredjenja";
			btnUnapredjenja.Size = new System.Drawing.Size(200, 50);
			btnUnapredjenja.TabIndex = 6;
			btnUnapredjenja.Text = "Unapredjenja";
			btnUnapredjenja.UseVisualStyleBackColor = false;
			btnUnapredjenja.Click += btnUnapredjenja_Click;
			// 
			// btnObrazovanje
			// 
			btnObrazovanje.BackColor = System.Drawing.Color.SlateBlue;
			btnObrazovanje.FlatStyle = FlatStyle.System;
			btnObrazovanje.Location = new System.Drawing.Point(1143, 538);
			btnObrazovanje.Name = "btnObrazovanje";
			btnObrazovanje.Size = new System.Drawing.Size(200, 50);
			btnObrazovanje.TabIndex = 7;
			btnObrazovanje.Text = "Obrazovanja";
			btnObrazovanje.UseVisualStyleBackColor = false;
			btnObrazovanje.Click += btnObrazovanje_Click;
			// 
			// btnDodaj
			// 
			btnDodaj.BackColor = System.Drawing.Color.Cyan;
			btnDodaj.FlatStyle = FlatStyle.System;
			btnDodaj.Location = new System.Drawing.Point(15, 537);
			btnDodaj.Margin = new Padding(5, 4, 5, 4);
			btnDodaj.Name = "btnDodaj";
			btnDodaj.Size = new System.Drawing.Size(200, 50);
			btnDodaj.TabIndex = 8;
			btnDodaj.Text = "Dodaj";
			btnDodaj.UseVisualStyleBackColor = false;
			btnDodaj.Click += btnDodaj_Click;
			// 
			// btnAzuriraj
			// 
			btnAzuriraj.BackColor = System.Drawing.Color.Cyan;
			btnAzuriraj.FlatStyle = FlatStyle.System;
			btnAzuriraj.Location = new System.Drawing.Point(297, 537);
			btnAzuriraj.Margin = new Padding(5, 4, 5, 4);
			btnAzuriraj.Name = "btnAzuriraj";
			btnAzuriraj.Size = new System.Drawing.Size(200, 50);
			btnAzuriraj.TabIndex = 9;
			btnAzuriraj.Text = "Azuriraj";
			btnAzuriraj.UseVisualStyleBackColor = false;
			btnAzuriraj.Click += btnAzuriraj_Click;
			// 
			// PolicajciForm
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = System.Drawing.Color.SkyBlue;
			ClientSize = new System.Drawing.Size(1360, 600);
			Controls.Add(btnAzuriraj);
			Controls.Add(btnDodaj);
			Controls.Add(btnObrazovanje);
			Controls.Add(btnUnapredjenja);
			Controls.Add(btnObrisiPolicajca);
			Controls.Add(ListaPolicajaca);
			Margin = new Padding(3, 4, 3, 4);
			Name = "PolicajciForm";
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
        private Button btnUnapredjenja;
        private Button btnObrazovanje;
		private Button btnDodaj;
		private Button btnAzuriraj;
	}
}