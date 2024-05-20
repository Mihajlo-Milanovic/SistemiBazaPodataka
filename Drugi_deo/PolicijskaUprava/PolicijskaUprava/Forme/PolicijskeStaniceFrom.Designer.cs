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
            listView1 = new ListView();
            ID = new ColumnHeader();
            Naziv = new ColumnHeader();
            Opstina = new ColumnHeader();
            Adresa = new ColumnHeader();
            Datum_osnivanja = new ColumnHeader();
            Broj_vozila = new ColumnHeader();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            listView1.Columns.AddRange(new ColumnHeader[] { ID, Naziv, Opstina, Adresa, Datum_osnivanja, Broj_vozila });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new System.Drawing.Point(12, 12);
            listView1.Name = "listView1";
            listView1.Size = new System.Drawing.Size(755, 197);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
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
            // PolicijskeStaniceFrom
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.Color.SkyBlue;
            ClientSize = new System.Drawing.Size(779, 421);
            Controls.Add(listView1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "PolicijskeStaniceFrom";
            Text = "PolicijskeStaniceFrom";
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private ColumnHeader ID;
        private ColumnHeader Naziv;
        private ColumnHeader Opstina;
        private ColumnHeader Adresa;
        private ColumnHeader Datum_osnivanja;
        private ColumnHeader Broj_vozila;
    }
}