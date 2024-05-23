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
        private void InitializeComponent()
        {
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
            dgvObrazovanja.Location = new System.Drawing.Point(33, 31);
            dgvObrazovanja.Name = "dgvObrazovanja";
            dgvObrazovanja.RowHeadersWidth = 51;
            dgvObrazovanja.Size = new System.Drawing.Size(833, 219);
            dgvObrazovanja.TabIndex = 0;
            // 
            // btnDodaj
            // 
            btnDodaj.BackColor = System.Drawing.Color.Cyan;
            btnDodaj.Location = new System.Drawing.Point(78, 293);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new System.Drawing.Size(155, 67);
            btnDodaj.TabIndex = 2;
            btnDodaj.Text = "Dodaj obrazovanje\r\n";
            btnDodaj.UseVisualStyleBackColor = false;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // btnObrisi
            // 
            btnObrisi.BackColor = System.Drawing.Color.Cyan;
            btnObrisi.Location = new System.Drawing.Point(661, 293);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new System.Drawing.Size(155, 67);
            btnObrisi.TabIndex = 3;
            btnObrisi.Text = "Obrisi obrazovanje";
            btnObrisi.UseVisualStyleBackColor = false;
            btnObrisi.Click += btnObrisi_Click;
            // 
            // ObrazovanjeForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.Color.DeepSkyBlue;
            ClientSize = new System.Drawing.Size(900, 428);
            Controls.Add(btnObrisi);
            Controls.Add(btnDodaj);
            Controls.Add(dgvObrazovanja);
            Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ObrazovanjeForm";
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