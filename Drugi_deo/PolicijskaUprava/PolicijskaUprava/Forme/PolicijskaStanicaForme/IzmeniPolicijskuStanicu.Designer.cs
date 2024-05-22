namespace PolicijskaUprava.Forme.PolicijskaStanicaForme
{
    partial class IzmeniPolicijskuStanicu
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
            btnIzmeni = new Button();
            groupBox1 = new GroupBox();
            dtpDatumOsnivanja = new DateTimePicker();
            nudBrojVozila = new NumericUpDown();
            tbxOpstina = new TextBox();
            lblDatumOsnivanja = new Label();
            tbxAdresa = new TextBox();
            lblAdresa = new Label();
            lblBrojVozila = new Label();
            lblOpstina = new Label();
            txbNaziv = new TextBox();
            lblNaziv = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudBrojVozila).BeginInit();
            SuspendLayout();
            // 
            // btnIzmeni
            // 
            btnIzmeni.BackColor = System.Drawing.Color.DeepSkyBlue;
            btnIzmeni.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            btnIzmeni.FlatAppearance.BorderSize = 3;
            btnIzmeni.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(0, 0, 64);
            btnIzmeni.FlatStyle = FlatStyle.Flat;
            btnIzmeni.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 238);
            btnIzmeni.Location = new System.Drawing.Point(286, 202);
            btnIzmeni.Margin = new Padding(4, 3, 4, 3);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new System.Drawing.Size(173, 57);
            btnIzmeni.TabIndex = 9;
            btnIzmeni.Text = "Izmeni";
            btnIzmeni.UseVisualStyleBackColor = false;
            btnIzmeni.Click += btnIzmeni_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpDatumOsnivanja);
            groupBox1.Controls.Add(nudBrojVozila);
            groupBox1.Controls.Add(tbxOpstina);
            groupBox1.Controls.Add(lblDatumOsnivanja);
            groupBox1.Controls.Add(tbxAdresa);
            groupBox1.Controls.Add(lblAdresa);
            groupBox1.Controls.Add(lblBrojVozila);
            groupBox1.Controls.Add(lblOpstina);
            groupBox1.Controls.Add(txbNaziv);
            groupBox1.Controls.Add(lblNaziv);
            groupBox1.Location = new System.Drawing.Point(11, 10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(268, 250);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Osnovni podaci o stanici";
            // 
            // dtpDatumOsnivanja
            // 
            dtpDatumOsnivanja.Format = DateTimePickerFormat.Short;
            dtpDatumOsnivanja.Location = new System.Drawing.Point(112, 171);
            dtpDatumOsnivanja.Name = "dtpDatumOsnivanja";
            dtpDatumOsnivanja.Size = new System.Drawing.Size(120, 23);
            dtpDatumOsnivanja.TabIndex = 9;
            // 
            // nudBrojVozila
            // 
            nudBrojVozila.Location = new System.Drawing.Point(112, 210);
            nudBrojVozila.Name = "nudBrojVozila";
            nudBrojVozila.ReadOnly = true;
            nudBrojVozila.Size = new System.Drawing.Size(120, 23);
            nudBrojVozila.TabIndex = 8;
            // 
            // tbxOpstina
            // 
            tbxOpstina.Location = new System.Drawing.Point(112, 81);
            tbxOpstina.Name = "tbxOpstina";
            tbxOpstina.Size = new System.Drawing.Size(120, 23);
            tbxOpstina.TabIndex = 8;
            // 
            // lblDatumOsnivanja
            // 
            lblDatumOsnivanja.AutoSize = true;
            lblDatumOsnivanja.Location = new System.Drawing.Point(7, 171);
            lblDatumOsnivanja.Name = "lblDatumOsnivanja";
            lblDatumOsnivanja.Size = new System.Drawing.Size(99, 15);
            lblDatumOsnivanja.TabIndex = 6;
            lblDatumOsnivanja.Text = "Datum osnivanja:";
            // 
            // tbxAdresa
            // 
            tbxAdresa.Location = new System.Drawing.Point(112, 124);
            tbxAdresa.Name = "tbxAdresa";
            tbxAdresa.Size = new System.Drawing.Size(120, 23);
            tbxAdresa.TabIndex = 5;
            // 
            // lblAdresa
            // 
            lblAdresa.AutoSize = true;
            lblAdresa.Location = new System.Drawing.Point(57, 127);
            lblAdresa.Name = "lblAdresa";
            lblAdresa.Size = new System.Drawing.Size(49, 15);
            lblAdresa.TabIndex = 4;
            lblAdresa.Text = "Adresa: ";
            // 
            // lblBrojVozila
            // 
            lblBrojVozila.AutoSize = true;
            lblBrojVozila.Location = new System.Drawing.Point(42, 215);
            lblBrojVozila.Name = "lblBrojVozila";
            lblBrojVozila.Size = new System.Drawing.Size(64, 15);
            lblBrojVozila.TabIndex = 4;
            lblBrojVozila.Text = "Broj vozila:";
            // 
            // lblOpstina
            // 
            lblOpstina.AutoSize = true;
            lblOpstina.Location = new System.Drawing.Point(55, 84);
            lblOpstina.Name = "lblOpstina";
            lblOpstina.Size = new System.Drawing.Size(51, 15);
            lblOpstina.TabIndex = 2;
            lblOpstina.Text = "Opstina:";
            // 
            // txbNaziv
            // 
            txbNaziv.Location = new System.Drawing.Point(112, 36);
            txbNaziv.Name = "txbNaziv";
            txbNaziv.Size = new System.Drawing.Size(120, 23);
            txbNaziv.TabIndex = 1;
            // 
            // lblNaziv
            // 
            lblNaziv.AutoSize = true;
            lblNaziv.Location = new System.Drawing.Point(67, 39);
            lblNaziv.Name = "lblNaziv";
            lblNaziv.Size = new System.Drawing.Size(39, 15);
            lblNaziv.TabIndex = 0;
            lblNaziv.Text = "Naziv:";
            // 
            // IzmeniPolicijskuStanicu
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.Color.SkyBlue;
            ClientSize = new System.Drawing.Size(469, 270);
            Controls.Add(btnIzmeni);
            Controls.Add(groupBox1);
            Name = "IzmeniPolicijskuStanicu";
            Text = "IzmeniPolicijskuStanicu";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudBrojVozila).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnIzmeni;
        private GroupBox groupBox1;
        private DateTimePicker dtpDatumOsnivanja;
        private NumericUpDown nudBrojVozila;
        private TextBox tbxOpstina;
        private Label lblDatumOsnivanja;
        private TextBox tbxAdresa;
        private Label lblAdresa;
        private Label lblBrojVozila;
        private Label lblOpstina;
        private TextBox txbNaziv;
        private Label lblNaziv;
    }
}