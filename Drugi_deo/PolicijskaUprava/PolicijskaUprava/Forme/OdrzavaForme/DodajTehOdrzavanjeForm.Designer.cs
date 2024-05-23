namespace PolicijskaUprava.Forme.OdrzavaForme {
	partial class DodajTehOdrzavanjeForm {
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
			dtpPocetak = new DateTimePicker();
			dtpKraj = new DateTimePicker();
			label1 = new Label();
			lblDatumKraja = new Label();
			lblASId = new Label();
			btnDodaj = new Button();
			btnIzborAS = new Button();
			SuspendLayout();
			// 
			// dtpPocetak
			// 
			dtpPocetak.Format = DateTimePickerFormat.Short;
			dtpPocetak.Location = new System.Drawing.Point(166, 34);
			dtpPocetak.Name = "dtpPocetak";
			dtpPocetak.Size = new System.Drawing.Size(167, 27);
			dtpPocetak.TabIndex = 0;
			// 
			// dtpKraj
			// 
			dtpKraj.Format = DateTimePickerFormat.Short;
			dtpKraj.Location = new System.Drawing.Point(166, 85);
			dtpKraj.Name = "dtpKraj";
			dtpKraj.Size = new System.Drawing.Size(167, 27);
			dtpKraj.TabIndex = 1;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(46, 39);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(114, 20);
			label1.TabIndex = 3;
			label1.Text = "Datum pocetka:";
			// 
			// lblDatumKraja
			// 
			lblDatumKraja.AutoSize = true;
			lblDatumKraja.Location = new System.Drawing.Point(67, 90);
			lblDatumKraja.Name = "lblDatumKraja";
			lblDatumKraja.Size = new System.Drawing.Size(93, 20);
			lblDatumKraja.TabIndex = 4;
			lblDatumKraja.Text = "Datum kraja:";
			// 
			// lblASId
			// 
			lblASId.AutoSize = true;
			lblASId.Location = new System.Drawing.Point(11, 137);
			lblASId.Name = "lblASId";
			lblASId.Size = new System.Drawing.Size(149, 20);
			lblASId.TabIndex = 5;
			lblASId.Text = "ID alarmnog sistema:";
			// 
			// btnDodaj
			// 
			btnDodaj.Location = new System.Drawing.Point(78, 196);
			btnDodaj.Name = "btnDodaj";
			btnDodaj.Size = new System.Drawing.Size(200, 50);
			btnDodaj.TabIndex = 6;
			btnDodaj.Text = "Dodaj";
			btnDodaj.UseVisualStyleBackColor = true;
			btnDodaj.Click += btnDodaj_Click;
			// 
			// btnIzborAS
			// 
			btnIzborAS.Location = new System.Drawing.Point(166, 130);
			btnIzborAS.Name = "btnIzborAS";
			btnIzborAS.Size = new System.Drawing.Size(167, 34);
			btnIzborAS.TabIndex = 7;
			btnIzborAS.Text = "Izaberite";
			btnIzborAS.UseVisualStyleBackColor = true;
			btnIzborAS.Click += btnIzborAS_Click;
			// 
			// DodajOdrzavanjeForm
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = System.Drawing.Color.SkyBlue;
			ClientSize = new System.Drawing.Size(354, 283);
			Controls.Add(btnIzborAS);
			Controls.Add(btnDodaj);
			Controls.Add(lblASId);
			Controls.Add(lblDatumKraja);
			Controls.Add(label1);
			Controls.Add(dtpKraj);
			Controls.Add(dtpPocetak);
			Name = "DodajOdrzavanjeForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "DodajOdrzavanjeForm";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DateTimePicker dtpPocetak;
		private DateTimePicker dtpKraj;
		private Label label1;
		private Label lblDatumKraja;
		private Label lblASId;
		private Button btnDodaj;
		private Button btnIzborAS;
	}
}