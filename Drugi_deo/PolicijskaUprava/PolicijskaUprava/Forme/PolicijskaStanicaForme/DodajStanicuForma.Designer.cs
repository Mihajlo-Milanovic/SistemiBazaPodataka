namespace PolicijskaUprava.Forme.PolicijskaStanicaForme
{
    partial class DodajStanicuForma
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
            groupBox1 = new GroupBox();
            Naziv = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Naziv);
            groupBox1.Location = new System.Drawing.Point(27, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(510, 232);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Osnovni podaci o stanici";
            // 
            // Naziv
            // 
            Naziv.AutoSize = true;
            Naziv.Location = new System.Drawing.Point(42, 39);
            Naziv.Name = "Naziv";
            Naziv.Size = new System.Drawing.Size(39, 15);
            Naziv.TabIndex = 0;
            Naziv.Text = "Naziv:";
            // 
            // DodajStanicuForma
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(770, 394);
            Controls.Add(groupBox1);
            Name = "DodajStanicuForma";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label Naziv;
    }
}