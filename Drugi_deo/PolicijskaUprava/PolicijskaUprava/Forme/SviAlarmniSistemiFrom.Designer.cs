namespace PolicijskaUprava.Forme
{
    partial class SviAlarmniSistemiFrom
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
            oracleDataAdapter1 = new Oracle.ManagedDataAccess.Client.OracleDataAdapter();
            lvLista = new ListView();
            ID = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            columnHeader13 = new ColumnHeader();
            columnHeader14 = new ColumnHeader();
            columnHeader15 = new ColumnHeader();
            label1 = new Label();
            btnObrisiAlarmniSistem = new Button();
            SuspendLayout();
            // 
            // lvLista
            // 
            lvLista.Columns.AddRange(new ColumnHeader[] { ID, columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8, columnHeader9, columnHeader10, columnHeader11, columnHeader12, columnHeader13, columnHeader14, columnHeader15 });
            lvLista.ForeColor = System.Drawing.SystemColors.MenuText;
            lvLista.FullRowSelect = true;
            lvLista.GridLines = true;
            lvLista.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lvLista.ImeMode = ImeMode.NoControl;
            lvLista.Location = new System.Drawing.Point(14, 14);
            lvLista.Margin = new Padding(4, 3, 4, 3);
            lvLista.MultiSelect = false;
            lvLista.Name = "lvLista";
            lvLista.Size = new System.Drawing.Size(564, 409);
            lvLista.TabIndex = 0;
            lvLista.UseCompatibleStateImageBehavior = false;
            lvLista.View = View.Details;
            // 
            // ID
            // 
            ID.Text = "ID";
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Serijski broj";
            columnHeader1.Width = 75;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Proizvodjac";
            columnHeader2.Width = 75;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Model";
            columnHeader3.Width = 75;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Godina proizvodnje";
            columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Objekat";
            columnHeader5.Width = 75;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Datum instalacije";
            columnHeader6.Width = 120;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Datum poslednjeg atesta";
            columnHeader7.Width = 140;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Datum poslednjeg servisiranja";
            columnHeader8.Width = 155;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Opis otklonjenog kvara";
            columnHeader9.Width = 140;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Tip";
            columnHeader10.Width = 75;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Horizontalna razolucija kamere";
            columnHeader11.Width = 150;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "Vertikalna rezolucija kamere";
            columnHeader12.Width = 150;
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "Osetljivost";
            columnHeader13.Width = 75;
            // 
            // columnHeader14
            // 
            columnHeader14.Text = "Gornja granica";
            columnHeader14.Width = 120;
            // 
            // columnHeader15
            // 
            columnHeader15.Text = "Dornja granica";
            columnHeader15.Width = 120;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
            label1.Location = new System.Drawing.Point(586, 14);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(138, 95);
            label1.TabIndex = 3;
            label1.Text = "U tabeli su prikazani\r\n svi alarmni sistemi.\r\nBrisanjem alarmnog\r\nsistema iz ove tabele bice \r\ntrajno izbrisan iz sistema.";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnObrisiAlarmniSistem
            // 
            btnObrisiAlarmniSistem.BackColor = System.Drawing.Color.DeepSkyBlue;
            btnObrisiAlarmniSistem.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            btnObrisiAlarmniSistem.FlatAppearance.BorderSize = 3;
            btnObrisiAlarmniSistem.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(0, 0, 64);
            btnObrisiAlarmniSistem.FlatStyle = FlatStyle.Flat;
            btnObrisiAlarmniSistem.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 238);
            btnObrisiAlarmniSistem.Location = new System.Drawing.Point(589, 137);
            btnObrisiAlarmniSistem.Margin = new Padding(4, 3, 4, 3);
            btnObrisiAlarmniSistem.Name = "btnObrisiAlarmniSistem";
            btnObrisiAlarmniSistem.Size = new System.Drawing.Size(187, 57);
            btnObrisiAlarmniSistem.TabIndex = 4;
            btnObrisiAlarmniSistem.Text = "Obrisi alarmni sistem";
            btnObrisiAlarmniSistem.UseVisualStyleBackColor = false;
            btnObrisiAlarmniSistem.Click += btnObrisiAlarmniSistem_Click;
            // 
            // SviAlarmniSistemiFrom
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = System.Drawing.Color.SkyBlue;
            ClientSize = new System.Drawing.Size(790, 437);
            Controls.Add(btnObrisiAlarmniSistem);
            Controls.Add(label1);
            Controls.Add(lvLista);
            Margin = new Padding(4, 3, 4, 3);
            Name = "SviAlarmniSistemiFrom";
            Text = "Alarmni sistem";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Oracle.ManagedDataAccess.Client.OracleDataAdapter oracleDataAdapter1;
        private System.Windows.Forms.ListView lvLista;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnObrisiAlarmniSistem;
    }
}