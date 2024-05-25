namespace PolicijskaUprava.Forme.PatroleForme {
	partial class DodajPatroluForm {
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
			btnIzaberiSefa = new Button();
			btnDodaj = new Button();
			lblASId = new Label();
			lblDatumKraja = new Label();
			label1 = new Label();
			btnIzaberiPomocnika = new Button();
			btnIzaberiVozilo = new Button();
			SuspendLayout();
			// 
			// btnIzaberiSefa
			// 
			btnIzaberiSefa.FlatStyle = FlatStyle.System;
			btnIzaberiSefa.Location = new System.Drawing.Point(217, 87);
			btnIzaberiSefa.Name = "btnIzaberiSefa";
			btnIzaberiSefa.Size = new System.Drawing.Size(167, 34);
			btnIzaberiSefa.TabIndex = 1;
			btnIzaberiSefa.Text = "Izaberite";
			btnIzaberiSefa.UseVisualStyleBackColor = true;
			btnIzaberiSefa.Click += btnIzaberiSefa_Click;
			// 
			// btnDodaj
			// 
			btnDodaj.FlatStyle = FlatStyle.System;
			btnDodaj.Location = new System.Drawing.Point(117, 211);
			btnDodaj.Name = "btnDodaj";
			btnDodaj.Size = new System.Drawing.Size(200, 50);
			btnDodaj.TabIndex = 3;
			btnDodaj.Text = "Dodaj";
			btnDodaj.UseVisualStyleBackColor = true;
			btnDodaj.Click += btnDodaj_Click;
			// 
			// lblASId
			// 
			lblASId.AutoSize = true;
			lblASId.Location = new System.Drawing.Point(106, 168);
			lblASId.Name = "lblASId";
			lblASId.Size = new System.Drawing.Size(105, 20);
			lblASId.TabIndex = 12;
			lblASId.Text = "ID pomocnika:";
			// 
			// lblDatumKraja
			// 
			lblDatumKraja.AutoSize = true;
			lblDatumKraja.Location = new System.Drawing.Point(153, 101);
			lblDatumKraja.Name = "lblDatumKraja";
			lblDatumKraja.Size = new System.Drawing.Size(58, 20);
			lblDatumKraja.TabIndex = 11;
			lblDatumKraja.Text = "ID sefa:";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(30, 37);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(181, 20);
			label1.TabIndex = 10;
			label1.Text = "Registarska oznaka vozila:";
			// 
			// btnIzaberiPomocnika
			// 
			btnIzaberiPomocnika.FlatStyle = FlatStyle.System;
			btnIzaberiPomocnika.Location = new System.Drawing.Point(217, 154);
			btnIzaberiPomocnika.Name = "btnIzaberiPomocnika";
			btnIzaberiPomocnika.Size = new System.Drawing.Size(167, 34);
			btnIzaberiPomocnika.TabIndex = 2;
			btnIzaberiPomocnika.Text = "Izaberite";
			btnIzaberiPomocnika.UseVisualStyleBackColor = true;
			btnIzaberiPomocnika.Click += btnIzaberiPomocnika_Click;
			// 
			// btnIzaberiVozilo
			// 
			btnIzaberiVozilo.FlatStyle = FlatStyle.System;
			btnIzaberiVozilo.Location = new System.Drawing.Point(217, 23);
			btnIzaberiVozilo.Name = "btnIzaberiVozilo";
			btnIzaberiVozilo.Size = new System.Drawing.Size(167, 34);
			btnIzaberiVozilo.TabIndex = 0;
			btnIzaberiVozilo.Text = "Izaberite";
			btnIzaberiVozilo.UseVisualStyleBackColor = true;
			btnIzaberiVozilo.Click += btnIzaberiVozilo_Click;
			// 
			// DodajPatroluForm
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = System.Drawing.Color.SkyBlue;
			ClientSize = new System.Drawing.Size(439, 289);
			Controls.Add(btnIzaberiVozilo);
			Controls.Add(btnIzaberiPomocnika);
			Controls.Add(btnIzaberiSefa);
			Controls.Add(btnDodaj);
			Controls.Add(lblASId);
			Controls.Add(lblDatumKraja);
			Controls.Add(label1);
			Name = "DodajPatroluForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "DodajPatroluForm";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnIzaberiSefa;
		private Button btnDodaj;
		private Label lblASId;
		private Label lblDatumKraja;
		private Label label1;
		private Button btnIzaberiPomocnika;
		private Button btnIzaberiVozilo;
	}
}