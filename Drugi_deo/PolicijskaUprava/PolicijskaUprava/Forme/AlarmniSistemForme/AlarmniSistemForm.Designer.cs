namespace PolicijskaUprava.Forme.AlarmniSistemForme {
	partial class AlarmniSistemForm {
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
			dataGridView1 = new DataGridView();
			btnDodajAS = new Button();
			btnIzmeniAS = new Button();
			btnObrisiAS = new Button();
			bsAS = new BindingSource(components);
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			((System.ComponentModel.ISupportInitialize)bsAS).BeginInit();
			SuspendLayout();
			// 
			// dataGridView1
			// 
			dataGridView1.AllowUserToAddRows = false;
			dataGridView1.AllowUserToDeleteRows = false;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new System.Drawing.Point(12, 12);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.ReadOnly = true;
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.Size = new System.Drawing.Size(958, 310);
			dataGridView1.TabIndex = 0;
			// 
			// btnDodajAS
			// 
			btnDodajAS.AutoSize = true;
			btnDodajAS.Location = new System.Drawing.Point(112, 361);
			btnDodajAS.Name = "btnDodajAS";
			btnDodajAS.Size = new System.Drawing.Size(163, 50);
			btnDodajAS.TabIndex = 1;
			btnDodajAS.Text = "Dodaj alarmni sistem";
			btnDodajAS.UseVisualStyleBackColor = true;
			btnDodajAS.Click += btnDodajAS_Click;
			// 
			// btnIzmeniAS
			// 
			btnIzmeniAS.AutoSize = true;
			btnIzmeniAS.Location = new System.Drawing.Point(407, 361);
			btnIzmeniAS.Name = "btnIzmeniAS";
			btnIzmeniAS.Size = new System.Drawing.Size(163, 50);
			btnIzmeniAS.TabIndex = 2;
			btnIzmeniAS.Text = "Izmeni alarmni sistem";
			btnIzmeniAS.UseVisualStyleBackColor = true;
			btnIzmeniAS.Click += btnIzmeniAS_Click;
			// 
			// btnObrisiAS
			// 
			btnObrisiAS.AutoSize = true;
			btnObrisiAS.Location = new System.Drawing.Point(684, 361);
			btnObrisiAS.Name = "btnObrisiAS";
			btnObrisiAS.Size = new System.Drawing.Size(163, 50);
			btnObrisiAS.TabIndex = 3;
			btnObrisiAS.Text = "Obrisi alarmni sistem";
			btnObrisiAS.UseVisualStyleBackColor = true;
			btnObrisiAS.Click += btnObrisiAS_Click;
			// 
			// bsAS
			// 
			bsAS.AllowNew = false;
			// 
			// AlarmniSistemForm
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(982, 453);
			Controls.Add(btnObrisiAS);
			Controls.Add(btnIzmeniAS);
			Controls.Add(btnDodajAS);
			Controls.Add(dataGridView1);
			Name = "AlarmniSistemForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "AlarmniSistemForma";
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			((System.ComponentModel.ISupportInitialize)bsAS).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dataGridView1;
		private Button btnDodajAS;
		private Button btnIzmeniAS;
		private Button btnObrisiAS;
		private BindingSource bsAS;
	}
}