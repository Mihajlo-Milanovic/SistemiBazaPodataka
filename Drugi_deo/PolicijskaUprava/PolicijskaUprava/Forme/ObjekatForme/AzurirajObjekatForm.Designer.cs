namespace PolicijskaUprava.Forme.ObjekatForme
{
    partial class AzurirajObjekatForm
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
            gbxParametri = new GroupBox();
            numPovrsina = new NumericUpDown();
            txtTip = new TextBox();
            txtAdresa = new TextBox();
            label5 = new Label();
            lblAdresa = new Label();
            txtPrezime = new TextBox();
            label4 = new Label();
            lblPovrsina = new Label();
            txtIme = new TextBox();
            label3 = new Label();
            btnAzuriraj = new Button();
            gbxParametri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numPovrsina).BeginInit();
            SuspendLayout();
            // 
            // gbxParametri
            // 
            gbxParametri.Controls.Add(numPovrsina);
            gbxParametri.Controls.Add(txtTip);
            gbxParametri.Controls.Add(txtAdresa);
            gbxParametri.Controls.Add(label5);
            gbxParametri.Controls.Add(lblAdresa);
            gbxParametri.Controls.Add(txtPrezime);
            gbxParametri.Controls.Add(label4);
            gbxParametri.Controls.Add(lblPovrsina);
            gbxParametri.Controls.Add(txtIme);
            gbxParametri.Controls.Add(label3);
            gbxParametri.Location = new System.Drawing.Point(57, 35);
            gbxParametri.Name = "gbxParametri";
            gbxParametri.Size = new System.Drawing.Size(371, 363);
            gbxParametri.TabIndex = 14;
            gbxParametri.TabStop = false;
            gbxParametri.Text = "Parametri";
            // 
            // numPovrsina
            // 
            numPovrsina.Location = new System.Drawing.Point(182, 111);
            numPovrsina.Name = "numPovrsina";
            numPovrsina.Size = new System.Drawing.Size(125, 27);
            numPovrsina.TabIndex = 10;
            // 
            // txtTip
            // 
            txtTip.Location = new System.Drawing.Point(182, 165);
            txtTip.Name = "txtTip";
            txtTip.Size = new System.Drawing.Size(125, 27);
            txtTip.TabIndex = 4;
            // 
            // txtAdresa
            // 
            txtAdresa.Location = new System.Drawing.Point(182, 54);
            txtAdresa.Name = "txtAdresa";
            txtAdresa.Size = new System.Drawing.Size(125, 27);
            txtAdresa.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = System.Drawing.Color.Black;
            label5.Location = new System.Drawing.Point(55, 295);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(121, 20);
            label5.TabIndex = 9;
            label5.Text = "Kontakt prezime:";
            // 
            // lblAdresa
            // 
            lblAdresa.AutoSize = true;
            lblAdresa.ForeColor = System.Drawing.Color.Black;
            lblAdresa.Location = new System.Drawing.Point(118, 61);
            lblAdresa.Name = "lblAdresa";
            lblAdresa.Size = new System.Drawing.Size(58, 20);
            lblAdresa.TabIndex = 1;
            lblAdresa.Text = "Adresa:";
            // 
            // txtPrezime
            // 
            txtPrezime.Location = new System.Drawing.Point(182, 288);
            txtPrezime.Name = "txtPrezime";
            txtPrezime.Size = new System.Drawing.Size(125, 27);
            txtPrezime.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = System.Drawing.Color.Black;
            label4.Location = new System.Drawing.Point(84, 232);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(92, 20);
            label4.TabIndex = 7;
            label4.Text = "Kontakt ime:";
            // 
            // lblPovrsina
            // 
            lblPovrsina.AutoSize = true;
            lblPovrsina.ForeColor = System.Drawing.Color.Black;
            lblPovrsina.Location = new System.Drawing.Point(110, 118);
            lblPovrsina.Name = "lblPovrsina";
            lblPovrsina.Size = new System.Drawing.Size(66, 20);
            lblPovrsina.TabIndex = 3;
            lblPovrsina.Text = "Povrsina:";
            // 
            // txtIme
            // 
            txtIme.Location = new System.Drawing.Point(182, 225);
            txtIme.Name = "txtIme";
            txtIme.Size = new System.Drawing.Size(125, 27);
            txtIme.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = System.Drawing.Color.Black;
            label3.Location = new System.Drawing.Point(143, 168);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(33, 20);
            label3.TabIndex = 5;
            label3.Text = "Tip:";
            // 
            // btnAzuriraj
            // 
            btnAzuriraj.Location = new System.Drawing.Point(446, 330);
            btnAzuriraj.Name = "btnAzuriraj";
            btnAzuriraj.Size = new System.Drawing.Size(135, 69);
            btnAzuriraj.TabIndex = 15;
            btnAzuriraj.Text = "Azuriraj";
            btnAzuriraj.UseVisualStyleBackColor = true;
            btnAzuriraj.Click += btnAzuriraj_Click;
            // 
            // AzurirajObjekatForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnAzuriraj);
            Controls.Add(gbxParametri);
            Name = "AzurirajObjekatForm";
            Text = "Azuriraj objekat";
            gbxParametri.ResumeLayout(false);
            gbxParametri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numPovrsina).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbxParametri;
        private TextBox txtTip;
        private TextBox txtAdresa;
        private Label label5;
        private Label lblAdresa;
        private TextBox txtPrezime;
        private Label label4;
        private Label lblPovrsina;
        private TextBox txtIme;
        private Label label3;
        private NumericUpDown numPovrsina;
        private Button btnAzuriraj;
    }
}