namespace PolicijskaUprava.Forme.PolicajciForme
{
    partial class VozilaForm
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
			dgvVozila = new DataGridView();
			bindingSource1 = new BindingSource(components);
			btnDodajVozilo = new Button();
			btnObrisiVozilo = new Button();
			btnAzuriraj = new Button();
			((System.ComponentModel.ISupportInitialize)dgvVozila).BeginInit();
			((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
			SuspendLayout();
			// 
			// dgvVozila
			// 
			dgvVozila.BackgroundColor = System.Drawing.Color.SkyBlue;
			dgvVozila.BorderStyle = BorderStyle.None;
			dgvVozila.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvVozila.Location = new System.Drawing.Point(12, 12);
			dgvVozila.Name = "dgvVozila";
			dgvVozila.RowHeadersWidth = 51;
			dgvVozila.Size = new System.Drawing.Size(710, 188);
			dgvVozila.TabIndex = 0;
			dgvVozila.UseWaitCursor = true;
			// 
			// btnDodajVozilo
			// 
			btnDodajVozilo.Location = new System.Drawing.Point(12, 372);
			btnDodajVozilo.Name = "btnDodajVozilo";
			btnDodajVozilo.Size = new System.Drawing.Size(140, 66);
			btnDodajVozilo.TabIndex = 1;
			btnDodajVozilo.Text = "Dodaj Vozilo";
			btnDodajVozilo.UseVisualStyleBackColor = true;
			btnDodajVozilo.Click += btnDodajVozilo_Click;
			// 
			// btnObrisiVozilo
			// 
			btnObrisiVozilo.Location = new System.Drawing.Point(309, 372);
			btnObrisiVozilo.Name = "btnObrisiVozilo";
			btnObrisiVozilo.Size = new System.Drawing.Size(140, 66);
			btnObrisiVozilo.TabIndex = 2;
			btnObrisiVozilo.Text = "Obrisi Vozilo";
			btnObrisiVozilo.UseVisualStyleBackColor = true;
			btnObrisiVozilo.Click += btnObrisiVozilo_Click;
			// 
			// btnAzuriraj
			// 
			btnAzuriraj.Location = new System.Drawing.Point(582, 372);
			btnAzuriraj.Name = "btnAzuriraj";
			btnAzuriraj.Size = new System.Drawing.Size(140, 66);
			btnAzuriraj.TabIndex = 3;
			btnAzuriraj.Text = "Azuriraj Vozilo";
			btnAzuriraj.UseVisualStyleBackColor = true;
			btnAzuriraj.Click += btnAzurirajVozilo_Click;
			// 
			// VozilaForm
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = System.Drawing.Color.SkyBlue;
			ClientSize = new System.Drawing.Size(736, 450);
			Controls.Add(btnAzuriraj);
			Controls.Add(btnObrisiVozilo);
			Controls.Add(btnDodajVozilo);
			Controls.Add(dgvVozila);
			Name = "VozilaForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "VozilaForm";
			Load += VozilaForm_Load;
			((System.ComponentModel.ISupportInitialize)dgvVozila).EndInit();
			((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DataGridView dgvVozila;
        private BindingSource bindingSource1;
        private Button btnDodajVozilo;
        private Button btnObrisiVozilo;
        private Button btnAzuriraj;
    }
}