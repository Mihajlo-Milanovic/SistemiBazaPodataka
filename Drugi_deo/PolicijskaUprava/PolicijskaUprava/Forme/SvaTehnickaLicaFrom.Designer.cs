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
            this.lvLista.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lvLista.Location = new System.Drawing.Point(12, 12);
            this.lvLista.MultiSelect = false;
            this.lvLista.Name = "lvLista";
            this.lvLista.Size = new System.Drawing.Size(63, 165);
            this.lvLista.TabIndex = 1;
            this.lvLista.UseCompatibleStateImageBehavior = false;
            this.lvLista.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // SvaTehnickaLicaFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 450);
            this.Controls.Add(this.lvLista);
            this.Name = "SvaTehnickaLicaFrom";
            this.Text = "SvaTehnickaLicaFrom";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvLista;
        private System.Windows.Forms.ColumnHeader ID;
    }
}