namespace PolicijskaUprava.Forme.TehnickoLiceForme {
	partial class DodajTehnickoLiceForm {
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
			btnDodajTehnickoLice = new Button();
			lblIme = new Label();
			tbxIme = new TextBox();
			tbxPrezime = new TextBox();
			lblPrezime = new Label();
			SuspendLayout();
			// 
			// btnDodajTehnickoLice
			// 
			btnDodajTehnickoLice.Location = new System.Drawing.Point(119, 170);
			btnDodajTehnickoLice.Name = "btnDodajTehnickoLice";
			btnDodajTehnickoLice.Size = new System.Drawing.Size(200, 50);
			btnDodajTehnickoLice.TabIndex = 3;
			btnDodajTehnickoLice.Text = "Dodaj";
			btnDodajTehnickoLice.UseVisualStyleBackColor = true;
			btnDodajTehnickoLice.Click += btnDodajTehnickoLice_Click;
			// 
			// lblIme
			// 
			lblIme.AutoSize = true;
			lblIme.Location = new System.Drawing.Point(66, 62);
			lblIme.Name = "lblIme";
			lblIme.Size = new System.Drawing.Size(37, 20);
			lblIme.TabIndex = 1;
			lblIme.Text = "Ime:";
			// 
			// tbxIme
			// 
			tbxIme.Location = new System.Drawing.Point(169, 55);
			tbxIme.Name = "tbxIme";
			tbxIme.Size = new System.Drawing.Size(177, 27);
			tbxIme.TabIndex = 0;
			// 
			// tbxPrezime
			// 
			tbxPrezime.Location = new System.Drawing.Point(169, 101);
			tbxPrezime.Name = "tbxPrezime";
			tbxPrezime.Size = new System.Drawing.Size(177, 27);
			tbxPrezime.TabIndex = 1;
			// 
			// lblPrezime
			// 
			lblPrezime.AutoSize = true;
			lblPrezime.Location = new System.Drawing.Point(66, 108);
			lblPrezime.Name = "lblPrezime";
			lblPrezime.Size = new System.Drawing.Size(65, 20);
			lblPrezime.TabIndex = 3;
			lblPrezime.Text = "Prezime:";
			// 
			// DodajTehnickoLiceForm
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = System.Drawing.Color.SkyBlue;
			ClientSize = new System.Drawing.Size(430, 268);
			Controls.Add(tbxPrezime);
			Controls.Add(lblPrezime);
			Controls.Add(tbxIme);
			Controls.Add(lblIme);
			Controls.Add(btnDodajTehnickoLice);
			Name = "DodajTehnickoLiceForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "DodajTehnickoLice";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnDodajTehnickoLice;
		private Label lblIme;
		private TextBox tbxIme;
		private TextBox tbxPrezime;
		private Label lblPrezime;
	}
}