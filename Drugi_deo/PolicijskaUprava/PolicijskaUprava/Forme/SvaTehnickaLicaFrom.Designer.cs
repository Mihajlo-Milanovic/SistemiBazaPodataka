namespace PolicijskaUprava.Forme
{
    partial class SvaTehnickaLicaFrom
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
            this.lvLista = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.btnObrisiTehnickaLica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvLista
            // 
            this.lvLista.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID});
            this.lvLista.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lvLista.FullRowSelect = true;
            this.lvLista.GridLines = true;
            this.lvLista.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvLista.HideSelection = false;
            this.lvLista.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lvLista.Location = new System.Drawing.Point(12, 12);
            this.lvLista.MultiSelect = false;
            this.lvLista.Name = "lvLista";
            this.lvLista.Size = new System.Drawing.Size(54, 165);
            this.lvLista.TabIndex = 1;
            this.lvLista.UseCompatibleStateImageBehavior = false;
            this.lvLista.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID lica";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(90, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 95);
            this.label1.TabIndex = 4;
            this.label1.Text = "U tabeli su prikazani\r\nsvi ID-jevi tehnickih lica.\r\nBrisanjem tehnickih lica\r\nsis" +
    "tema iz ove tabele bice \r\ntrajno izbrisan iz sistema.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnObrisiTehnickaLica
            // 
            this.btnObrisiTehnickaLica.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnObrisiTehnickaLica.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnObrisiTehnickaLica.FlatAppearance.BorderSize = 3;
            this.btnObrisiTehnickaLica.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnObrisiTehnickaLica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObrisiTehnickaLica.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnObrisiTehnickaLica.Location = new System.Drawing.Point(87, 119);
            this.btnObrisiTehnickaLica.Name = "btnObrisiTehnickaLica";
            this.btnObrisiTehnickaLica.Size = new System.Drawing.Size(160, 49);
            this.btnObrisiTehnickaLica.TabIndex = 5;
            this.btnObrisiTehnickaLica.Text = "Obrisi tehnicko lice";
            this.btnObrisiTehnickaLica.UseVisualStyleBackColor = false;
            this.btnObrisiTehnickaLica.Click += new System.EventHandler(this.btnObrisiTehnickaLica_Click);
            // 
            // SvaTehnickaLicaFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 195);
            this.Controls.Add(this.btnObrisiTehnickaLica);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvLista);
            this.Name = "SvaTehnickaLicaFrom";
            this.Text = "SvaTehnickaLicaFrom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvLista;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnObrisiTehnickaLica;
    }
}