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
            ListeStanice = new ListView();
            ID = new ColumnHeader();
            Naziv = new ColumnHeader();
            Opstina = new ColumnHeader();
            Adresa = new ColumnHeader();
            Datum_osnivanja = new ColumnHeader();
            Broj_vozila = new ColumnHeader();
            btnDodajPolicijskeStenice = new Button();
            btnObrisiPolicijskuStanicu = new Button();
            btnIzmeniStanicu = new Button();
            btnDodajPolicajca = new Button();
            SuspendLayout();
            // 
            // ListeStanice
            // 
            ListeStanice.BackColor = System.Drawing.SystemColors.ControlLightLight;
            ListeStanice.Columns.AddRange(new ColumnHeader[] { ID, Naziv, Opstina, Adresa, Datum_osnivanja, Broj_vozila });
            ListeStanice.FullRowSelect = true;
            ListeStanice.GridLines = true;
            ListeStanice.Location = new System.Drawing.Point(12, 12);
            ListeStanice.Name = "ListeStanice";
            ListeStanice.Size = new System.Drawing.Size(755, 197);
            ListeStanice.TabIndex = 0;
            ListeStanice.UseCompatibleStateImageBehavior = false;
            ListeStanice.View = View.Details;
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
            btnDodajPolicijskeStenice.FlatStyle = FlatStyle.Flat;
            btnDodajPolicijskeStenice.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 238);
            btnDodajPolicijskeStenice.Location = new System.Drawing.Point(12, 215);
            btnDodajPolicijskeStenice.Margin = new Padding(4, 3, 4, 3);
            btnDodajPolicijskeStenice.Name = "btnDodajPolicijskeStenice";
            btnDodajPolicijskeStenice.Size = new System.Drawing.Size(187, 57);
            btnDodajPolicijskeStenice.TabIndex = 6;
            btnDodajPolicijskeStenice.Text = "Dodatj policijsku stanicu";
            btnDodajPolicijskeStenice.UseVisualStyleBackColor = false;
            btnDodajPolicijskeStenice.Click += btnDodajPolicijskeStanice_Click;
            // 
            // btnObrisiPolicijskuStanicu
            // 
            btnObrisiPolicijskuStanicu.BackColor = System.Drawing.Color.DeepSkyBlue;
            btnObrisiPolicijskuStanicu.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            btnObrisiPolicijskuStanicu.FlatAppearance.BorderSize = 3;
            btnObrisiPolicijskuStanicu.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(0, 0, 64);
            btnObrisiPolicijskuStanicu.FlatStyle = FlatStyle.Flat;
            btnObrisiPolicijskuStanicu.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 238);
            btnObrisiPolicijskuStanicu.Location = new System.Drawing.Point(207, 215);
            btnObrisiPolicijskuStanicu.Margin = new Padding(4, 3, 4, 3);
            btnObrisiPolicijskuStanicu.Name = "btnObrisiPolicijskuStanicu";
            btnObrisiPolicijskuStanicu.Size = new System.Drawing.Size(187, 57);
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
            btnIzmeniStanicu.FlatStyle = FlatStyle.Flat;
            btnIzmeniStanicu.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 238);
            btnIzmeniStanicu.Location = new System.Drawing.Point(402, 215);
            btnIzmeniStanicu.Margin = new Padding(4, 3, 4, 3);
            btnIzmeniStanicu.Name = "btnIzmeniStanicu";
            btnIzmeniStanicu.Size = new System.Drawing.Size(187, 57);
            btnIzmeniStanicu.TabIndex = 8;
            btnIzmeniStanicu.Text = "Izmeni policijsku stanicu";
            btnIzmeniStanicu.UseVisualStyleBackColor = false;
            btnIzmeniStanicu.Click += btnIzmeniStanicu_Click;
            // 
            // btnDodajPolicajca
            // 
            btnDodajPolicajca.BackColor = System.Drawing.Color.DeepSkyBlue;
            btnDodajPolicajca.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            btnDodajPolicajca.FlatAppearance.BorderSize = 3;
            btnDodajPolicajca.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(0, 0, 64);
            btnDodajPolicajca.FlatStyle = FlatStyle.Flat;
            btnDodajPolicajca.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 238);
            btnDodajPolicajca.Location = new System.Drawing.Point(13, 278);
            btnDodajPolicajca.Margin = new Padding(4, 3, 4, 3);
            btnDodajPolicajca.Name = "btnDodajPolicajca";
            btnDodajPolicajca.Size = new System.Drawing.Size(187, 57);
            btnDodajPolicajca.TabIndex = 9;
            btnDodajPolicajca.Text = "Dodatj policajca";
            btnDodajPolicajca.UseVisualStyleBackColor = false;
            btnDodajPolicajca.Click += btnDodajPolicajca_Click;
            // 
            // PolicijskeStaniceFrom
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.Color.SkyBlue;
            ClientSize = new System.Drawing.Size(779, 421);
            Controls.Add(btnDodajPolicajca);
            Controls.Add(btnIzmeniStanicu);
            Controls.Add(btnObrisiPolicijskuStanicu);
            Controls.Add(btnDodajPolicijskeStenice);
            Controls.Add(ListeStanice);
            Margin = new Padding(4, 3, 4, 3);
            Name = "PolicijskeStaniceFrom";
            Text = "PolicijskeStaniceFrom";
            ResumeLayout(false);
        }

        #endregion

        private ListView ListeStanice;
        private ColumnHeader ID;
        private ColumnHeader Naziv;
        private ColumnHeader Opstina;
        private ColumnHeader Adresa;
        private ColumnHeader Datum_osnivanja;
        private ColumnHeader Broj_vozila;
        private Button btnDodajPolicijskeStenice;
        private Button btnObrisiPolicijskuStanicu;
        private Button btnIzmeniStanicu;
        private Button btnDodajPolicajca;
    }
}