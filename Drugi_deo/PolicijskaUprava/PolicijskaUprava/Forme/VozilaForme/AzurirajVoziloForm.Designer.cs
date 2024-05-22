namespace PolicijskaUprava.Forme.VozilaForme
{
    partial class AzurirajVoziloForm
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
            txtTip = new TextBox();
            txtRegOznaka = new TextBox();
            label5 = new Label();
            lblReg = new Label();
            txtModel = new TextBox();
            txtBoja = new TextBox();
            label4 = new Label();
            label2 = new Label();
            txtProizvodjac = new TextBox();
            label3 = new Label();
            btnAzuriraj = new Button();
            gbxParametri.SuspendLayout();
            SuspendLayout();
            // 
            // gbxParametri
            // 
            gbxParametri.Controls.Add(txtTip);
            gbxParametri.Controls.Add(txtRegOznaka);
            gbxParametri.Controls.Add(label5);
            gbxParametri.Controls.Add(lblReg);
            gbxParametri.Controls.Add(txtModel);
            gbxParametri.Controls.Add(txtBoja);
            gbxParametri.Controls.Add(label4);
            gbxParametri.Controls.Add(label2);
            gbxParametri.Controls.Add(txtProizvodjac);
            gbxParametri.Controls.Add(label3);
            gbxParametri.Location = new System.Drawing.Point(98, 27);
            gbxParametri.Name = "gbxParametri";
            gbxParametri.Size = new System.Drawing.Size(371, 363);
            gbxParametri.TabIndex = 13;
            gbxParametri.TabStop = false;
            gbxParametri.Text = "Parametri";
            // 
            // txtTip
            // 
            txtTip.Location = new System.Drawing.Point(182, 165);
            txtTip.Name = "txtTip";
            txtTip.Size = new System.Drawing.Size(125, 27);
            txtTip.TabIndex = 4;
            // 
            // txtRegOznaka
            // 
            txtRegOznaka.Location = new System.Drawing.Point(182, 54);
            txtRegOznaka.Name = "txtRegOznaka";
            txtRegOznaka.Size = new System.Drawing.Size(125, 27);
            txtRegOznaka.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = System.Drawing.Color.Black;
            label5.Location = new System.Drawing.Point(67, 295);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(55, 20);
            label5.TabIndex = 9;
            label5.Text = "Model:";
            // 
            // lblReg
            // 
            lblReg.AutoSize = true;
            lblReg.ForeColor = System.Drawing.Color.Black;
            lblReg.Location = new System.Drawing.Point(67, 61);
            lblReg.Name = "lblReg";
            lblReg.Size = new System.Drawing.Size(91, 20);
            lblReg.TabIndex = 1;
            lblReg.Text = "Reg Oznaka:";
            // 
            // txtModel
            // 
            txtModel.Location = new System.Drawing.Point(182, 288);
            txtModel.Name = "txtModel";
            txtModel.Size = new System.Drawing.Size(125, 27);
            txtModel.TabIndex = 8;
            // 
            // txtBoja
            // 
            txtBoja.Location = new System.Drawing.Point(182, 111);
            txtBoja.Name = "txtBoja";
            txtBoja.Size = new System.Drawing.Size(125, 27);
            txtBoja.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = System.Drawing.Color.Black;
            label4.Location = new System.Drawing.Point(67, 232);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(89, 20);
            label4.TabIndex = 7;
            label4.Text = "Proizvodjac:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = System.Drawing.Color.Black;
            label2.Location = new System.Drawing.Point(67, 118);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(42, 20);
            label2.TabIndex = 3;
            label2.Text = "Boja:";
            // 
            // txtProizvodjac
            // 
            txtProizvodjac.Location = new System.Drawing.Point(182, 225);
            txtProizvodjac.Name = "txtProizvodjac";
            txtProizvodjac.Size = new System.Drawing.Size(125, 27);
            txtProizvodjac.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = System.Drawing.Color.Black;
            label3.Location = new System.Drawing.Point(67, 172);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(33, 20);
            label3.TabIndex = 5;
            label3.Text = "Tip:";
            // 
            // btnAzuriraj
            // 
            btnAzuriraj.Location = new System.Drawing.Point(568, 286);
            btnAzuriraj.Name = "btnAzuriraj";
            btnAzuriraj.Size = new System.Drawing.Size(135, 56);
            btnAzuriraj.TabIndex = 12;
            btnAzuriraj.Text = "Azuriraj";
            btnAzuriraj.UseVisualStyleBackColor = true;
            btnAzuriraj.Click += btnAzuriraj_Click;
            // 
            // AzurirajVozilo
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(gbxParametri);
            Controls.Add(btnAzuriraj);
            Name = "AzurirajVozilo";
            Text = "Azuriraj vozilo";
            gbxParametri.ResumeLayout(false);
            gbxParametri.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbxParametri;
        private TextBox txtTip;
        private TextBox txtRegOznaka;
        private Label label5;
        private Label lblReg;
        private TextBox txtModel;
        private TextBox txtBoja;
        private Label label4;
        private Label label2;
        private TextBox txtProizvodjac;
        private Label label3;
        private Button btnAzuriraj;
    }
}