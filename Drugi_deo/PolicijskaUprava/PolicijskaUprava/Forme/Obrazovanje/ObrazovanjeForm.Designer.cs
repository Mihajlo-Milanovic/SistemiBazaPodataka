namespace PolicijskaUprava.Forme.Obrazovanje
{
    partial class ObrazovanjeForm
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
			components = new System.ComponentModel.Container();
			dgvObrazovanja = new DataGridView();
			btnDodaj = new Button();
			btnObrisi = new Button();
			bindingSource1 = new BindingSource(components);
			((System.ComponentModel.ISupportInitialize)dgvObrazovanja).BeginInit();
			((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
			SuspendLayout();
			// 
			// dgvObrazovanja
			// 
			dgvObrazovanja.BackgroundColor = System.Drawing.Color.LightBlue;
			dgvObrazovanja.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvObrazovanja.Location = new System.Drawing.Point(12, 12);
			dgvObrazovanja.Name = "dgvObrazovanja";
			dgvObrazovanja.RowHeadersWidth = 51;
			dgvObrazovanja.Size = new System.Drawing.Size(419, 219);
			dgvObrazovanja.TabIndex = 0;
			// 
			// btnDodaj
			// 
			btnDodaj.BackColor = System.Drawing.Color.Cyan;
			btnDodaj.FlatStyle = FlatStyle.System;
			btnDodaj.Location = new System.Drawing.Point(437, 12);
			btnDodaj.Name = "btnDodaj";
			btnDodaj.Size = new System.Drawing.Size(200, 50);
			btnDodaj.TabIndex = 2;
			btnDodaj.Text = "Dodaj obrazovanje\r\n";
			btnDodaj.UseVisualStyleBackColor = false;
			btnDodaj.Click += btnDodaj_Click;
			// 
			// btnObrisi
			// 
			btnObrisi.BackColor = System.Drawing.Color.Cyan;
			btnObrisi.FlatStyle = FlatStyle.System;
			btnObrisi.Location = new System.Drawing.Point(437, 68);
			btnObrisi.Name = "btnObrisi";
			btnObrisi.Size = new System.Drawing.Size(200, 50);
			btnObrisi.TabIndex = 3;
			btnObrisi.Text = "Obrisi obrazovanje";
			btnObrisi.UseVisualStyleBackColor = false;
			btnObrisi.Click += btnObrisi_Click;
			// 
			// ObrazovanjeForm
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = System.Drawing.Color.SkyBlue;
			ClientSize = new System.Drawing.Size(646, 255);
			Controls.Add(btnObrisi);
			Controls.Add(btnDodaj);
			Controls.Add(dgvObrazovanja);
			Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Margin = new Padding(4, 3, 4, 3);
			Name = "ObrazovanjeForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "ObrazovanjeForme";
			((System.ComponentModel.ISupportInitialize)dgvObrazovanja).EndInit();
			((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DataGridView dgvObrazovanja;
        private Button btnDodaj;
        private Button btnObrisi;
        private BindingSource bindingSource1;
    }
}