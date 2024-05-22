namespace PolicijskaUprava.Forme.ObjekatForme
{
    partial class DodajObjekatForm
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
            groupBox1 = new GroupBox();
            txtPrezime = new TextBox();
            lblPrezime = new Label();
            txtIme = new TextBox();
            lblIme = new Label();
            numPovrsina = new NumericUpDown();
            txtAdresa = new TextBox();
            lblAdresa = new Label();
            lblPovrsina = new Label();
            txtTip = new TextBox();
            lblTip = new Label();
            btnDodaj = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numPovrsina).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtPrezime);
            groupBox1.Controls.Add(lblPrezime);
            groupBox1.Controls.Add(txtIme);
            groupBox1.Controls.Add(lblIme);
            groupBox1.Controls.Add(numPovrsina);
            groupBox1.Controls.Add(txtAdresa);
            groupBox1.Controls.Add(lblAdresa);
            groupBox1.Controls.Add(lblPovrsina);
            groupBox1.Controls.Add(txtTip);
            groupBox1.Controls.Add(lblTip);
            groupBox1.Location = new System.Drawing.Point(12, 31);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new System.Drawing.Size(425, 307);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Podaci o objektu";
            // 
            // txtPrezime
            // 
            txtPrezime.Location = new System.Drawing.Point(258, 245);
            txtPrezime.Margin = new Padding(3, 4, 3, 4);
            txtPrezime.Name = "txtPrezime";
            txtPrezime.Size = new System.Drawing.Size(137, 27);
            txtPrezime.TabIndex = 11;
            // 
            // lblPrezime
            // 
            lblPrezime.AutoSize = true;
            lblPrezime.Location = new System.Drawing.Point(65, 248);
            lblPrezime.Name = "lblPrezime";
            lblPrezime.Size = new System.Drawing.Size(187, 20);
            lblPrezime.TabIndex = 9;
            lblPrezime.Text = "Prezime odgovorne osobe:";
            // 
            // txtIme
            // 
            txtIme.Location = new System.Drawing.Point(258, 197);
            txtIme.Margin = new Padding(3, 4, 3, 4);
            txtIme.Name = "txtIme";
            txtIme.Size = new System.Drawing.Size(137, 27);
            txtIme.TabIndex = 8;
            // 
            // lblIme
            // 
            lblIme.AutoSize = true;
            lblIme.Location = new System.Drawing.Point(93, 200);
            lblIme.Name = "lblIme";
            lblIme.Size = new System.Drawing.Size(159, 20);
            lblIme.TabIndex = 7;
            lblIme.Text = "Ime odgovorne osobe:";
            // 
            // numPovrsina
            // 
            numPovrsina.Location = new System.Drawing.Point(258, 149);
            numPovrsina.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numPovrsina.Name = "numPovrsina";
            numPovrsina.Size = new System.Drawing.Size(137, 27);
            numPovrsina.TabIndex = 6;
            // 
            // txtAdresa
            // 
            txtAdresa.Location = new System.Drawing.Point(258, 102);
            txtAdresa.Margin = new Padding(3, 4, 3, 4);
            txtAdresa.Name = "txtAdresa";
            txtAdresa.Size = new System.Drawing.Size(137, 27);
            txtAdresa.TabIndex = 5;
            // 
            // lblAdresa
            // 
            lblAdresa.AutoSize = true;
            lblAdresa.Location = new System.Drawing.Point(195, 109);
            lblAdresa.Name = "lblAdresa";
            lblAdresa.Size = new System.Drawing.Size(62, 20);
            lblAdresa.TabIndex = 4;
            lblAdresa.Text = "Adresa: ";
            // 
            // lblPovrsina
            // 
            lblPovrsina.AutoSize = true;
            lblPovrsina.Location = new System.Drawing.Point(186, 156);
            lblPovrsina.Name = "lblPovrsina";
            lblPovrsina.Size = new System.Drawing.Size(66, 20);
            lblPovrsina.TabIndex = 4;
            lblPovrsina.Text = "Povrsina:";
            // 
            // txtTip
            // 
            txtTip.Location = new System.Drawing.Point(258, 54);
            txtTip.Margin = new Padding(3, 4, 3, 4);
            txtTip.Name = "txtTip";
            txtTip.Size = new System.Drawing.Size(137, 27);
            txtTip.TabIndex = 1;
            // 
            // lblTip
            // 
            lblTip.AutoSize = true;
            lblTip.Location = new System.Drawing.Point(219, 61);
            lblTip.Name = "lblTip";
            lblTip.Size = new System.Drawing.Size(33, 20);
            lblTip.TabIndex = 0;
            lblTip.Text = "Tip:";
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new System.Drawing.Point(69, 335);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new System.Drawing.Size(307, 61);
            btnDodaj.TabIndex = 2;
            btnDodaj.Text = "DODAJ!!!";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // DodajObjekatForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnDodaj);
            Controls.Add(groupBox1);
            Name = "DodajObjekatForm";
            Text = "DodajObjekatForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numPovrsina).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DateTimePicker dtpDatumOsnivanja;
        private NumericUpDown nudBrojVozila;
        private Label lblDatumOsnivanja;
        private TextBox tbxAdresa;
        private Label lblAdresa;
        private Label lblPovrsina;
        private TextBox txtTip;
        private Label lblTip;
        private TextBox txtPrezime;
        private Label lblPrezime;
        private TextBox txtIme;
        private Label lblIme;
        private NumericUpDown numPovrsina;
        private TextBox txtAdresa;
        private Button btnDodaj;
    }
}