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
            this.oracleDataAdapter1 = new Oracle.ManagedDataAccess.Client.OracleDataAdapter();
            this.lvLista = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GodinaProizvodnje = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvLista
            // 
            this.lvLista.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.GodinaProizvodnje});
            this.lvLista.FullRowSelect = true;
            this.lvLista.GridLines = true;
            this.lvLista.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvLista.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lvLista.Location = new System.Drawing.Point(13, 13);
            this.lvLista.MultiSelect = false;
            this.lvLista.Name = "lvLista";
            this.lvLista.Size = new System.Drawing.Size(301, 145);
            this.lvLista.TabIndex = 0;
            this.lvLista.UseCompatibleStateImageBehavior = false;
            this.lvLista.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // GodinaProizvodnje
            // 
            this.GodinaProizvodnje.Text = "Godina proizvonje";
            this.GodinaProizvodnje.Width = 100;
            // 
            // SviAlarmniSistemiFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvLista);
            this.Name = "SviAlarmniSistemiFrom";
            this.Text = "SviAlarmniSistemiFrom";
            this.ResumeLayout(false);

        }

        #endregion
        private Oracle.ManagedDataAccess.Client.OracleDataAdapter oracleDataAdapter1;
        private System.Windows.Forms.ListView lvLista;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader GodinaProizvodnje;
    }
}