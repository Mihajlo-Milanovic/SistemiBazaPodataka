namespace PolicijskaUprava.Forme.AlarmniSistemForme {
	partial class IzmeniAlarmniSistemForm {
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
			cbxTip = new ComboBox();
			dtpDatumPoslednjegServisiranja = new DateTimePicker();
			dtpDatumPoslednjegAtesta = new DateTimePicker();
			dtpDatumInstalacije = new DateTimePicker();
			dtpGodinaProizvodnje = new DateTimePicker();
			lblTip = new Label();
			lblOpisOtklonjenogKvara = new Label();
			lblDatumPoslednjegServisiranja = new Label();
			lblDatumPoslednjegAtesta = new Label();
			lblDatumInstalacije = new Label();
			tbxOpisOtklonjenogKvara = new TextBox();
			lblGodinaProizvodnje = new Label();
			tbxModel = new TextBox();
			lblModel = new Label();
			tbxProizvodjac = new TextBox();
			lblProizvodjac = new Label();
			tbxSerijskiBroj = new TextBox();
			lblSerijskiBroj = new Label();
			gbxUltrazvucni = new GroupBox();
			numDonjaGranica = new NumericUpDown();
			numGornjaGranica = new NumericUpDown();
			lblDonjaGranica = new Label();
			lblGornjaGranica = new Label();
			btnIzmeniAlarmniSistem = new Button();
			gbxDetekcijePokreta = new GroupBox();
			tbxOsetljivost = new TextBox();
			lblOsetljivost = new Label();
			gbxDetekcijeToplotnogOdraza = new GroupBox();
			numVerRezIcKamere = new NumericUpDown();
			numHorRezIcKamere = new NumericUpDown();
			lblVerRezIcKamere = new Label();
			lblHorRezIcKamere = new Label();
			gbxUltrazvucni.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)numDonjaGranica).BeginInit();
			((System.ComponentModel.ISupportInitialize)numGornjaGranica).BeginInit();
			gbxDetekcijePokreta.SuspendLayout();
			gbxDetekcijeToplotnogOdraza.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)numVerRezIcKamere).BeginInit();
			((System.ComponentModel.ISupportInitialize)numHorRezIcKamere).BeginInit();
			SuspendLayout();
			// 
			// cbxTip
			// 
			cbxTip.DropDownStyle = ComboBoxStyle.DropDownList;
			cbxTip.FormattingEnabled = true;
			cbxTip.Location = new System.Drawing.Point(257, 281);
			cbxTip.Name = "cbxTip";
			cbxTip.Size = new System.Drawing.Size(200, 28);
			cbxTip.TabIndex = 35;
			// 
			// dtpDatumPoslednjegServisiranja
			// 
			dtpDatumPoslednjegServisiranja.CustomFormat = "yyyy";
			dtpDatumPoslednjegServisiranja.Format = DateTimePickerFormat.Short;
			dtpDatumPoslednjegServisiranja.Location = new System.Drawing.Point(257, 215);
			dtpDatumPoslednjegServisiranja.Name = "dtpDatumPoslednjegServisiranja";
			dtpDatumPoslednjegServisiranja.Size = new System.Drawing.Size(200, 27);
			dtpDatumPoslednjegServisiranja.TabIndex = 34;
			dtpDatumPoslednjegServisiranja.Value = new DateTime(2024, 5, 21, 0, 0, 0, 0);
			// 
			// dtpDatumPoslednjegAtesta
			// 
			dtpDatumPoslednjegAtesta.CustomFormat = "yyyy";
			dtpDatumPoslednjegAtesta.Format = DateTimePickerFormat.Short;
			dtpDatumPoslednjegAtesta.Location = new System.Drawing.Point(257, 182);
			dtpDatumPoslednjegAtesta.Name = "dtpDatumPoslednjegAtesta";
			dtpDatumPoslednjegAtesta.Size = new System.Drawing.Size(200, 27);
			dtpDatumPoslednjegAtesta.TabIndex = 33;
			dtpDatumPoslednjegAtesta.Value = new DateTime(2024, 5, 21, 0, 0, 0, 0);
			// 
			// dtpDatumInstalacije
			// 
			dtpDatumInstalacije.CustomFormat = "yyyy";
			dtpDatumInstalacije.Format = DateTimePickerFormat.Short;
			dtpDatumInstalacije.Location = new System.Drawing.Point(257, 149);
			dtpDatumInstalacije.Name = "dtpDatumInstalacije";
			dtpDatumInstalacije.Size = new System.Drawing.Size(200, 27);
			dtpDatumInstalacije.TabIndex = 32;
			dtpDatumInstalacije.Value = new DateTime(2024, 5, 21, 0, 0, 0, 0);
			// 
			// dtpGodinaProizvodnje
			// 
			dtpGodinaProizvodnje.CustomFormat = "yyyy";
			dtpGodinaProizvodnje.Format = DateTimePickerFormat.Custom;
			dtpGodinaProizvodnje.Location = new System.Drawing.Point(257, 116);
			dtpGodinaProizvodnje.Name = "dtpGodinaProizvodnje";
			dtpGodinaProizvodnje.Size = new System.Drawing.Size(200, 27);
			dtpGodinaProizvodnje.TabIndex = 31;
			dtpGodinaProizvodnje.Value = new DateTime(2024, 5, 21, 0, 0, 0, 0);
			// 
			// lblTip
			// 
			lblTip.AutoSize = true;
			lblTip.Location = new System.Drawing.Point(218, 284);
			lblTip.Name = "lblTip";
			lblTip.Size = new System.Drawing.Size(33, 20);
			lblTip.TabIndex = 30;
			lblTip.Text = "Tip:";
			// 
			// lblOpisOtklonjenogKvara
			// 
			lblOpisOtklonjenogKvara.AutoSize = true;
			lblOpisOtklonjenogKvara.Location = new System.Drawing.Point(86, 251);
			lblOpisOtklonjenogKvara.Name = "lblOpisOtklonjenogKvara";
			lblOpisOtklonjenogKvara.Size = new System.Drawing.Size(165, 20);
			lblOpisOtklonjenogKvara.TabIndex = 29;
			lblOpisOtklonjenogKvara.Text = "Opis otklonjenog kvara:";
			// 
			// lblDatumPoslednjegServisiranja
			// 
			lblDatumPoslednjegServisiranja.AutoSize = true;
			lblDatumPoslednjegServisiranja.Location = new System.Drawing.Point(39, 215);
			lblDatumPoslednjegServisiranja.Name = "lblDatumPoslednjegServisiranja";
			lblDatumPoslednjegServisiranja.Size = new System.Drawing.Size(212, 20);
			lblDatumPoslednjegServisiranja.TabIndex = 28;
			lblDatumPoslednjegServisiranja.Text = "Datum poslednjeg servisiranja:";
			// 
			// lblDatumPoslednjegAtesta
			// 
			lblDatumPoslednjegAtesta.AutoSize = true;
			lblDatumPoslednjegAtesta.Location = new System.Drawing.Point(72, 182);
			lblDatumPoslednjegAtesta.Name = "lblDatumPoslednjegAtesta";
			lblDatumPoslednjegAtesta.Size = new System.Drawing.Size(179, 20);
			lblDatumPoslednjegAtesta.TabIndex = 27;
			lblDatumPoslednjegAtesta.Text = "Datum poslednjeg atesta:";
			// 
			// lblDatumInstalacije
			// 
			lblDatumInstalacije.AutoSize = true;
			lblDatumInstalacije.Location = new System.Drawing.Point(124, 154);
			lblDatumInstalacije.Name = "lblDatumInstalacije";
			lblDatumInstalacije.Size = new System.Drawing.Size(127, 20);
			lblDatumInstalacije.TabIndex = 26;
			lblDatumInstalacije.Text = "Datum instalacije:";
			// 
			// tbxOpisOtklonjenogKvara
			// 
			tbxOpisOtklonjenogKvara.Location = new System.Drawing.Point(257, 248);
			tbxOpisOtklonjenogKvara.Multiline = true;
			tbxOpisOtklonjenogKvara.Name = "tbxOpisOtklonjenogKvara";
			tbxOpisOtklonjenogKvara.Size = new System.Drawing.Size(200, 27);
			tbxOpisOtklonjenogKvara.TabIndex = 25;
			// 
			// lblGodinaProizvodnje
			// 
			lblGodinaProizvodnje.AutoSize = true;
			lblGodinaProizvodnje.Location = new System.Drawing.Point(108, 116);
			lblGodinaProizvodnje.Name = "lblGodinaProizvodnje";
			lblGodinaProizvodnje.Size = new System.Drawing.Size(143, 20);
			lblGodinaProizvodnje.TabIndex = 24;
			lblGodinaProizvodnje.Text = "Godina proizvodnje:";
			// 
			// tbxModel
			// 
			tbxModel.Location = new System.Drawing.Point(257, 83);
			tbxModel.Name = "tbxModel";
			tbxModel.Size = new System.Drawing.Size(200, 27);
			tbxModel.TabIndex = 23;
			// 
			// lblModel
			// 
			lblModel.AutoSize = true;
			lblModel.Location = new System.Drawing.Point(196, 86);
			lblModel.Name = "lblModel";
			lblModel.Size = new System.Drawing.Size(55, 20);
			lblModel.TabIndex = 22;
			lblModel.Text = "Model:";
			// 
			// tbxProizvodjac
			// 
			tbxProizvodjac.Location = new System.Drawing.Point(257, 50);
			tbxProizvodjac.Name = "tbxProizvodjac";
			tbxProizvodjac.Size = new System.Drawing.Size(200, 27);
			tbxProizvodjac.TabIndex = 21;
			// 
			// lblProizvodjac
			// 
			lblProizvodjac.AutoSize = true;
			lblProizvodjac.Location = new System.Drawing.Point(162, 57);
			lblProizvodjac.Name = "lblProizvodjac";
			lblProizvodjac.Size = new System.Drawing.Size(89, 20);
			lblProizvodjac.TabIndex = 20;
			lblProizvodjac.Text = "Proizvodjac:";
			// 
			// tbxSerijskiBroj
			// 
			tbxSerijskiBroj.Location = new System.Drawing.Point(257, 17);
			tbxSerijskiBroj.Name = "tbxSerijskiBroj";
			tbxSerijskiBroj.Size = new System.Drawing.Size(200, 27);
			tbxSerijskiBroj.TabIndex = 19;
			// 
			// lblSerijskiBroj
			// 
			lblSerijskiBroj.AutoSize = true;
			lblSerijskiBroj.Location = new System.Drawing.Point(162, 20);
			lblSerijskiBroj.Name = "lblSerijskiBroj";
			lblSerijskiBroj.Size = new System.Drawing.Size(89, 20);
			lblSerijskiBroj.TabIndex = 18;
			lblSerijskiBroj.Text = "Serijski broj:";
			// 
			// gbxUltrazvucni
			// 
			gbxUltrazvucni.AutoSize = true;
			gbxUltrazvucni.Controls.Add(numDonjaGranica);
			gbxUltrazvucni.Controls.Add(numGornjaGranica);
			gbxUltrazvucni.Controls.Add(lblDonjaGranica);
			gbxUltrazvucni.Controls.Add(lblGornjaGranica);
			gbxUltrazvucni.Location = new System.Drawing.Point(9, 312);
			gbxUltrazvucni.Margin = new Padding(0);
			gbxUltrazvucni.Name = "gbxUltrazvucni";
			gbxUltrazvucni.Padding = new Padding(0);
			gbxUltrazvucni.Size = new System.Drawing.Size(502, 110);
			gbxUltrazvucni.TabIndex = 36;
			gbxUltrazvucni.TabStop = false;
			// 
			// numDonjaGranica
			// 
			numDonjaGranica.Location = new System.Drawing.Point(248, 60);
			numDonjaGranica.Name = "numDonjaGranica";
			numDonjaGranica.Size = new System.Drawing.Size(200, 27);
			numDonjaGranica.TabIndex = 20;
			// 
			// numGornjaGranica
			// 
			numGornjaGranica.Location = new System.Drawing.Point(248, 19);
			numGornjaGranica.Name = "numGornjaGranica";
			numGornjaGranica.Size = new System.Drawing.Size(200, 27);
			numGornjaGranica.TabIndex = 19;
			// 
			// lblDonjaGranica
			// 
			lblDonjaGranica.AutoSize = true;
			lblDonjaGranica.Location = new System.Drawing.Point(130, 64);
			lblDonjaGranica.Name = "lblDonjaGranica";
			lblDonjaGranica.Size = new System.Drawing.Size(105, 20);
			lblDonjaGranica.TabIndex = 19;
			lblDonjaGranica.Text = "Donja granica:";
			// 
			// lblGornjaGranica
			// 
			lblGornjaGranica.AutoSize = true;
			lblGornjaGranica.Location = new System.Drawing.Point(130, 23);
			lblGornjaGranica.Name = "lblGornjaGranica";
			lblGornjaGranica.Size = new System.Drawing.Size(109, 20);
			lblGornjaGranica.TabIndex = 19;
			lblGornjaGranica.Text = "Gornja granica:";
			// 
			// btnIzmeniAlarmniSistem
			// 
			btnIzmeniAlarmniSistem.Location = new System.Drawing.Point(162, 438);
			btnIzmeniAlarmniSistem.Name = "btnIzmeniAlarmniSistem";
			btnIzmeniAlarmniSistem.Size = new System.Drawing.Size(200, 50);
			btnIzmeniAlarmniSistem.TabIndex = 37;
			btnIzmeniAlarmniSistem.Text = "Izmeni";
			btnIzmeniAlarmniSistem.UseVisualStyleBackColor = true;
			btnIzmeniAlarmniSistem.Click += btnIzmeniAlarmniSistem_Click;
			// 
			// gbxDetekcijePokreta
			// 
			gbxDetekcijePokreta.AutoSize = true;
			gbxDetekcijePokreta.Controls.Add(tbxOsetljivost);
			gbxDetekcijePokreta.Controls.Add(lblOsetljivost);
			gbxDetekcijePokreta.Enabled = false;
			gbxDetekcijePokreta.Location = new System.Drawing.Point(604, 40);
			gbxDetekcijePokreta.Margin = new Padding(0);
			gbxDetekcijePokreta.Name = "gbxDetekcijePokreta";
			gbxDetekcijePokreta.Padding = new Padding(0);
			gbxDetekcijePokreta.Size = new System.Drawing.Size(502, 70);
			gbxDetekcijePokreta.TabIndex = 23;
			gbxDetekcijePokreta.TabStop = false;
			gbxDetekcijePokreta.Visible = false;
			// 
			// tbxOsetljivost
			// 
			tbxOsetljivost.Location = new System.Drawing.Point(242, 20);
			tbxOsetljivost.Name = "tbxOsetljivost";
			tbxOsetljivost.Size = new System.Drawing.Size(200, 27);
			tbxOsetljivost.TabIndex = 23;
			// 
			// lblOsetljivost
			// 
			lblOsetljivost.AutoSize = true;
			lblOsetljivost.Location = new System.Drawing.Point(148, 24);
			lblOsetljivost.Name = "lblOsetljivost";
			lblOsetljivost.Size = new System.Drawing.Size(81, 20);
			lblOsetljivost.TabIndex = 19;
			lblOsetljivost.Text = "Osetljivost:";
			// 
			// gbxDetekcijeToplotnogOdraza
			// 
			gbxDetekcijeToplotnogOdraza.AutoSize = true;
			gbxDetekcijeToplotnogOdraza.Controls.Add(numVerRezIcKamere);
			gbxDetekcijeToplotnogOdraza.Controls.Add(numHorRezIcKamere);
			gbxDetekcijeToplotnogOdraza.Controls.Add(lblVerRezIcKamere);
			gbxDetekcijeToplotnogOdraza.Controls.Add(lblHorRezIcKamere);
			gbxDetekcijeToplotnogOdraza.Enabled = false;
			gbxDetekcijeToplotnogOdraza.Location = new System.Drawing.Point(604, 129);
			gbxDetekcijeToplotnogOdraza.Margin = new Padding(0);
			gbxDetekcijeToplotnogOdraza.Name = "gbxDetekcijeToplotnogOdraza";
			gbxDetekcijeToplotnogOdraza.Size = new System.Drawing.Size(502, 113);
			gbxDetekcijeToplotnogOdraza.TabIndex = 38;
			gbxDetekcijeToplotnogOdraza.TabStop = false;
			gbxDetekcijeToplotnogOdraza.Visible = false;
			// 
			// numVerRezIcKamere
			// 
			numVerRezIcKamere.Location = new System.Drawing.Point(248, 60);
			numVerRezIcKamere.Maximum = new decimal(new int[] { 2160, 0, 0, 0 });
			numVerRezIcKamere.Name = "numVerRezIcKamere";
			numVerRezIcKamere.Size = new System.Drawing.Size(200, 27);
			numVerRezIcKamere.TabIndex = 20;
			// 
			// numHorRezIcKamere
			// 
			numHorRezIcKamere.Location = new System.Drawing.Point(248, 19);
			numHorRezIcKamere.Maximum = new decimal(new int[] { 3840, 0, 0, 0 });
			numHorRezIcKamere.Name = "numHorRezIcKamere";
			numHorRezIcKamere.Size = new System.Drawing.Size(200, 27);
			numHorRezIcKamere.TabIndex = 19;
			// 
			// lblVerRezIcKamere
			// 
			lblVerRezIcKamere.AutoSize = true;
			lblVerRezIcKamere.Location = new System.Drawing.Point(27, 67);
			lblVerRezIcKamere.Name = "lblVerRezIcKamere";
			lblVerRezIcKamere.Size = new System.Drawing.Size(215, 20);
			lblVerRezIcKamere.TabIndex = 19;
			lblVerRezIcKamere.Text = "Vertikalna rezolucija IC kamere:";
			// 
			// lblHorRezIcKamere
			// 
			lblHorRezIcKamere.AutoSize = true;
			lblHorRezIcKamere.Location = new System.Drawing.Point(6, 26);
			lblHorRezIcKamere.Name = "lblHorRezIcKamere";
			lblHorRezIcKamere.Size = new System.Drawing.Size(236, 20);
			lblHorRezIcKamere.TabIndex = 19;
			lblHorRezIcKamere.Text = "Horizontalna rezolucija IC kamere:";
			// 
			// IzmeniAlarmniSistemForm
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(523, 501);
			Controls.Add(gbxDetekcijeToplotnogOdraza);
			Controls.Add(gbxDetekcijePokreta);
			Controls.Add(btnIzmeniAlarmniSistem);
			Controls.Add(gbxUltrazvucni);
			Controls.Add(cbxTip);
			Controls.Add(dtpDatumPoslednjegServisiranja);
			Controls.Add(dtpDatumPoslednjegAtesta);
			Controls.Add(dtpDatumInstalacije);
			Controls.Add(dtpGodinaProizvodnje);
			Controls.Add(lblTip);
			Controls.Add(lblOpisOtklonjenogKvara);
			Controls.Add(lblDatumPoslednjegServisiranja);
			Controls.Add(lblDatumPoslednjegAtesta);
			Controls.Add(lblDatumInstalacije);
			Controls.Add(tbxOpisOtklonjenogKvara);
			Controls.Add(lblGodinaProizvodnje);
			Controls.Add(tbxModel);
			Controls.Add(lblModel);
			Controls.Add(tbxProizvodjac);
			Controls.Add(lblProizvodjac);
			Controls.Add(tbxSerijskiBroj);
			Controls.Add(lblSerijskiBroj);
			Name = "IzmeniAlarmniSistemForm";
			Text = "IzmeniAlarmniSistemForm";
			gbxUltrazvucni.ResumeLayout(false);
			gbxUltrazvucni.PerformLayout();
			((System.ComponentModel.ISupportInitialize)numDonjaGranica).EndInit();
			((System.ComponentModel.ISupportInitialize)numGornjaGranica).EndInit();
			gbxDetekcijePokreta.ResumeLayout(false);
			gbxDetekcijePokreta.PerformLayout();
			gbxDetekcijeToplotnogOdraza.ResumeLayout(false);
			gbxDetekcijeToplotnogOdraza.PerformLayout();
			((System.ComponentModel.ISupportInitialize)numVerRezIcKamere).EndInit();
			((System.ComponentModel.ISupportInitialize)numHorRezIcKamere).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ComboBox cbxTip;
		private DateTimePicker dtpDatumPoslednjegServisiranja;
		private DateTimePicker dtpDatumPoslednjegAtesta;
		private DateTimePicker dtpDatumInstalacije;
		private DateTimePicker dtpGodinaProizvodnje;
		private Label lblTip;
		private Label lblOpisOtklonjenogKvara;
		private Label lblDatumPoslednjegServisiranja;
		private Label lblDatumPoslednjegAtesta;
		private Label lblDatumInstalacije;
		private TextBox tbxOpisOtklonjenogKvara;
		private Label lblGodinaProizvodnje;
		private TextBox tbxModel;
		private Label lblModel;
		private TextBox tbxProizvodjac;
		private Label lblProizvodjac;
		private TextBox tbxSerijskiBroj;
		private Label lblSerijskiBroj;
		private GroupBox gbxUltrazvucni;
		private NumericUpDown numDonjaGranica;
		private NumericUpDown numGornjaGranica;
		private Label lblDonjaGranica;
		private Label lblGornjaGranica;
		private Button btnIzmeniAlarmniSistem;
		private GroupBox gbxDetekcijePokreta;
		private TextBox tbxOsetljivost;
		private Label lblOsetljivost;
		private GroupBox gbxDetekcijeToplotnogOdraza;
		private NumericUpDown numVerRezIcKamere;
		private NumericUpDown numHorRezIcKamere;
		private Label lblVerRezIcKamere;
		private Label lblHorRezIcKamere;
	}
}