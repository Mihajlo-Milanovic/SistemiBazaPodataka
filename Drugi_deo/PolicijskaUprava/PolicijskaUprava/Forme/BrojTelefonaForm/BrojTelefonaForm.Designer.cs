namespace PolicijskaUprava.Forme.BrojTelefonaForm
{
    partial class BrojTelefonaForm
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
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dgvBrojevi = new DataGridView();
            bindingSource1 = new BindingSource(components);
            btnDodaj = new Button();
            btnObrisi = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBrojevi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // dgvBrojevi
            // 
            dgvBrojevi.BackgroundColor = System.Drawing.Color.SkyBlue;
            dgvBrojevi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBrojevi.Location = new System.Drawing.Point(37, 28);
            dgvBrojevi.Name = "dgvBrojevi";
            dgvBrojevi.RowHeadersWidth = 51;
            dgvBrojevi.Size = new System.Drawing.Size(813, 179);
            dgvBrojevi.TabIndex = 0;
            // 
            // btnDodaj
            // 
            btnDodaj.BackColor = System.Drawing.Color.Cyan;
            btnDodaj.Location = new System.Drawing.Point(234, 239);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new System.Drawing.Size(148, 70);
            btnDodaj.TabIndex = 2;
            btnDodaj.Text = "Dodaj novi broj";
            btnDodaj.UseVisualStyleBackColor = false;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // btnObrisi
            // 
            btnObrisi.BackColor = System.Drawing.Color.Cyan;
            btnObrisi.Location = new System.Drawing.Point(473, 239);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new System.Drawing.Size(148, 70);
            btnObrisi.TabIndex = 3;
            btnObrisi.Text = "Obrisi broj";
            btnObrisi.UseVisualStyleBackColor = false;
            btnObrisi.Click += btnObrisi_Click;
            // 
            // BrojTelefonaForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.Color.DeepSkyBlue;
            ClientSize = new System.Drawing.Size(900, 428);
            Controls.Add(btnObrisi);
            Controls.Add(btnDodaj);
            Controls.Add(dgvBrojevi);
            Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Name = "BrojTelefonaForm";
            Text = "BrojTelefonaForm";
            Load += BrojTelefonaForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBrojevi).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvBrojevi;
        private BindingSource bindingSource1;
        private Button btnDodaj;
        private Button btnObrisi;
    }
}