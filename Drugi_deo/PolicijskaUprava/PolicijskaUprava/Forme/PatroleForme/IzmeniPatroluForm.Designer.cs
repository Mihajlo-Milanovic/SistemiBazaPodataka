namespace PolicijskaUprava.Forme.PatroleForme {
	partial class IzmeniPatroluForm {
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
			btnIzaberiVozilo = new Button();
			btnIzaberiPomocnika = new Button();
			btnIzaberiSefa = new Button();
			btnIzmeni = new Button();
			lblASId = new Label();
			lblDatumKraja = new Label();
			label1 = new Label();
			SuspendLayout();
			// 
			// btnIzaberiVozilo
			// 
			btnIzaberiVozilo.FlatStyle = FlatStyle.System;
			btnIzaberiVozilo.Location = new System.Drawing.Point(221, 25);
			btnIzaberiVozilo.Name = "btnIzaberiVozilo";
			btnIzaberiVozilo.Size = new System.Drawing.Size(167, 34);
			btnIzaberiVozilo.TabIndex = 13;
			btnIzaberiVozilo.Text = "Izaberite";
			btnIzaberiVozilo.UseVisualStyleBackColor = true;
			btnIzaberiVozilo.Click += btnIzaberiVozilo_Click;
			// 
			// btnIzaberiPomocnika
			// 
			btnIzaberiPomocnika.FlatStyle = FlatStyle.System;
			btnIzaberiPomocnika.Location = new System.Drawing.Point(221, 156);
			btnIzaberiPomocnika.Name = "btnIzaberiPomocnika";
			btnIzaberiPomocnika.Size = new System.Drawing.Size(167, 34);
			btnIzaberiPomocnika.TabIndex = 15;
			btnIzaberiPomocnika.Text = "Izaberite";
			btnIzaberiPomocnika.UseVisualStyleBackColor = true;
			btnIzaberiPomocnika.Click += btnIzaberiPomocnika_Click;
			// 
			// btnIzaberiSefa
			// 
			btnIzaberiSefa.FlatStyle = FlatStyle.System;
			btnIzaberiSefa.Location = new System.Drawing.Point(221, 89);
			btnIzaberiSefa.Name = "btnIzaberiSefa";
			btnIzaberiSefa.Size = new System.Drawing.Size(167, 34);
			btnIzaberiSefa.TabIndex = 14;
			btnIzaberiSefa.Text = "Izaberite";
			btnIzaberiSefa.UseVisualStyleBackColor = true;
			btnIzaberiSefa.Click += btnIzaberiSefa_Click;
			// 
			// btnIzmeni
			// 
			btnIzmeni.FlatStyle = FlatStyle.System;
			btnIzmeni.Location = new System.Drawing.Point(121, 213);
			btnIzmeni.Name = "btnIzmeni";
			btnIzmeni.Size = new System.Drawing.Size(200, 50);
			btnIzmeni.TabIndex = 16;
			btnIzmeni.Text = "Izmeni";
			btnIzmeni.UseVisualStyleBackColor = true;
			btnIzmeni.Click += btnIzmeni_Click;
			// 
			// lblASId
			// 
			lblASId.AutoSize = true;
			lblASId.Location = new System.Drawing.Point(110, 170);
			lblASId.Name = "lblASId";
			lblASId.Size = new System.Drawing.Size(105, 20);
			lblASId.TabIndex = 19;
			lblASId.Text = "ID pomocnika:";
			// 
			// lblDatumKraja
			// 
			lblDatumKraja.AutoSize = true;
			lblDatumKraja.Location = new System.Drawing.Point(157, 103);
			lblDatumKraja.Name = "lblDatumKraja";
			lblDatumKraja.Size = new System.Drawing.Size(58, 20);
			lblDatumKraja.TabIndex = 18;
			lblDatumKraja.Text = "ID sefa:";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(34, 39);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(181, 20);
			label1.TabIndex = 17;
			label1.Text = "Registarska oznaka vozila:";
			// 
			// IzmeniPatroluForm
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = System.Drawing.Color.SkyBlue;
			ClientSize = new System.Drawing.Size(440, 292);
			Controls.Add(btnIzaberiVozilo);
			Controls.Add(btnIzaberiPomocnika);
			Controls.Add(btnIzaberiSefa);
			Controls.Add(btnIzmeni);
			Controls.Add(lblASId);
			Controls.Add(lblDatumKraja);
			Controls.Add(label1);
			Name = "IzmeniPatroluForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "IzmeniPatroluForm";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnIzaberiVozilo;
		private Button btnIzaberiPomocnika;
		private Button btnIzaberiSefa;
		private Button btnIzmeni;
		private Label lblASId;
		private Label lblDatumKraja;
		private Label label1;
	}
}