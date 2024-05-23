namespace PolicijskaUprava.Forme.TehnickoLiceForme {
	partial class TehnickaLicaForm {
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
			dgvListaTehnickihLica = new DataGridView();
			bsTehnickoLice = new BindingSource(components);
			btnDodajTehnickoLice = new Button();
			btnObrisiTehnickoLice = new Button();
			btnIzmeniTehnickoLice = new Button();
			btnIstorijaOdrzavanja = new Button();
			((System.ComponentModel.ISupportInitialize)dgvListaTehnickihLica).BeginInit();
			((System.ComponentModel.ISupportInitialize)bsTehnickoLice).BeginInit();
			SuspendLayout();
			// 
			// dgvListaTehnickihLica
			// 
			dgvListaTehnickihLica.AllowUserToAddRows = false;
			dgvListaTehnickihLica.AllowUserToDeleteRows = false;
			dgvListaTehnickihLica.AllowUserToResizeRows = false;
			dgvListaTehnickihLica.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvListaTehnickihLica.Location = new System.Drawing.Point(12, 12);
			dgvListaTehnickihLica.MultiSelect = false;
			dgvListaTehnickihLica.Name = "dgvListaTehnickihLica";
			dgvListaTehnickihLica.ReadOnly = true;
			dgvListaTehnickihLica.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
			dgvListaTehnickihLica.Size = new System.Drawing.Size(459, 312);
			dgvListaTehnickihLica.TabIndex = 0;
			// 
			// btnDodajTehnickoLice
			// 
			btnDodajTehnickoLice.AutoSize = true;
			btnDodajTehnickoLice.Location = new System.Drawing.Point(477, 12);
			btnDodajTehnickoLice.Name = "btnDodajTehnickoLice";
			btnDodajTehnickoLice.Size = new System.Drawing.Size(150, 50);
			btnDodajTehnickoLice.TabIndex = 1;
			btnDodajTehnickoLice.Text = "Dodaj tehnicko lice";
			btnDodajTehnickoLice.UseVisualStyleBackColor = true;
			btnDodajTehnickoLice.Click += btnDodajTehnickoLice_Click;
			// 
			// btnObrisiTehnickoLice
			// 
			btnObrisiTehnickoLice.AutoSize = true;
			btnObrisiTehnickoLice.Location = new System.Drawing.Point(477, 124);
			btnObrisiTehnickoLice.Name = "btnObrisiTehnickoLice";
			btnObrisiTehnickoLice.Size = new System.Drawing.Size(150, 50);
			btnObrisiTehnickoLice.TabIndex = 2;
			btnObrisiTehnickoLice.Text = "Obrisi tehnicko lice";
			btnObrisiTehnickoLice.UseVisualStyleBackColor = true;
			btnObrisiTehnickoLice.Click += btnObrisiTehnickoLice_Click;
			// 
			// btnIzmeniTehnickoLice
			// 
			btnIzmeniTehnickoLice.AutoSize = true;
			btnIzmeniTehnickoLice.Location = new System.Drawing.Point(477, 68);
			btnIzmeniTehnickoLice.Name = "btnIzmeniTehnickoLice";
			btnIzmeniTehnickoLice.Size = new System.Drawing.Size(150, 50);
			btnIzmeniTehnickoLice.TabIndex = 3;
			btnIzmeniTehnickoLice.Text = "Izmeni tehnicko lice";
			btnIzmeniTehnickoLice.UseVisualStyleBackColor = true;
			btnIzmeniTehnickoLice.Click += btnIzmeniTehnickoLice_Click;
			// 
			// btnIstorijaOdrzavanja
			// 
			btnIstorijaOdrzavanja.AutoSize = true;
			btnIstorijaOdrzavanja.Location = new System.Drawing.Point(477, 180);
			btnIstorijaOdrzavanja.Name = "btnIstorijaOdrzavanja";
			btnIstorijaOdrzavanja.Size = new System.Drawing.Size(150, 50);
			btnIstorijaOdrzavanja.TabIndex = 4;
			btnIstorijaOdrzavanja.Text = "Istorija odrzavanja";
			btnIstorijaOdrzavanja.UseVisualStyleBackColor = true;
			btnIstorijaOdrzavanja.Click += btnIstorijaOdrzavanja_Click;
			// 
			// TehnickaLicaForm
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = System.Drawing.Color.SkyBlue;
			ClientSize = new System.Drawing.Size(639, 336);
			Controls.Add(btnIstorijaOdrzavanja);
			Controls.Add(btnIzmeniTehnickoLice);
			Controls.Add(btnObrisiTehnickoLice);
			Controls.Add(btnDodajTehnickoLice);
			Controls.Add(dgvListaTehnickihLica);
			Name = "TehnickaLicaForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Tehnicka lica";
			((System.ComponentModel.ISupportInitialize)dgvListaTehnickihLica).EndInit();
			((System.ComponentModel.ISupportInitialize)bsTehnickoLice).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dgvListaTehnickihLica;
		private BindingSource bsTehnickoLice;
		private Button btnDodajTehnickoLice;
		private Button btnObrisiTehnickoLice;
		private Button btnIzmeniTehnickoLice;
		private Button btnIstorijaOdrzavanja;
	}
}