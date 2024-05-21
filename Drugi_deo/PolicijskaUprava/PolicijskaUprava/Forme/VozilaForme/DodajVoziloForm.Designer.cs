namespace PolicijskaUprava.Forme.VozilaForme
{
    partial class DodajVoziloForm
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
            txtRegOznaka = new TextBox();
            lblReg = new Label();
            label2 = new Label();
            txtBoja = new TextBox();
            label3 = new Label();
            txtTip = new TextBox();
            label4 = new Label();
            txtProizvodjac = new TextBox();
            label5 = new Label();
            txtModel = new TextBox();
            btnDodaj = new Button();
            gbxParametri = new GroupBox();
            gbxParametri.SuspendLayout();
            SuspendLayout();
            // 
            // txtRegOznaka
            // 
            txtRegOznaka.Location = new System.Drawing.Point(182, 54);
            txtRegOznaka.Name = "txtRegOznaka";
            txtRegOznaka.Size = new System.Drawing.Size(125, 27);
            txtRegOznaka.TabIndex = 0;
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
            // txtBoja
            // 
            txtBoja.Location = new System.Drawing.Point(182, 111);
            txtBoja.Name = "txtBoja";
            txtBoja.Size = new System.Drawing.Size(125, 27);
            txtBoja.TabIndex = 2;
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
            // txtTip
            // 
            txtTip.Location = new System.Drawing.Point(182, 165);
            txtTip.Name = "txtTip";
            txtTip.Size = new System.Drawing.Size(125, 27);
            txtTip.TabIndex = 4;
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
            // txtProizvodjac
            // 
            txtProizvodjac.Location = new System.Drawing.Point(182, 225);
            txtProizvodjac.Name = "txtProizvodjac";
            txtProizvodjac.Size = new System.Drawing.Size(125, 27);
            txtProizvodjac.TabIndex = 6;
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
            // txtModel
            // 
            txtModel.Location = new System.Drawing.Point(182, 288);
            txtModel.Name = "txtModel";
            txtModel.Size = new System.Drawing.Size(125, 27);
            txtModel.TabIndex = 8;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new System.Drawing.Point(566, 271);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new System.Drawing.Size(135, 56);
            btnDodaj.TabIndex = 10;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
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
            gbxParametri.Location = new System.Drawing.Point(96, 12);
            gbxParametri.Name = "gbxParametri";
            gbxParametri.Size = new System.Drawing.Size(371, 363);
            gbxParametri.TabIndex = 11;
            gbxParametri.TabStop = false;
            gbxParametri.Text = "Parametri";
            // 
            // DodajVozilo
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.Color.SkyBlue;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(gbxParametri);
            Controls.Add(btnDodaj);
            ForeColor = System.Drawing.Color.Black;
            Name = "DodajVozilo";
            Text = "DodajVozilo";
            gbxParametri.ResumeLayout(false);
            gbxParametri.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtRegOznaka;
        private Label lblReg;
        private Label label2;
        private TextBox txtBoja;
        private Label label3;
        private TextBox txtTip;
        private Label label4;
        private TextBox txtProizvodjac;
        private Label label5;
        private TextBox txtModel;
        private Button btnDodaj;
        private GroupBox gbxParametri;
    }
}