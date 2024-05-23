namespace PolicijskaUprava.Forme.OdrzavaForm {
	partial class OdrzavaForm {
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
			dgvOdrzava = new DataGridView();
			bsIstorijaOdrzavanja = new BindingSource(components);
			((System.ComponentModel.ISupportInitialize)dgvOdrzava).BeginInit();
			((System.ComponentModel.ISupportInitialize)bsIstorijaOdrzavanja).BeginInit();
			SuspendLayout();
			// 
			// dgvOdrzava
			// 
			dgvOdrzava.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvOdrzava.Location = new System.Drawing.Point(12, 12);
			dgvOdrzava.Name = "dgvOdrzava";
			dgvOdrzava.RowHeadersWidth = 51;
			dgvOdrzava.Size = new System.Drawing.Size(776, 188);
			dgvOdrzava.TabIndex = 0;
			// 
			// OdrzavaForm
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(800, 450);
			Controls.Add(dgvOdrzava);
			Name = "OdrzavaForm";
			Text = "OdrzavaForm";
			((System.ComponentModel.ISupportInitialize)dgvOdrzava).EndInit();
			((System.ComponentModel.ISupportInitialize)bsIstorijaOdrzavanja).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DataGridView dgvOdrzava;
		private BindingSource bsIstorijaOdrzavanja;
	}
}