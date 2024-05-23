namespace PolicijskaUprava.Forme.UnapredjenjeForme
{
    partial class DodajUnapredjenjeForm
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
            txtCin = new TextBox();
            label1 = new Label();
            label2 = new Label();
            dtpSticanje = new DateTimePicker();
            groupBox1 = new GroupBox();
            btnDodaj = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtCin
            // 
            txtCin.Location = new System.Drawing.Point(139, 52);
            txtCin.Margin = new Padding(3, 4, 3, 4);
            txtCin.Name = "txtCin";
            txtCin.Size = new System.Drawing.Size(154, 27);
            txtCin.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(20, 60);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(39, 19);
            label1.TabIndex = 3;
            label1.Text = "Cin:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(20, 110);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(121, 19);
            label2.TabIndex = 4;
            label2.Text = "Datum sticanja:";
            // 
            // dtpSticanje
            // 
            dtpSticanje.Format = DateTimePickerFormat.Short;
            dtpSticanje.Location = new System.Drawing.Point(139, 104);
            dtpSticanje.Name = "dtpSticanje";
            dtpSticanje.ShowUpDown = true;
            dtpSticanje.Size = new System.Drawing.Size(154, 27);
            dtpSticanje.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtCin);
            groupBox1.Controls.Add(dtpSticanje);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new System.Drawing.Point(31, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(316, 175);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Podaci o unapredjenju";
            // 
            // btnDodaj
            // 
            btnDodaj.BackColor = System.Drawing.Color.Aqua;
            btnDodaj.FlatStyle = FlatStyle.Flat;
            btnDodaj.Location = new System.Drawing.Point(31, 218);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new System.Drawing.Size(316, 62);
            btnDodaj.TabIndex = 7;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = false;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // DodajUnapredjenjeForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.Color.DeepSkyBlue;
            ClientSize = new System.Drawing.Size(377, 315);
            Controls.Add(btnDodaj);
            Controls.Add(groupBox1);
            Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Name = "DodajUnapredjenjeForm";
            Text = "DodajUnapredjenjeForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtCin;
        private Label label1;
        private Label label2;
        private DateTimePicker dtpSticanje;
        private GroupBox groupBox1;
        private Button btnDodaj;
    }
}