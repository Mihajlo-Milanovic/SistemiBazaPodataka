﻿namespace PolicijskaUprava.Forme.UnapredjenjeForme
{
    partial class UnapredjenjeForm
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
			dgvUnapredjenja = new DataGridView();
			bindingSource1 = new BindingSource(components);
			btnDodaj = new Button();
			btnObrisi = new Button();
			((System.ComponentModel.ISupportInitialize)dgvUnapredjenja).BeginInit();
			((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
			SuspendLayout();
			// 
			// dgvUnapredjenja
			// 
			dgvUnapredjenja.BackgroundColor = System.Drawing.Color.Silver;
			dgvUnapredjenja.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvUnapredjenja.Location = new System.Drawing.Point(12, 24);
			dgvUnapredjenja.Name = "dgvUnapredjenja";
			dgvUnapredjenja.RowHeadersWidth = 51;
			dgvUnapredjenja.Size = new System.Drawing.Size(495, 288);
			dgvUnapredjenja.TabIndex = 0;
			// 
			// btnDodaj
			// 
			btnDodaj.BackColor = System.Drawing.Color.Aqua;
			btnDodaj.FlatStyle = FlatStyle.System;
			btnDodaj.Location = new System.Drawing.Point(516, 24);
			btnDodaj.Name = "btnDodaj";
			btnDodaj.Size = new System.Drawing.Size(200, 50);
			btnDodaj.TabIndex = 1;
			btnDodaj.Text = "Dodaj novo unapredjenje";
			btnDodaj.UseVisualStyleBackColor = false;
			btnDodaj.Click += btnDodaj_Click;
			// 
			// btnObrisi
			// 
			btnObrisi.BackColor = System.Drawing.Color.Cyan;
			btnObrisi.FlatStyle = FlatStyle.System;
			btnObrisi.Location = new System.Drawing.Point(516, 80);
			btnObrisi.Name = "btnObrisi";
			btnObrisi.Size = new System.Drawing.Size(200, 50);
			btnObrisi.TabIndex = 2;
			btnObrisi.Text = "Obrisi izabrana unapredjenja";
			btnObrisi.UseVisualStyleBackColor = false;
			btnObrisi.Click += btnObrisi_Click;
			// 
			// UnapredjenjeForm
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = System.Drawing.Color.SkyBlue;
			ClientSize = new System.Drawing.Size(720, 324);
			Controls.Add(btnObrisi);
			Controls.Add(btnDodaj);
			Controls.Add(dgvUnapredjenja);
			Margin = new Padding(3, 4, 3, 4);
			Name = "UnapredjenjeForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "UnapredjenjeForm";
			((System.ComponentModel.ISupportInitialize)dgvUnapredjenja).EndInit();
			((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DataGridView dgvUnapredjenja;
        private BindingSource bindingSource1;
        private Button btnDodaj;
        private Button btnObrisi;
    }
}