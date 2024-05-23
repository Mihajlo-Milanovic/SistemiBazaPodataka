namespace PolicijskaUprava.Forme.OdrzavaForme {
	partial class OdrzavaForm {
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
			dgvOdrzava = new DataGridView();
			bsIstorijaOdrzavanja = new BindingSource(components);
			btnDodaj = new Button();
			btnObrisi = new Button();
			((System.ComponentModel.ISupportInitialize)dgvOdrzava).BeginInit();
			((System.ComponentModel.ISupportInitialize)bsIstorijaOdrzavanja).BeginInit();
			SuspendLayout();
			// 
			// dgvOdrzava
			// 
			dgvOdrzava.AllowUserToAddRows = false;
			dgvOdrzava.AllowUserToDeleteRows = false;
			dgvOdrzava.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvOdrzava.Location = new System.Drawing.Point(12, 12);
			dgvOdrzava.MultiSelect = false;
			dgvOdrzava.Name = "dgvOdrzava";
			dgvOdrzava.ReadOnly = true;
			dgvOdrzava.RowHeadersWidth = 51;
			dgvOdrzava.RowTemplate.ReadOnly = true;
			dgvOdrzava.Size = new System.Drawing.Size(596, 333);
			dgvOdrzava.TabIndex = 0;
			// 
			// btnDodaj
			// 
			btnDodaj.FlatStyle = FlatStyle.System;
			btnDodaj.Location = new System.Drawing.Point(44, 371);
			btnDodaj.Name = "btnDodaj";
			btnDodaj.Size = new System.Drawing.Size(200, 50);
			btnDodaj.TabIndex = 1;
			btnDodaj.Text = "Dodaj ";
			btnDodaj.UseVisualStyleBackColor = true;
			btnDodaj.Click += btnDodaj_Click;
			// 
			// btnObrisi
			// 
			btnObrisi.FlatStyle = FlatStyle.System;
			btnObrisi.Location = new System.Drawing.Point(380, 371);
			btnObrisi.Name = "btnObrisi";
			btnObrisi.Size = new System.Drawing.Size(200, 50);
			btnObrisi.TabIndex = 2;
			btnObrisi.Text = "Obrisi";
			btnObrisi.UseVisualStyleBackColor = true;
			btnObrisi.Click += btnObrisi_Click;
			// 
			// OdrzavaForm
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = System.Drawing.Color.SkyBlue;
			ClientSize = new System.Drawing.Size(622, 450);
			Controls.Add(btnObrisi);
			Controls.Add(btnDodaj);
			Controls.Add(dgvOdrzava);
			Name = "OdrzavaForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "OdrzavaForme";
			((System.ComponentModel.ISupportInitialize)dgvOdrzava).EndInit();
			((System.ComponentModel.ISupportInitialize)bsIstorijaOdrzavanja).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DataGridView dgvOdrzava;
		private BindingSource bsIstorijaOdrzavanja;
		private Button btnDodaj;
		private Button btnObrisi;
	}
}