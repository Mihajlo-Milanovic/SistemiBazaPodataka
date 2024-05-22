namespace PolicijskaUprava.Forme.BrojTelefonaForm
{
    partial class DodajBrojTelefonaForm
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
            txtBroj = new TextBox();
            label1 = new Label();
            btnDodaj = new Button();
            SuspendLayout();
            // 
            // txtBroj
            // 
            txtBroj.Location = new System.Drawing.Point(14, 86);
            txtBroj.Name = "txtBroj";
            txtBroj.Size = new System.Drawing.Size(236, 27);
            txtBroj.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(14, 55);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(87, 19);
            label1.TabIndex = 1;
            label1.Text = "Unesi broj:";
            // 
            // btnDodaj
            // 
            btnDodaj.BackColor = System.Drawing.Color.Aqua;
            btnDodaj.Location = new System.Drawing.Point(66, 134);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new System.Drawing.Size(119, 38);
            btnDodaj.TabIndex = 2;
            btnDodaj.Text = "Dodaj broj";
            btnDodaj.UseVisualStyleBackColor = false;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // DodajBrojTelefonaForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.Color.DeepSkyBlue;
            ClientSize = new System.Drawing.Size(271, 225);
            Controls.Add(btnDodaj);
            Controls.Add(label1);
            Controls.Add(txtBroj);
            Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Name = "DodajBrojTelefonaForm";
            Text = "DodajBrojTelefonaForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBroj;
        private Label label1;
        private Button btnDodaj;
    }
}