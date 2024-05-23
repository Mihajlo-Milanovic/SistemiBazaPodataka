namespace PolicijskaUprava.Forme
{
    partial class PolicijskeStaniceFrom
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
            lvListeStanice = new ListView();
            ID = new ColumnHeader();
            Naziv = new ColumnHeader();
            Opstina = new ColumnHeader();
            Adresa = new ColumnHeader();
            Datum_osnivanja = new ColumnHeader();
            Broj_vozila = new ColumnHeader();
            btnDodajPolicijskeStenice = new Button();
            btnObrisiPolicijskuStanicu = new Button();
            btnIzmeniStanicu = new Button();
            btnDodajObjekat = new Button();
            btnPolicajciKojiRadeTamo = new Button();
            SuspendLayout();
            // 
            // lvListeStanice
            // 
            lvListeStanice.BackColor = System.Drawing.SystemColors.ControlLightLight;
            lvListeStanice.Columns.AddRange(new ColumnHeader[] { ID, Naziv, Opstina, Adresa, Datum_osnivanja, Broj_vozila });
            lvListeStanice.FullRowSelect = true;
            lvListeStanice.GridLines = true;
            lvListeStanice.Location = new System.Drawing.Point(12, 12);
            lvListeStanice.MultiSelect = false;
            lvListeStanice.Name = "lvListeStanice";
            lvListeStanice.Size = new System.Drawing.Size(755, 296);
            lvListeStanice.Sorting = SortOrder.Ascending;
            lvListeStanice.TabIndex = 0;
            lvListeStanice.UseCompatibleStateImageBehavior = false;
            lvListeStanice.View = View.Details;
            // 
            // ID
            // 
            ID.Text = "ID";
            ID.Width = 50;
            // 
            // Naziv
            // 
            Naziv.Text = "Naziv";
            Naziv.Width = 150;
            // 
            // Opstina
            // 
            Opstina.Text = "Opstina";
            Opstina.Width = 150;
            // 
            // Adresa
            // 
            Adresa.Text = "Adresa";
            Adresa.Width = 150;
            // 
            // Datum_osnivanja
            // 
            Datum_osnivanja.Text = "Datum osnivanja";
            Datum_osnivanja.Width = 150;
            // 
            // Broj_vozila
            // 
            Broj_vozila.Text = "Broj vozila";
            Broj_vozila.Width = 100;
            // 
            // btnDodajPolicijskeStenice
            // 
            btnDodajPolicijskeStenice.BackColor = System.Drawing.Color.DeepSkyBlue;
            btnDodajPolicijskeStenice.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            btnDodajPolicijskeStenice.FlatAppearance.BorderSize = 3;
            btnDodajPolicijskeStenice.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(0, 0, 64);
            btnDodajPolicijskeStenice.FlatStyle = FlatStyle.System;
            btnDodajPolicijskeStenice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            btnDodajPolicijskeStenice.Location = new System.Drawing.Point(94, 321);
            btnDodajPolicijskeStenice.Margin = new Padding(4, 3, 4, 3);
            btnDodajPolicijskeStenice.Name = "btnDodajPolicijskeStenice";
            btnDodajPolicijskeStenice.Size = new System.Drawing.Size(175, 38);
            btnDodajPolicijskeStenice.TabIndex = 6;
            btnDodajPolicijskeStenice.Text = "Dodaj policijsku stanicu";
            btnDodajPolicijskeStenice.UseVisualStyleBackColor = false;
            btnDodajPolicijskeStenice.Click += btnDodajPolicijskeStanice_Click;
            // 
            // btnObrisiPolicijskuStanicu
            // 
            btnObrisiPolicijskuStanicu.BackColor = System.Drawing.Color.DeepSkyBlue;
            btnObrisiPolicijskuStanicu.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            btnObrisiPolicijskuStanicu.FlatAppearance.BorderSize = 3;
            btnObrisiPolicijskuStanicu.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(0, 0, 64);
            btnObrisiPolicijskuStanicu.FlatStyle = FlatStyle.System;
            btnObrisiPolicijskuStanicu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            btnObrisiPolicijskuStanicu.Location = new System.Drawing.Point(289, 321);
            btnObrisiPolicijskuStanicu.Margin = new Padding(4, 3, 4, 3);
            btnObrisiPolicijskuStanicu.Name = "btnObrisiPolicijskuStanicu";
            btnObrisiPolicijskuStanicu.Size = new System.Drawing.Size(175, 38);
            btnObrisiPolicijskuStanicu.TabIndex = 7;
            btnObrisiPolicijskuStanicu.Text = "Obrisi policijsku stanicu";
            btnObrisiPolicijskuStanicu.UseVisualStyleBackColor = false;
            btnObrisiPolicijskuStanicu.Click += btnObrisiPolicijskuStanicu_Click;
            // 
            // btnIzmeniStanicu
            // 
            btnIzmeniStanicu.BackColor = System.Drawing.Color.DeepSkyBlue;
            btnIzmeniStanicu.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            btnIzmeniStanicu.FlatAppearance.BorderSize = 3;
            btnIzmeniStanicu.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(0, 0, 64);
            btnIzmeniStanicu.FlatStyle = FlatStyle.System;
            btnIzmeniStanicu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            btnIzmeniStanicu.Location = new System.Drawing.Point(483, 321);
            btnIzmeniStanicu.Margin = new Padding(4, 3, 4, 3);
            btnIzmeniStanicu.Name = "btnIzmeniStanicu";
            btnIzmeniStanicu.Size = new System.Drawing.Size(175, 38);
            btnIzmeniStanicu.TabIndex = 8;
            btnIzmeniStanicu.Text = "Izmeni policijsku stanicu";
            btnIzmeniStanicu.UseVisualStyleBackColor = false;
            btnIzmeniStanicu.Click += btnIzmeniStanicu_Click;
            // 
            // btnDodajObjekat
            // 
            btnDodajObjekat.BackColor = System.Drawing.Color.DeepSkyBlue;
            btnDodajObjekat.FlatStyle = FlatStyle.System;
            btnDodajObjekat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            btnDodajObjekat.Location = new System.Drawing.Point(94, 371);
            btnDodajObjekat.Margin = new Padding(4, 3, 4, 3);
            btnDodajObjekat.Name = "btnDodajObjekat";
            btnDodajObjekat.Size = new System.Drawing.Size(175, 38);
            btnDodajObjekat.TabIndex = 10;
            btnDodajObjekat.Text = "Objekti koje cuva";
            btnDodajObjekat.UseVisualStyleBackColor = false;
            btnDodajObjekat.Click += btnVidiObjekte_Click;
            // 
            // btnPolicajciKojiRadeTamo
            // 
            btnPolicajciKojiRadeTamo.BackColor = System.Drawing.Color.DeepSkyBlue;
            btnPolicajciKojiRadeTamo.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            btnPolicajciKojiRadeTamo.FlatAppearance.BorderSize = 3;
            btnPolicajciKojiRadeTamo.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(0, 0, 64);
            btnPolicajciKojiRadeTamo.FlatStyle = FlatStyle.System;
            btnPolicajciKojiRadeTamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            btnPolicajciKojiRadeTamo.Location = new System.Drawing.Point(289, 371);
            btnPolicajciKojiRadeTamo.Margin = new Padding(4, 3, 4, 3);
            btnPolicajciKojiRadeTamo.Name = "btnPolicajciKojiRadeTamo";
            btnPolicajciKojiRadeTamo.Size = new System.Drawing.Size(175, 38);
            btnPolicajciKojiRadeTamo.TabIndex = 11;
            btnPolicajciKojiRadeTamo.Text = "Policajci koji rade tamo";
            btnPolicajciKojiRadeTamo.UseVisualStyleBackColor = false;
            btnPolicajciKojiRadeTamo.Click += btnPolicajciKojiRadeTamo_Click;
            // 
            // PolicijskeStaniceFrom
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.Color.SkyBlue;
            ClientSize = new System.Drawing.Size(779, 421);
            Controls.Add(btnPolicajciKojiRadeTamo);
            Controls.Add(btnDodajObjekat);
            Controls.Add(btnIzmeniStanicu);
            Controls.Add(btnObrisiPolicijskuStanicu);
            Controls.Add(btnDodajPolicijskeStenice);
            Controls.Add(lvListeStanice);
            Margin = new Padding(4, 3, 4, 3);
            Name = "PolicijskeStaniceFrom";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PolicijskeStaniceFrom";
            ResumeLayout(false);
        }

        #endregion

        private ListView lvListeStanice;
        private ColumnHeader ID;
        private ColumnHeader Naziv;
        private ColumnHeader Opstina;
        private ColumnHeader Adresa;
        private ColumnHeader Datum_osnivanja;
        private ColumnHeader Broj_vozila;
        private Button btnDodajPolicijskeStenice;
        private Button btnObrisiPolicijskuStanicu;
        private Button btnIzmeniStanicu;
        private Button btnDodajObjekat;
        private Button btnPolicajciKojiRadeTamo;
    }
}