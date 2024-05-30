namespace PolicijskaUprava.Forme.Obrazovanje
{
    partial class DodajObrazovanjeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
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
			txtSkola = new TextBox();
			dtpDiplomiranje = new DateTimePicker();
			label1 = new Label();
			label2 = new Label();
			groupBox1 = new GroupBox();
			btnDodaj = new Button();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// txtSkola
			// 
			txtSkola.Location = new System.Drawing.Point(176, 62);
			txtSkola.Margin = new Padding(3, 4, 3, 4);
			txtSkola.Name = "txtSkola";
			txtSkola.Size = new System.Drawing.Size(154, 27);
			txtSkola.TabIndex = 6;
			// 
			// dtpDiplomiranje
			// 
			dtpDiplomiranje.Format = DateTimePickerFormat.Short;
			dtpDiplomiranje.Location = new System.Drawing.Point(176, 109);
			dtpDiplomiranje.Name = "dtpDiplomiranje";
			dtpDiplomiranje.ShowUpDown = true;
			dtpDiplomiranje.Size = new System.Drawing.Size(154, 27);
			dtpDiplomiranje.TabIndex = 9;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(116, 65);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(54, 19);
			label1.TabIndex = 7;
			label1.Text = "Skola:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new System.Drawing.Point(17, 115);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(153, 19);
			label2.TabIndex = 8;
			label2.Text = "Datum diplomiranja:";
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(txtSkola);
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(dtpDiplomiranje);
			groupBox1.Controls.Add(label1);
			groupBox1.Location = new System.Drawing.Point(12, 12);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new System.Drawing.Size(376, 178);
			groupBox1.TabIndex = 10;
			groupBox1.TabStop = false;
			groupBox1.Text = "Podaci o obrazovanju";
			// 
			// btnDodaj
			// 
			btnDodaj.BackColor = System.Drawing.Color.Aqua;
			btnDodaj.FlatStyle = FlatStyle.System;
			btnDodaj.Location = new System.Drawing.Point(95, 196);
			btnDodaj.Name = "btnDodaj";
			btnDodaj.Size = new System.Drawing.Size(200, 50);
			btnDodaj.TabIndex = 11;
			btnDodaj.Text = "Dodaj";
			btnDodaj.UseVisualStyleBackColor = false;
			btnDodaj.Click += btnDodaj_Click;
			// 
			// DodajObrazovanjeForm
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = System.Drawing.Color.SkyBlue;
			ClientSize = new System.Drawing.Size(402, 255);
			Controls.Add(btnDodaj);
			Controls.Add(groupBox1);
			Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Margin = new Padding(4, 3, 4, 3);
			Name = "DodajObrazovanjeForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "DodajObrazovanjeForm";
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private TextBox txtSkola;
        private DateTimePicker dtpDiplomiranje;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private Button btnDodaj;
    }
}