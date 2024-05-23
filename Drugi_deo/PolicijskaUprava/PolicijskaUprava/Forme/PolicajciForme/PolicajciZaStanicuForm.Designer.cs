namespace PolicijskaUprava.Forme.PolicajciForme
{
    partial class PolicajciZaStanicuForm_
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
            components = new System.ComponentModel.Container();
            btnObrisi = new Button();
            btnAzuriraj = new Button();
            btnDodaj = new Button();
            dgvPolicajci = new DataGridView();
            bindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgvPolicajci).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // btnObrisi
            // 
            btnObrisi.BackColor = System.Drawing.Color.Cyan;
            btnObrisi.FlatStyle = FlatStyle.System;
            btnObrisi.Location = new System.Drawing.Point(644, 353);
            btnObrisi.Margin = new Padding(4, 3, 4, 3);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new System.Drawing.Size(200, 50);
            btnObrisi.TabIndex = 7;
            btnObrisi.Text = "Obrisi";
            btnObrisi.UseVisualStyleBackColor = false;
            btnObrisi.Click += btnObrisi_Click;
            // 
            // btnAzuriraj
            // 
            btnAzuriraj.BackColor = System.Drawing.Color.Cyan;
            btnAzuriraj.FlatStyle = FlatStyle.System;
            btnAzuriraj.Location = new System.Drawing.Point(327, 353);
            btnAzuriraj.Margin = new Padding(4, 3, 4, 3);
            btnAzuriraj.Name = "btnAzuriraj";
            btnAzuriraj.Size = new System.Drawing.Size(200, 50);
            btnAzuriraj.TabIndex = 6;
            btnAzuriraj.Text = "Azuriraj";
            btnAzuriraj.UseVisualStyleBackColor = false;
            btnAzuriraj.Click += btnAzuriraj_Click;
            // 
            // btnDodaj
            // 
            btnDodaj.BackColor = System.Drawing.Color.Cyan;
            btnDodaj.FlatStyle = FlatStyle.System;
            btnDodaj.Location = new System.Drawing.Point(13, 353);
            btnDodaj.Margin = new Padding(4, 3, 4, 3);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new System.Drawing.Size(200, 50);
            btnDodaj.TabIndex = 5;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = false;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // dgvPolicajci
            // 
            dgvPolicajci.BackgroundColor = System.Drawing.Color.LightCyan;
            dgvPolicajci.BorderStyle = BorderStyle.Fixed3D;
            dgvPolicajci.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPolicajci.Location = new System.Drawing.Point(13, 12);
            dgvPolicajci.Margin = new Padding(4, 3, 4, 3);
            dgvPolicajci.MultiSelect = false;
            dgvPolicajci.Name = "dgvPolicajci";
            dgvPolicajci.RowHeadersWidth = 51;
            dgvPolicajci.Size = new System.Drawing.Size(831, 326);
            dgvPolicajci.TabIndex = 4;
            // 
            // PolicajciZaStanicuForm_
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.Color.SkyBlue;
            ClientSize = new System.Drawing.Size(858, 423);
            Controls.Add(btnObrisi);
            Controls.Add(btnAzuriraj);
            Controls.Add(btnDodaj);
            Controls.Add(dgvPolicajci);
            Name = "PolicajciZaStanicuForm_";
            Text = "PolicajciZaStanicuForm_";
            ((System.ComponentModel.ISupportInitialize)dgvPolicajci).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnObrisi;
        private Button btnAzuriraj;
        private Button btnDodaj;
        private DataGridView dgvPolicajci;
        private BindingSource bindingSource1;
    }
}