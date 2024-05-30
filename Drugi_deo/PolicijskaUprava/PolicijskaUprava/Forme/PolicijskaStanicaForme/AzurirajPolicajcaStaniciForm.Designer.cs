namespace PolicijskaUprava.Forme.PolicijskaStanicaForme {
	partial class AzurirajPolicajcaStaniciForm {
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
			rbtnZamenik = new RadioButton();
			rbtnSef = new RadioButton();
			rbtnZaposleni = new RadioButton();
			label2 = new Label();
			label1 = new Label();
			lblPolicajac = new Label();
			button1 = new Button();
			SuspendLayout();
			// 
			// rbtnZamenik
			// 
			rbtnZamenik.AutoSize = true;
			rbtnZamenik.Location = new System.Drawing.Point(105, 116);
			rbtnZamenik.Name = "rbtnZamenik";
			rbtnZamenik.Size = new System.Drawing.Size(87, 24);
			rbtnZamenik.TabIndex = 9;
			rbtnZamenik.TabStop = true;
			rbtnZamenik.Text = "Zamenik";
			rbtnZamenik.UseVisualStyleBackColor = true;
			rbtnZamenik.CheckedChanged += rbtnZaposleni_CheckedChanged;
			// 
			// rbtnSef
			// 
			rbtnSef.AutoSize = true;
			rbtnSef.Location = new System.Drawing.Point(105, 84);
			rbtnSef.Name = "rbtnSef";
			rbtnSef.Size = new System.Drawing.Size(51, 24);
			rbtnSef.TabIndex = 8;
			rbtnSef.TabStop = true;
			rbtnSef.Text = "Sef";
			rbtnSef.UseVisualStyleBackColor = true;
			rbtnSef.CheckedChanged += rbtnZaposleni_CheckedChanged;
			// 
			// rbtnZaposleni
			// 
			rbtnZaposleni.AutoSize = true;
			rbtnZaposleni.Location = new System.Drawing.Point(105, 54);
			rbtnZaposleni.Name = "rbtnZaposleni";
			rbtnZaposleni.Size = new System.Drawing.Size(95, 24);
			rbtnZaposleni.TabIndex = 7;
			rbtnZaposleni.TabStop = true;
			rbtnZaposleni.Text = "Zaposleni";
			rbtnZaposleni.UseVisualStyleBackColor = true;
			rbtnZaposleni.CheckedChanged += rbtnZaposleni_CheckedChanged;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new System.Drawing.Point(37, 54);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(62, 20);
			label2.TabIndex = 6;
			label2.Text = "Pozicija:";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(32, 22);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(89, 20);
			label1.TabIndex = 10;
			label1.Text = "Policajac ID:";
			// 
			// lblPolicajac
			// 
			lblPolicajac.AutoSize = true;
			lblPolicajac.Location = new System.Drawing.Point(156, 22);
			lblPolicajac.Name = "lblPolicajac";
			lblPolicajac.Size = new System.Drawing.Size(0, 20);
			lblPolicajac.TabIndex = 11;
			// 
			// button1
			// 
			button1.Location = new System.Drawing.Point(37, 160);
			button1.Name = "button1";
			button1.Size = new System.Drawing.Size(200, 50);
			button1.TabIndex = 12;
			button1.Text = "Izmeni";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// AzurirajPolicajcaStaniciForm
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = System.Drawing.Color.SkyBlue;
			ClientSize = new System.Drawing.Size(270, 222);
			Controls.Add(button1);
			Controls.Add(lblPolicajac);
			Controls.Add(label1);
			Controls.Add(rbtnZamenik);
			Controls.Add(rbtnSef);
			Controls.Add(rbtnZaposleni);
			Controls.Add(label2);
			Name = "AzurirajPolicajcaStaniciForm";
			Text = "AzurirajPolicajcaStaniciForm";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private RadioButton rbtnZamenik;
		private RadioButton rbtnSef;
		private RadioButton rbtnZaposleni;
		private Label label2;
		private Label label1;
		private Label lblPolicajac;
		private Button button1;
	}
}