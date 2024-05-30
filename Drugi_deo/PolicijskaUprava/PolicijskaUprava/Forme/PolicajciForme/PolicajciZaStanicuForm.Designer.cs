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
		private void InitializeComponent() {
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
			btnObrisi.Location = new System.Drawing.Point(756, 501);
			btnObrisi.Margin = new Padding(5, 4, 5, 4);
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
			btnAzuriraj.Location = new System.Drawing.Point(394, 501);
			btnAzuriraj.Margin = new Padding(5, 4, 5, 4);
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
			btnDodaj.Location = new System.Drawing.Point(35, 501);
			btnDodaj.Margin = new Padding(5, 4, 5, 4);
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
			dgvPolicajci.Location = new System.Drawing.Point(15, 16);
			dgvPolicajci.Margin = new Padding(5, 4, 5, 4);
			dgvPolicajci.MultiSelect = false;
			dgvPolicajci.Name = "dgvPolicajci";
			dgvPolicajci.RowHeadersWidth = 51;
			dgvPolicajci.Size = new System.Drawing.Size(950, 477);
			dgvPolicajci.TabIndex = 4;
			// 
			// PolicajciZaStanicuForm_
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = System.Drawing.Color.SkyBlue;
			ClientSize = new System.Drawing.Size(981, 564);
			Controls.Add(btnObrisi);
			Controls.Add(btnAzuriraj);
			Controls.Add(btnDodaj);
			Controls.Add(dgvPolicajci);
			Margin = new Padding(3, 4, 3, 4);
			Name = "PolicajciZaStanicuForm_";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "PolicajciZaStanicuForm";
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