namespace PolicijskaUprava.Forme.PatroleForme {
	partial class PatroleForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
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
			dgvPatrole = new DataGridView();
			btnDodaj = new Button();
			btnIzmeni = new Button();
			btnObrisi = new Button();
			bsPatrole = new BindingSource(components);
			((System.ComponentModel.ISupportInitialize)dgvPatrole).BeginInit();
			((System.ComponentModel.ISupportInitialize)bsPatrole).BeginInit();
			SuspendLayout();
			// 
			// dgvPatrole
			// 
			dgvPatrole.AllowUserToAddRows = false;
			dgvPatrole.AllowUserToDeleteRows = false;
			dgvPatrole.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvPatrole.Location = new System.Drawing.Point(12, 12);
			dgvPatrole.Name = "dgvPatrole";
			dgvPatrole.RowHeadersWidth = 51;
			dgvPatrole.Size = new System.Drawing.Size(776, 303);
			dgvPatrole.TabIndex = 0;
			// 
			// btnDodaj
			// 
			btnDodaj.FlatStyle = FlatStyle.System;
			btnDodaj.Location = new System.Drawing.Point(12, 321);
			btnDodaj.Name = "btnDodaj";
			btnDodaj.Size = new System.Drawing.Size(200, 50);
			btnDodaj.TabIndex = 1;
			btnDodaj.Text = "Dodaj";
			btnDodaj.UseVisualStyleBackColor = true;
			btnDodaj.Click += btnDodaj_Click;
			// 
			// btnIzmeni
			// 
			btnIzmeni.FlatStyle = FlatStyle.System;
			btnIzmeni.Location = new System.Drawing.Point(300, 319);
			btnIzmeni.Name = "btnIzmeni";
			btnIzmeni.Size = new System.Drawing.Size(200, 50);
			btnIzmeni.TabIndex = 2;
			btnIzmeni.Text = "Izmeni";
			btnIzmeni.UseVisualStyleBackColor = true;
			btnIzmeni.Click += btnIzmeni_Click;
			// 
			// btnObrisi
			// 
			btnObrisi.FlatStyle = FlatStyle.System;
			btnObrisi.Location = new System.Drawing.Point(588, 321);
			btnObrisi.Name = "btnObrisi";
			btnObrisi.Size = new System.Drawing.Size(200, 50);
			btnObrisi.TabIndex = 3;
			btnObrisi.Text = "Obrisi";
			btnObrisi.UseVisualStyleBackColor = true;
			btnObrisi.Click += btnObrisi_Click;
			// 
			// PatroleForm
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = System.Drawing.Color.SkyBlue;
			ClientSize = new System.Drawing.Size(800, 387);
			Controls.Add(btnObrisi);
			Controls.Add(btnIzmeni);
			Controls.Add(btnDodaj);
			Controls.Add(dgvPatrole);
			Name = "PatroleForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "PatroleForme";
			((System.ComponentModel.ISupportInitialize)dgvPatrole).EndInit();
			((System.ComponentModel.ISupportInitialize)bsPatrole).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DataGridView dgvPatrole;
		private Button btnDodaj;
		private Button btnIzmeni;
		private Button btnObrisi;
		private BindingSource bsPatrole;
	}
}