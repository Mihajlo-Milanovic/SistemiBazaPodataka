namespace PolicijskaUprava.Forme.TehnickoLiceForme {
	partial class IzmeniTehnickoLiceForm {
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
			tbxPrezime = new TextBox();
			lblPrezime = new Label();
			tbxIme = new TextBox();
			lblIme = new Label();
			btnIzmeniTehnickoLice = new Button();
			SuspendLayout();
			// 
			// tbxPrezime
			// 
			tbxPrezime.Location = new System.Drawing.Point(170, 100);
			tbxPrezime.Name = "tbxPrezime";
			tbxPrezime.Size = new System.Drawing.Size(177, 27);
			tbxPrezime.TabIndex = 5;
			// 
			// lblPrezime
			// 
			lblPrezime.AutoSize = true;
			lblPrezime.Location = new System.Drawing.Point(67, 107);
			lblPrezime.Name = "lblPrezime";
			lblPrezime.Size = new System.Drawing.Size(65, 20);
			lblPrezime.TabIndex = 7;
			lblPrezime.Text = "Prezime:";
			// 
			// tbxIme
			// 
			tbxIme.Location = new System.Drawing.Point(170, 54);
			tbxIme.Name = "tbxIme";
			tbxIme.Size = new System.Drawing.Size(177, 27);
			tbxIme.TabIndex = 4;
			// 
			// lblIme
			// 
			lblIme.AutoSize = true;
			lblIme.Location = new System.Drawing.Point(67, 61);
			lblIme.Name = "lblIme";
			lblIme.Size = new System.Drawing.Size(37, 20);
			lblIme.TabIndex = 6;
			lblIme.Text = "Ime:";
			// 
			// btnIzmeniTehnickoLice
			// 
			btnIzmeniTehnickoLice.Location = new System.Drawing.Point(118, 167);
			btnIzmeniTehnickoLice.Name = "btnIzmeniTehnickoLice";
			btnIzmeniTehnickoLice.Size = new System.Drawing.Size(200, 50);
			btnIzmeniTehnickoLice.TabIndex = 8;
			btnIzmeniTehnickoLice.Text = "Izmeni";
			btnIzmeniTehnickoLice.UseVisualStyleBackColor = true;
			btnIzmeniTehnickoLice.Click += btnIzmeniTehnickoLice_Click;
			// 
			// IzmeniTehnickoLiceForm
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = System.Drawing.Color.SkyBlue;
			ClientSize = new System.Drawing.Size(431, 262);
			Controls.Add(tbxPrezime);
			Controls.Add(lblPrezime);
			Controls.Add(tbxIme);
			Controls.Add(lblIme);
			Controls.Add(btnIzmeniTehnickoLice);
			Name = "IzmeniTehnickoLiceForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "IzmeniTehnickoLiceForm";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox tbxPrezime;
		private Label lblPrezime;
		private TextBox tbxIme;
		private Label lblIme;
		private Button btnIzmeniTehnickoLice;
	}
}