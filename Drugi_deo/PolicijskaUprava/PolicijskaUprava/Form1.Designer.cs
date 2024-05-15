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
            this.btnUcitajVozilo = new System.Windows.Forms.Button();
            this.btnUcitavanjeTehnickogLica = new System.Windows.Forms.Button();
            this.btnUcitajStanicu = new System.Windows.Forms.Button();
            this.btnUcitajPZaVanredneSituacije = new System.Windows.Forms.Button();
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
            // btnUcitajVozilo
            // 
            this.btnUcitajVozilo.Location = new System.Drawing.Point(13, 43);
            this.btnUcitajVozilo.Name = "btnUcitajVozilo";
            this.btnUcitajVozilo.Size = new System.Drawing.Size(132, 23);
            this.btnUcitajVozilo.TabIndex = 1;
            this.btnUcitajVozilo.Text = "Ucitavanje vozila";
            this.btnUcitajVozilo.UseVisualStyleBackColor = true;
            this.btnUcitajVozilo.Click += new System.EventHandler(this.btnUcitajVozilo_Click);
            // 
            // btnUcitavanjeTehnickogLica
            // 
            this.btnUcitavanjeTehnickogLica.Location = new System.Drawing.Point(13, 72);
            this.btnUcitavanjeTehnickogLica.Name = "btnUcitavanjeTehnickogLica";
            this.btnUcitavanjeTehnickogLica.Size = new System.Drawing.Size(132, 23);
            this.btnUcitavanjeTehnickogLica.TabIndex = 2;
            this.btnUcitavanjeTehnickogLica.Text = "Ucitaj Tehnicko Lice";
            this.btnUcitavanjeTehnickogLica.UseVisualStyleBackColor = true;
            this.btnUcitavanjeTehnickogLica.Click += new System.EventHandler(this.btnUcitavanjeTehnickogLica_Click);
            // 
            // btnUcitajStanicu
            // 
            this.btnUcitajStanicu.Location = new System.Drawing.Point(12, 101);
            this.btnUcitajStanicu.Name = "btnUcitajStanicu";
            this.btnUcitajStanicu.Size = new System.Drawing.Size(132, 23);
            this.btnUcitajStanicu.TabIndex = 3;
            this.btnUcitajStanicu.Text = "Ucitaj staniocu";
            this.btnUcitajStanicu.UseVisualStyleBackColor = true;
            this.btnUcitajStanicu.Click += new System.EventHandler(this.btnUcitajStanicu_Click);
            // 
            // btnUcitajPZaVanredneSituacije
            // 
            this.btnUcitajPZaVanredneSituacije.Location = new System.Drawing.Point(12, 131);
            this.btnUcitajPZaVanredneSituacije.Name = "btnUcitajPZaVanredneSituacije";
            this.btnUcitajPZaVanredneSituacije.Size = new System.Drawing.Size(202, 23);
            this.btnUcitajPZaVanredneSituacije.TabIndex = 4;
            this.btnUcitajPZaVanredneSituacije.Text = "Ucitaj policajca za vanredne situacije";
            this.btnUcitajPZaVanredneSituacije.UseVisualStyleBackColor = true;
            this.btnUcitajPZaVanredneSituacije.Click += new System.EventHandler(this.btnUcitajPZaVanredneSituacije_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUcitajPZaVanredneSituacije);
            this.Controls.Add(this.btnUcitajStanicu);
            this.Controls.Add(this.btnUcitavanjeTehnickogLica);
            this.Controls.Add(this.btnUcitajVozilo);
            this.Controls.Add(this.btnUcitavanjePolicajca);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUcitavanjePolicajca;
        private System.Windows.Forms.Button btnUcitajVozilo;
        private System.Windows.Forms.Button btnUcitavanjeTehnickogLica;
        private System.Windows.Forms.Button btnUcitajStanicu;
        private System.Windows.Forms.Button btnUcitajPZaVanredneSituacije;
    }
}

