namespace PolicijskaUprava.Forme.PolicijskaStanicaForme {
	partial class DodajPolicajcaStaniciForm {
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
			lblPolicajac = new Label();
			label2 = new Label();
			btnIzaberi = new Button();
			rbtnZaposleni = new RadioButton();
			rbtnSef = new RadioButton();
			rbtnZamenik = new RadioButton();
			btnDodaj = new Button();
			SuspendLayout();
			// 
			// lblPolicajac
			// 
			lblPolicajac.AutoSize = true;
			lblPolicajac.Location = new System.Drawing.Point(49, 41);
			lblPolicajac.Name = "lblPolicajac";
			lblPolicajac.Size = new System.Drawing.Size(74, 20);
			lblPolicajac.TabIndex = 0;
			lblPolicajac.Text = "Policajac: ";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new System.Drawing.Point(61, 91);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(62, 20);
			label2.TabIndex = 1;
			label2.Text = "Pozicija:";
			// 
			// btnIzaberi
			// 
			btnIzaberi.Location = new System.Drawing.Point(129, 34);
			btnIzaberi.Name = "btnIzaberi";
			btnIzaberi.Size = new System.Drawing.Size(149, 34);
			btnIzaberi.TabIndex = 2;
			btnIzaberi.Text = "Izaberite policajca";
			btnIzaberi.UseVisualStyleBackColor = true;
			btnIzaberi.Click += button1_Click;
			// 
			// rbtnZaposleni
			// 
			rbtnZaposleni.AutoSize = true;
			rbtnZaposleni.Location = new System.Drawing.Point(129, 91);
			rbtnZaposleni.Name = "rbtnZaposleni";
			rbtnZaposleni.Size = new System.Drawing.Size(95, 24);
			rbtnZaposleni.TabIndex = 3;
			rbtnZaposleni.TabStop = true;
			rbtnZaposleni.Text = "Zaposleni";
			rbtnZaposleni.UseVisualStyleBackColor = true;
			// 
			// rbtnSef
			// 
			rbtnSef.AutoSize = true;
			rbtnSef.Location = new System.Drawing.Point(129, 121);
			rbtnSef.Name = "rbtnSef";
			rbtnSef.Size = new System.Drawing.Size(51, 24);
			rbtnSef.TabIndex = 4;
			rbtnSef.TabStop = true;
			rbtnSef.Text = "Sef";
			rbtnSef.UseVisualStyleBackColor = true;
			// 
			// rbtnZamenik
			// 
			rbtnZamenik.AutoSize = true;
			rbtnZamenik.Location = new System.Drawing.Point(129, 153);
			rbtnZamenik.Name = "rbtnZamenik";
			rbtnZamenik.Size = new System.Drawing.Size(87, 24);
			rbtnZamenik.TabIndex = 5;
			rbtnZamenik.TabStop = true;
			rbtnZamenik.Text = "Zamenik";
			rbtnZamenik.UseVisualStyleBackColor = true;
			// 
			// btnDodaj
			// 
			btnDodaj.Location = new System.Drawing.Point(78, 200);
			btnDodaj.Name = "btnDodaj";
			btnDodaj.Size = new System.Drawing.Size(200, 50);
			btnDodaj.TabIndex = 6;
			btnDodaj.Text = "Dodaj";
			btnDodaj.UseVisualStyleBackColor = true;
			btnDodaj.Click += btnDodaj_Click;
			// 
			// DodajPolicajcaStaniciForm
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = System.Drawing.Color.SkyBlue;
			ClientSize = new System.Drawing.Size(348, 261);
			Controls.Add(btnDodaj);
			Controls.Add(rbtnZamenik);
			Controls.Add(rbtnSef);
			Controls.Add(rbtnZaposleni);
			Controls.Add(btnIzaberi);
			Controls.Add(label2);
			Controls.Add(lblPolicajac);
			Name = "DodajPolicajcaStaniciForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "DodajPolicajcaStanici";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblPolicajac;
		private Label label2;
		private Button btnIzaberi;
		private RadioButton rbtnZaposleni;
		private RadioButton rbtnSef;
		private RadioButton rbtnZamenik;
		private Button btnDodaj;
	}
}