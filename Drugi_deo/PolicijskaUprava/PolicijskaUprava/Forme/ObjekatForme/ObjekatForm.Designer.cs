
namespace PolicijskaUprava.Forme.ObjekatForme
{
    partial class ObjekatForm
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
            dgvObjekti = new DataGridView();
            bindingSource = new BindingSource(components);
            btnDodaj = new Button();
            btnAzuriraj = new Button();
            btnObrisi = new Button();
            btnBroj = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvObjekti).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource).BeginInit();
            SuspendLayout();
            // 
            // dgvObjekti
            // 
            dgvObjekti.BackgroundColor = System.Drawing.Color.LightCyan;
            dgvObjekti.BorderStyle = BorderStyle.Fixed3D;
            dgvObjekti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvObjekti.Location = new System.Drawing.Point(32, 27);
            dgvObjekti.Name = "dgvObjekti";
            dgvObjekti.RowHeadersWidth = 51;
            dgvObjekti.Size = new System.Drawing.Size(904, 188);
            dgvObjekti.TabIndex = 0;
            dgvObjekti.CellClick += dgvObjekti_CellClick;
            dgvObjekti.RowHeaderMouseClick += dgvObjekti_RowHeaderMouseClick;
            // 
            // btnDodaj
            // 
            btnDodaj.BackColor = System.Drawing.Color.Cyan;
            btnDodaj.Location = new System.Drawing.Point(32, 238);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new System.Drawing.Size(158, 61);
            btnDodaj.TabIndex = 1;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = false;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // btnAzuriraj
            // 
            btnAzuriraj.BackColor = System.Drawing.Color.Cyan;
            btnAzuriraj.Location = new System.Drawing.Point(209, 238);
            btnAzuriraj.Name = "btnAzuriraj";
            btnAzuriraj.Size = new System.Drawing.Size(158, 61);
            btnAzuriraj.TabIndex = 2;
            btnAzuriraj.Text = "Azuriraj";
            btnAzuriraj.UseVisualStyleBackColor = false;
            btnAzuriraj.Click += btnAzuriraj_Click;
            // 
            // btnObrisi
            // 
            btnObrisi.BackColor = System.Drawing.Color.Cyan;
            btnObrisi.Location = new System.Drawing.Point(386, 238);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new System.Drawing.Size(158, 61);
            btnObrisi.TabIndex = 3;
            btnObrisi.Text = "Obrisi";
            btnObrisi.UseVisualStyleBackColor = false;
            btnObrisi.Click += btnObrisi_Click;
            // 
            // btnBroj
            // 
            btnBroj.BackColor = System.Drawing.Color.Cyan;
            btnBroj.Location = new System.Drawing.Point(564, 238);
            btnBroj.Name = "btnBroj";
            btnBroj.Size = new System.Drawing.Size(158, 61);
            btnBroj.TabIndex = 4;
            btnBroj.Text = "Dodaj broj telefona odgovorne osobe";
            btnBroj.UseVisualStyleBackColor = false;
            btnBroj.Click += this.btnBroj_Click;
            // 
            // ObjekatForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.Color.SkyBlue;
            ClientSize = new System.Drawing.Size(966, 441);
            Controls.Add(btnBroj);
            Controls.Add(btnObrisi);
            Controls.Add(btnAzuriraj);
            Controls.Add(btnDodaj);
            Controls.Add(dgvObjekti);
            Name = "ObjekatForm";
            Text = "Objekat forma";
            Load += ObekatForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvObjekti).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvObjekti;
        private BindingSource bindingSource;
        private Button btnDodaj;
        private Button btnAzuriraj;
        private Button btnObrisi;
        private Button btnBroj;
    }
}