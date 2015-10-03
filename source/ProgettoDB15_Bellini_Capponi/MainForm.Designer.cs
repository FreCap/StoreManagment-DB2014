namespace ProgettoDB15_Bellini_Capponi
{
    partial class MainForm
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Liberare le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonVenditori = new System.Windows.Forms.Button();
            this.buttonRappresentanti = new System.Windows.Forms.Button();
            this.buttonMagazzinieri = new System.Windows.Forms.Button();
            this.buttonDirigente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonVenditori
            // 
            this.buttonVenditori.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVenditori.Location = new System.Drawing.Point(119, 107);
            this.buttonVenditori.Name = "buttonVenditori";
            this.buttonVenditori.Size = new System.Drawing.Size(180, 60);
            this.buttonVenditori.TabIndex = 0;
            this.buttonVenditori.Text = "Venditori";
            this.buttonVenditori.UseVisualStyleBackColor = true;
            this.buttonVenditori.Click += new System.EventHandler(this.buttonVenditori_Click);
            // 
            // buttonRappresentanti
            // 
            this.buttonRappresentanti.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRappresentanti.Location = new System.Drawing.Point(318, 211);
            this.buttonRappresentanti.Name = "buttonRappresentanti";
            this.buttonRappresentanti.Size = new System.Drawing.Size(230, 60);
            this.buttonRappresentanti.TabIndex = 1;
            this.buttonRappresentanti.Text = "Rappresentanti";
            this.buttonRappresentanti.UseVisualStyleBackColor = true;
            this.buttonRappresentanti.Click += new System.EventHandler(this.buttonRappresentanti_Click);
            // 
            // buttonMagazzinieri
            // 
            this.buttonMagazzinieri.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMagazzinieri.Location = new System.Drawing.Point(593, 310);
            this.buttonMagazzinieri.Name = "buttonMagazzinieri";
            this.buttonMagazzinieri.Size = new System.Drawing.Size(205, 60);
            this.buttonMagazzinieri.TabIndex = 2;
            this.buttonMagazzinieri.Text = "Magazzinieri";
            this.buttonMagazzinieri.UseVisualStyleBackColor = true;
            this.buttonMagazzinieri.Click += new System.EventHandler(this.buttonMagazzinieri_Click);
            // 
            // buttonDirigente
            // 
            this.buttonDirigente.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDirigente.Location = new System.Drawing.Point(845, 406);
            this.buttonDirigente.Name = "buttonDirigente";
            this.buttonDirigente.Size = new System.Drawing.Size(180, 60);
            this.buttonDirigente.TabIndex = 3;
            this.buttonDirigente.Text = "Dirigente";
            this.buttonDirigente.UseVisualStyleBackColor = true;
            this.buttonDirigente.Click += new System.EventHandler(this.buttonDirigente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "Scegli la vista da visualizzare: ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 503);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDirigente);
            this.Controls.Add(this.buttonMagazzinieri);
            this.Controls.Add(this.buttonRappresentanti);
            this.Controls.Add(this.buttonVenditori);
            this.Name = "MainForm";
            this.Text = "Progetto DB 2015 Bellini/Capponi - Main";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonVenditori;
        private System.Windows.Forms.Button buttonRappresentanti;
        private System.Windows.Forms.Button buttonMagazzinieri;
        private System.Windows.Forms.Button buttonDirigente;
        private System.Windows.Forms.Label label1;
    }
}

