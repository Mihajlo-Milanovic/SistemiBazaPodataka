namespace PolicijskaUprava
{
    partial class Form1
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
            this.btnUcitavanjePolicajca = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUcitavanjePolicajca
            // 
            this.btnUcitavanjePolicajca.Location = new System.Drawing.Point(13, 13);
            this.btnUcitavanjePolicajca.Name = "btnUcitavanjePolicajca";
            this.btnUcitavanjePolicajca.Size = new System.Drawing.Size(132, 23);
            this.btnUcitavanjePolicajca.TabIndex = 0;
            this.btnUcitavanjePolicajca.Text = "Ucitavanje policajca";
            this.btnUcitavanjePolicajca.UseVisualStyleBackColor = true;
            this.btnUcitavanjePolicajca.Click += new System.EventHandler(this.btnUcitavanjePolicajca_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUcitavanjePolicajca);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUcitavanjePolicajca;
    }
}

