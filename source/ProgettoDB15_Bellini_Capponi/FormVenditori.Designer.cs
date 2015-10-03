namespace ProgettoDB15_Bellini_Capponi
{
    partial class FormVenditori
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
            this.backButton = new System.Windows.Forms.Button();
            this.gridV3 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.eseguiButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonAcquisto = new System.Windows.Forms.RadioButton();
            this.radioButtonVendita = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxCODfiscale = new System.Windows.Forms.ComboBox();
            this.comboBoxIDFornitore = new System.Windows.Forms.ComboBox();
            this.comboBoxIDCliente = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonInserisci = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBoxCODvenditore = new System.Windows.Forms.ComboBox();
            this.dataGridV4 = new System.Windows.Forms.DataGridView();
            this.buttonAggiorna = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.gridV3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridV4)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(637, 397);
            this.backButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(91, 28);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Indietro";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // gridV3
            // 
            this.gridV3.AllowUserToAddRows = false;
            this.gridV3.AllowUserToDeleteRows = false;
            this.gridV3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridV3.Location = new System.Drawing.Point(7, 66);
            this.gridV3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridV3.Name = "gridV3";
            this.gridV3.RowTemplate.Height = 24;
            this.gridV3.Size = new System.Drawing.Size(487, 286);
            this.gridV3.TabIndex = 1;
            this.gridV3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridV3_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Codice fiscale venditore: ";
            // 
            // eseguiButton
            // 
            this.eseguiButton.Location = new System.Drawing.Point(349, 16);
            this.eseguiButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.eseguiButton.Name = "eseguiButton";
            this.eseguiButton.Size = new System.Drawing.Size(56, 27);
            this.eseguiButton.TabIndex = 5;
            this.eseguiButton.Text = "Esegui";
            this.eseguiButton.UseVisualStyleBackColor = true;
            this.eseguiButton.Click += new System.EventHandler(this.eseguiButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Lista completa degli ordini eseguiti dal venditore corrente";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonAcquisto);
            this.groupBox1.Controls.Add(this.radioButtonVendita);
            this.groupBox1.Location = new System.Drawing.Point(4, 17);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(74, 67);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo";
            // 
            // radioButtonAcquisto
            // 
            this.radioButtonAcquisto.AutoSize = true;
            this.radioButtonAcquisto.Location = new System.Drawing.Point(4, 39);
            this.radioButtonAcquisto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonAcquisto.Name = "radioButtonAcquisto";
            this.radioButtonAcquisto.Size = new System.Drawing.Size(66, 17);
            this.radioButtonAcquisto.TabIndex = 1;
            this.radioButtonAcquisto.TabStop = true;
            this.radioButtonAcquisto.Text = "Acquisto";
            this.radioButtonAcquisto.UseVisualStyleBackColor = true;
            // 
            // radioButtonVendita
            // 
            this.radioButtonVendita.AutoSize = true;
            this.radioButtonVendita.Location = new System.Drawing.Point(4, 17);
            this.radioButtonVendita.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonVendita.Name = "radioButtonVendita";
            this.radioButtonVendita.Size = new System.Drawing.Size(61, 17);
            this.radioButtonVendita.TabIndex = 0;
            this.radioButtonVendita.TabStop = true;
            this.radioButtonVendita.Text = "Vendita";
            this.radioButtonVendita.UseVisualStyleBackColor = true;
            this.radioButtonVendita.CheckedChanged += new System.EventHandler(this.radioButtonVendita_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBoxCODfiscale);
            this.panel1.Controls.Add(this.comboBoxIDFornitore);
            this.panel1.Controls.Add(this.comboBoxIDCliente);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(8, 93);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(176, 84);
            this.panel1.TabIndex = 12;
            // 
            // comboBoxCODfiscale
            // 
            this.comboBoxCODfiscale.FormattingEnabled = true;
            this.comboBoxCODfiscale.Location = new System.Drawing.Point(81, 5);
            this.comboBoxCODfiscale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxCODfiscale.Name = "comboBoxCODfiscale";
            this.comboBoxCODfiscale.Size = new System.Drawing.Size(92, 21);
            this.comboBoxCODfiscale.TabIndex = 21;
            // 
            // comboBoxIDFornitore
            // 
            this.comboBoxIDFornitore.FormattingEnabled = true;
            this.comboBoxIDFornitore.Location = new System.Drawing.Point(81, 56);
            this.comboBoxIDFornitore.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxIDFornitore.Name = "comboBoxIDFornitore";
            this.comboBoxIDFornitore.Size = new System.Drawing.Size(92, 21);
            this.comboBoxIDFornitore.TabIndex = 20;
            // 
            // comboBoxIDCliente
            // 
            this.comboBoxIDCliente.FormattingEnabled = true;
            this.comboBoxIDCliente.Location = new System.Drawing.Point(81, 29);
            this.comboBoxIDCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxIDCliente.Name = "comboBoxIDCliente";
            this.comboBoxIDCliente.Size = new System.Drawing.Size(92, 21);
            this.comboBoxIDCliente.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 58);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Fornitore";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 32);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Cliente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 7);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "cod. fiscale";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonInserisci);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Location = new System.Drawing.Point(516, 11);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(190, 217);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Inserimento nuovo ordine";
            // 
            // buttonInserisci
            // 
            this.buttonInserisci.Location = new System.Drawing.Point(4, 180);
            this.buttonInserisci.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonInserisci.Name = "buttonInserisci";
            this.buttonInserisci.Size = new System.Drawing.Size(56, 27);
            this.buttonInserisci.TabIndex = 13;
            this.buttonInserisci.Text = "Inserisci";
            this.buttonInserisci.UseVisualStyleBackColor = true;
            this.buttonInserisci.Click += new System.EventHandler(this.buttonInserisci_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBoxCODvenditore);
            this.groupBox3.Controls.Add(this.gridV3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.eseguiButton);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(4, 4);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(498, 355);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Visualizzazione ordini Venditore";
            // 
            // comboBoxCODvenditore
            // 
            this.comboBoxCODvenditore.FormattingEnabled = true;
            this.comboBoxCODvenditore.Location = new System.Drawing.Point(149, 20);
            this.comboBoxCODvenditore.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxCODvenditore.Name = "comboBoxCODvenditore";
            this.comboBoxCODvenditore.Size = new System.Drawing.Size(130, 21);
            this.comboBoxCODvenditore.TabIndex = 7;
            // 
            // dataGridV4
            // 
            this.dataGridV4.AllowUserToAddRows = false;
            this.dataGridV4.AllowUserToDeleteRows = false;
            this.dataGridV4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridV4.Location = new System.Drawing.Point(4, 42);
            this.dataGridV4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridV4.Name = "dataGridV4";
            this.dataGridV4.RowTemplate.Height = 24;
            this.dataGridV4.Size = new System.Drawing.Size(700, 300);
            this.dataGridV4.TabIndex = 15;
            // 
            // buttonAggiorna
            // 
            this.buttonAggiorna.Location = new System.Drawing.Point(648, 11);
            this.buttonAggiorna.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAggiorna.Name = "buttonAggiorna";
            this.buttonAggiorna.Size = new System.Drawing.Size(56, 27);
            this.buttonAggiorna.TabIndex = 16;
            this.buttonAggiorna.Text = "Aggiorna";
            this.buttonAggiorna.UseVisualStyleBackColor = true;
            this.buttonAggiorna.Click += new System.EventHandler(this.buttonAggiorna_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.dataGridV4);
            this.groupBox4.Controls.Add(this.buttonAggiorna);
            this.groupBox4.Location = new System.Drawing.Point(4, 4);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Size = new System.Drawing.Size(708, 355);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ordini totali";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Tutti gli ordini eseguiti dall\'azienda nell\'ultimo mese:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(9, 10);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(723, 387);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(715, 361);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Gestione Ordini";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(715, 361);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Visualizzazione ordini";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // FormVenditori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 431);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.backButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormVenditori";
            this.Text = "Progetto DB 2015 Bellini/Capponi - Venditori";
            this.Load += new System.EventHandler(this.FormVenditori_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridV3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridV4)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DataGridView gridV3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button eseguiButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonAcquisto;
        private System.Windows.Forms.RadioButton radioButtonVendita;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonInserisci;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridV4;
        private System.Windows.Forms.Button buttonAggiorna;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxCODfiscale;
        private System.Windows.Forms.ComboBox comboBoxIDFornitore;
        private System.Windows.Forms.ComboBox comboBoxIDCliente;
        private System.Windows.Forms.ComboBox comboBoxCODvenditore;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;

    }
}