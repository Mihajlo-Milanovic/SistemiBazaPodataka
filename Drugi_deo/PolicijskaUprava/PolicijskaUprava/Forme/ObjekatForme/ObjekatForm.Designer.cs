
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
            dgvObjekti.Location = new System.Drawing.Point(36, 26);
            dgvObjekti.Margin = new Padding(4, 3, 4, 3);
            dgvObjekti.Name = "dgvObjekti";
            dgvObjekti.RowHeadersWidth = 51;
            dgvObjekti.Size = new System.Drawing.Size(1203, 179);
            dgvObjekti.TabIndex = 0;
            dgvObjekti.CellClick += dgvObjekti_CellClick;
            dgvObjekti.RowHeaderMouseClick += dgvObjekti_RowHeaderMouseClick;
            // 
            // btnDodaj
            // 
            btnDodaj.BackColor = System.Drawing.Color.Cyan;
            btnDodaj.Location = new System.Drawing.Point(82, 226);
            btnDodaj.Margin = new Padding(4, 3, 4, 3);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new System.Drawing.Size(177, 58);
            btnDodaj.TabIndex = 1;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = false;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // btnAzuriraj
            // 
            btnAzuriraj.BackColor = System.Drawing.Color.Cyan;
            btnAzuriraj.Location = new System.Drawing.Point(396, 226);
            btnAzuriraj.Margin = new Padding(4, 3, 4, 3);
            btnAzuriraj.Name = "btnAzuriraj";
            btnAzuriraj.Size = new System.Drawing.Size(177, 58);
            btnAzuriraj.TabIndex = 2;
            btnAzuriraj.Text = "Azuriraj";
            btnAzuriraj.UseVisualStyleBackColor = false;
            btnAzuriraj.Click += btnAzuriraj_Click;
            // 
            // btnObrisi
            // 
            btnObrisi.BackColor = System.Drawing.Color.Cyan;
            btnObrisi.Location = new System.Drawing.Point(713, 226);
            btnObrisi.Margin = new Padding(4, 3, 4, 3);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new System.Drawing.Size(177, 58);
            btnObrisi.TabIndex = 3;
            btnObrisi.Text = "Obrisi";
            btnObrisi.UseVisualStyleBackColor = false;
            btnObrisi.Click += btnObrisi_Click;
            // 
            // btnBroj
            // 
            btnBroj.BackColor = System.Drawing.Color.Cyan;
            btnBroj.Location = new System.Drawing.Point(1012, 226);
            btnBroj.Margin = new Padding(4, 3, 4, 3);
            btnBroj.Name = "btnBroj";
            btnBroj.Size = new System.Drawing.Size(177, 58);
            btnBroj.TabIndex = 4;
            btnBroj.Text = "Dodaj broj telefona odgovorne osobe";
            btnBroj.UseVisualStyleBackColor = false;
            btnBroj.Click += btnBroj_Click;
            // 
            // ObjekatForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.Color.SkyBlue;
            ClientSize = new System.Drawing.Size(1279, 419);
            Controls.Add(btnBroj);
            Controls.Add(btnObrisi);
            Controls.Add(btnAzuriraj);
            Controls.Add(btnDodaj);
            Controls.Add(dgvObjekti);
            Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
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