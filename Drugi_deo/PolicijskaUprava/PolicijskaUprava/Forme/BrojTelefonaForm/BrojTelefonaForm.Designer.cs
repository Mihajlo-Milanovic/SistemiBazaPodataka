namespace PolicijskaUprava.Forme.BrojTelefonaForm
{
    partial class BrojTelefonaForm
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
            components = new System.ComponentModel.Container();
            dgvBrojevi = new DataGridView();
            bindingSource1 = new BindingSource(components);
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvBrojevi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // dgvBrojevi
            // 
            dgvBrojevi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBrojevi.Location = new System.Drawing.Point(33, 29);
            dgvBrojevi.Name = "dgvBrojevi";
            dgvBrojevi.RowHeadersWidth = 51;
            dgvBrojevi.Size = new System.Drawing.Size(723, 188);
            dgvBrojevi.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(321, 254);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(147, 20);
            label1.TabIndex = 1;
            label1.Text = "NIJE ZAVRSENO !!!!!!!";
            // 
            // BrojTelefonaForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(label1);
            Controls.Add(dgvBrojevi);
            Name = "BrojTelefonaForm";
            Text = "BrojTelefonaForm";
            Load += BrojTelefonaForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBrojevi).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvBrojevi;
        private BindingSource bindingSource1;
        private Label label1;
    }
}