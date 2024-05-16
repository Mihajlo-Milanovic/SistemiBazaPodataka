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
            btnUcitavanjePolicajca = new Button();
            btnUcitajVozilo = new Button();
            btnUcitavanjeTehnickogLica = new Button();
            btnUcitajStanicu = new Button();
            btnUcitajPZaVanredneSituacije = new Button();
            btnUcitaj_Skolskog_policajca = new Button();
            SuspendLayout();
            // 
            // btnUcitavanjePolicajca
            // 
            btnUcitavanjePolicajca.Location = new System.Drawing.Point(15, 15);
            btnUcitavanjePolicajca.Margin = new Padding(4, 3, 4, 3);
            btnUcitavanjePolicajca.Name = "btnUcitavanjePolicajca";
            btnUcitavanjePolicajca.Size = new System.Drawing.Size(154, 27);
            btnUcitavanjePolicajca.TabIndex = 0;
            btnUcitavanjePolicajca.Text = "Ucitavanje policajca";
            btnUcitavanjePolicajca.UseVisualStyleBackColor = true;
            btnUcitavanjePolicajca.Click += btnUcitavanjePolicajca_Click;
            // 
            // btnUcitajVozilo
            // 
            btnUcitajVozilo.Location = new System.Drawing.Point(15, 50);
            btnUcitajVozilo.Margin = new Padding(4, 3, 4, 3);
            btnUcitajVozilo.Name = "btnUcitajVozilo";
            btnUcitajVozilo.Size = new System.Drawing.Size(154, 27);
            btnUcitajVozilo.TabIndex = 1;
            btnUcitajVozilo.Text = "Ucitavanje vozila";
            btnUcitajVozilo.UseVisualStyleBackColor = true;
            btnUcitajVozilo.Click += btnUcitajVozilo_Click;
            // 
            // btnUcitavanjeTehnickogLica
            // 
            btnUcitavanjeTehnickogLica.Location = new System.Drawing.Point(15, 83);
            btnUcitavanjeTehnickogLica.Margin = new Padding(4, 3, 4, 3);
            btnUcitavanjeTehnickogLica.Name = "btnUcitavanjeTehnickogLica";
            btnUcitavanjeTehnickogLica.Size = new System.Drawing.Size(154, 27);
            btnUcitavanjeTehnickogLica.TabIndex = 2;
            btnUcitavanjeTehnickogLica.Text = "Ucitaj Tehnicko Lice";
            btnUcitavanjeTehnickogLica.UseVisualStyleBackColor = true;
            btnUcitavanjeTehnickogLica.Click += btnUcitavanjeTehnickogLica_Click;
            // 
            // btnUcitajStanicu
            // 
            btnUcitajStanicu.Location = new System.Drawing.Point(14, 117);
            btnUcitajStanicu.Margin = new Padding(4, 3, 4, 3);
            btnUcitajStanicu.Name = "btnUcitajStanicu";
            btnUcitajStanicu.Size = new System.Drawing.Size(154, 27);
            btnUcitajStanicu.TabIndex = 3;
            btnUcitajStanicu.Text = "Ucitaj staniocu";
            btnUcitajStanicu.UseVisualStyleBackColor = true;
            btnUcitajStanicu.Click += btnUcitajStanicu_Click;
            // 
            // btnUcitajPZaVanredneSituacije
            // 
            btnUcitajPZaVanredneSituacije.Location = new System.Drawing.Point(14, 151);
            btnUcitajPZaVanredneSituacije.Margin = new Padding(4, 3, 4, 3);
            btnUcitajPZaVanredneSituacije.Name = "btnUcitajPZaVanredneSituacije";
            btnUcitajPZaVanredneSituacije.Size = new System.Drawing.Size(236, 27);
            btnUcitajPZaVanredneSituacije.TabIndex = 4;
            btnUcitajPZaVanredneSituacije.Text = "Ucitaj policajca za vanredne situacije";
            btnUcitajPZaVanredneSituacije.UseVisualStyleBackColor = true;
            btnUcitajPZaVanredneSituacije.Click += btnUcitajPZaVanredneSituacije_Click;
            // 
            // btnUcitaj_Skolskog_policajca
            // 
            btnUcitaj_Skolskog_policajca.Location = new System.Drawing.Point(15, 184);
            btnUcitaj_Skolskog_policajca.Name = "btnUcitaj_Skolskog_policajca";
            btnUcitaj_Skolskog_policajca.Size = new System.Drawing.Size(235, 23);
            btnUcitaj_Skolskog_policajca.TabIndex = 5;
            btnUcitaj_Skolskog_policajca.Text = "Ucitaj skolskog policajca";
            btnUcitaj_Skolskog_policajca.UseVisualStyleBackColor = true;
            btnUcitaj_Skolskog_policajca.Click += btnUcitaj_Skolskog_policajca_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(933, 519);
            Controls.Add(btnUcitaj_Skolskog_policajca);
            Controls.Add(btnUcitajPZaVanredneSituacije);
            Controls.Add(btnUcitajStanicu);
            Controls.Add(btnUcitavanjeTehnickogLica);
            Controls.Add(btnUcitajVozilo);
            Controls.Add(btnUcitavanjePolicajca);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnUcitavanjePolicajca;
        private System.Windows.Forms.Button btnUcitajVozilo;
        private System.Windows.Forms.Button btnUcitavanjeTehnickogLica;
        private System.Windows.Forms.Button btnUcitajStanicu;
        private System.Windows.Forms.Button btnUcitajPZaVanredneSituacije;
        private Button btnUcitaj_Skolskog_policajca;
    }
}

