namespace ProgettoDB15_Bellini_Capponi
{
    partial class FormMagazzinieri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMagazzinieri));
            this.backButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Inventario = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDownInvAnno = new System.Windows.Forms.NumericUpDown();
            this.comboBoxInvMagazzino2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.numericUpDownInvQuantità = new System.Windows.Forms.NumericUpDown();
            this.comboBoxInvProdottoID = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonInseriesciDettaglio = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBoxInvAnno = new System.Windows.Forms.ComboBox();
            this.comboBoxInvMagazzino = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewInvM3 = new System.Windows.Forms.DataGridView();
            this.Magazzino = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxIndirizzo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.buttonInserisci = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridM1 = new System.Windows.Forms.DataGridView();
            this.Assenze = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dataGridViewAssenze = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.Inventario.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInvAnno)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInvQuantità)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvM3)).BeginInit();
            this.Magazzino.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridM1)).BeginInit();
            this.Assenze.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAssenze)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(728, 540);
            this.backButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(100, 28);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Inventario);
            this.tabControl1.Controls.Add(this.Magazzino);
            this.tabControl1.Controls.Add(this.Assenze);
            this.tabControl1.Location = new System.Drawing.Point(16, 28);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(812, 511);
            this.tabControl1.TabIndex = 2;
            // 
            // Inventario
            // 
            this.Inventario.Controls.Add(this.groupBox5);
            this.Inventario.Controls.Add(this.groupBox4);
            this.Inventario.Controls.Add(this.groupBox3);
            this.Inventario.Controls.Add(this.dataGridViewInvM3);
            this.Inventario.Location = new System.Drawing.Point(4, 25);
            this.Inventario.Margin = new System.Windows.Forms.Padding(4);
            this.Inventario.Name = "Inventario";
            this.Inventario.Padding = new System.Windows.Forms.Padding(4);
            this.Inventario.Size = new System.Drawing.Size(804, 482);
            this.Inventario.TabIndex = 1;
            this.Inventario.Text = "Inventario";
            this.Inventario.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.numericUpDownInvAnno);
            this.groupBox5.Controls.Add(this.comboBoxInvMagazzino2);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Location = new System.Drawing.Point(28, 7);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(769, 69);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Crea Inventario";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(591, 25);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "Crea";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDownInvAnno
            // 
            this.numericUpDownInvAnno.Location = new System.Drawing.Point(363, 25);
            this.numericUpDownInvAnno.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownInvAnno.Maximum = new decimal(new int[] {
            2030,
            0,
            0,
            0});
            this.numericUpDownInvAnno.Minimum = new decimal(new int[] {
            1990,
            0,
            0,
            0});
            this.numericUpDownInvAnno.Name = "numericUpDownInvAnno";
            this.numericUpDownInvAnno.Size = new System.Drawing.Size(160, 22);
            this.numericUpDownInvAnno.TabIndex = 3;
            this.numericUpDownInvAnno.Value = new decimal(new int[] {
            2015,
            0,
            0,
            0});
            // 
            // comboBoxInvMagazzino2
            // 
            this.comboBoxInvMagazzino2.FormattingEnabled = true;
            this.comboBoxInvMagazzino2.Location = new System.Drawing.Point(91, 25);
            this.comboBoxInvMagazzino2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxInvMagazzino2.Name = "comboBoxInvMagazzino2";
            this.comboBoxInvMagazzino2.Size = new System.Drawing.Size(160, 24);
            this.comboBoxInvMagazzino2.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(312, 28);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Anno";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 28);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Magazzino";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.numericUpDownInvQuantità);
            this.groupBox4.Controls.Add(this.comboBoxInvProdottoID);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.buttonInseriesciDettaglio);
            this.groupBox4.Location = new System.Drawing.Point(515, 177);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(279, 290);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Inserimento nuovo ordine";
            // 
            // numericUpDownInvQuantità
            // 
            this.numericUpDownInvQuantità.Location = new System.Drawing.Point(104, 62);
            this.numericUpDownInvQuantità.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownInvQuantità.Name = "numericUpDownInvQuantità";
            this.numericUpDownInvQuantità.Size = new System.Drawing.Size(168, 22);
            this.numericUpDownInvQuantità.TabIndex = 22;
            // 
            // comboBoxInvProdottoID
            // 
            this.comboBoxInvProdottoID.FormattingEnabled = true;
            this.comboBoxInvProdottoID.Location = new System.Drawing.Point(104, 28);
            this.comboBoxInvProdottoID.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxInvProdottoID.Name = "comboBoxInvProdottoID";
            this.comboBoxInvProdottoID.Size = new System.Drawing.Size(167, 24);
            this.comboBoxInvProdottoID.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Quantità";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "IDprodotto";
            // 
            // buttonInseriesciDettaglio
            // 
            this.buttonInseriesciDettaglio.Location = new System.Drawing.Point(197, 92);
            this.buttonInseriesciDettaglio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonInseriesciDettaglio.Name = "buttonInseriesciDettaglio";
            this.buttonInseriesciDettaglio.Size = new System.Drawing.Size(75, 33);
            this.buttonInseriesciDettaglio.TabIndex = 13;
            this.buttonInseriesciDettaglio.Text = "Inserisci";
            this.buttonInseriesciDettaglio.UseVisualStyleBackColor = true;
            this.buttonInseriesciDettaglio.Click += new System.EventHandler(this.buttonInseriesciDettaglio_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBoxInvAnno);
            this.groupBox3.Controls.Add(this.comboBoxInvMagazzino);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(24, 105);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(769, 69);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Selezione Inventario";
            // 
            // comboBoxInvAnno
            // 
            this.comboBoxInvAnno.FormattingEnabled = true;
            this.comboBoxInvAnno.Location = new System.Drawing.Point(367, 23);
            this.comboBoxInvAnno.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxInvAnno.Name = "comboBoxInvAnno";
            this.comboBoxInvAnno.Size = new System.Drawing.Size(160, 24);
            this.comboBoxInvAnno.TabIndex = 3;
            this.comboBoxInvAnno.SelectedIndexChanged += new System.EventHandler(this.comboBoxInvAnno_SelectedIndexChanged);
            // 
            // comboBoxInvMagazzino
            // 
            this.comboBoxInvMagazzino.FormattingEnabled = true;
            this.comboBoxInvMagazzino.Location = new System.Drawing.Point(95, 23);
            this.comboBoxInvMagazzino.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxInvMagazzino.Name = "comboBoxInvMagazzino";
            this.comboBoxInvMagazzino.Size = new System.Drawing.Size(160, 24);
            this.comboBoxInvMagazzino.TabIndex = 2;
            this.comboBoxInvMagazzino.SelectedIndexChanged += new System.EventHandler(this.comboBoxInvMagazzino_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Anno";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Magazzino";
            // 
            // dataGridViewInvM3
            // 
            this.dataGridViewInvM3.AllowUserToAddRows = false;
            this.dataGridViewInvM3.AllowUserToDeleteRows = false;
            this.dataGridViewInvM3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInvM3.Location = new System.Drawing.Point(24, 177);
            this.dataGridViewInvM3.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewInvM3.Name = "dataGridViewInvM3";
            this.dataGridViewInvM3.Size = new System.Drawing.Size(484, 290);
            this.dataGridViewInvM3.TabIndex = 0;
            this.dataGridViewInvM3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewInvM3_CellContentClick);
            // 
            // Magazzino
            // 
            this.Magazzino.Controls.Add(this.groupBox2);
            this.Magazzino.Controls.Add(this.groupBox1);
            this.Magazzino.Location = new System.Drawing.Point(4, 25);
            this.Magazzino.Margin = new System.Windows.Forms.Padding(4);
            this.Magazzino.Name = "Magazzino";
            this.Magazzino.Padding = new System.Windows.Forms.Padding(4);
            this.Magazzino.Size = new System.Drawing.Size(804, 482);
            this.Magazzino.TabIndex = 0;
            this.Magazzino.Text = "Magazzino";
            this.Magazzino.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBoxIndirizzo);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBoxNome);
            this.groupBox2.Controls.Add(this.buttonInserisci);
            this.groupBox2.Location = new System.Drawing.Point(549, 20);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(245, 319);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Inserimento nuovo magazzino";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Indirizzo";
            // 
            // textBoxIndirizzo
            // 
            this.textBoxIndirizzo.Location = new System.Drawing.Point(99, 60);
            this.textBoxIndirizzo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxIndirizzo.Name = "textBoxIndirizzo";
            this.textBoxIndirizzo.Size = new System.Drawing.Size(140, 22);
            this.textBoxIndirizzo.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Nome";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(99, 31);
            this.textBoxNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(140, 22);
            this.textBoxNome.TabIndex = 17;
            // 
            // buttonInserisci
            // 
            this.buttonInserisci.Location = new System.Drawing.Point(165, 90);
            this.buttonInserisci.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonInserisci.Name = "buttonInserisci";
            this.buttonInserisci.Size = new System.Drawing.Size(75, 33);
            this.buttonInserisci.TabIndex = 13;
            this.buttonInserisci.Text = "Inserisci";
            this.buttonInserisci.UseVisualStyleBackColor = true;
            this.buttonInserisci.Click += new System.EventHandler(this.buttonInserisci_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridM1);
            this.groupBox1.Location = new System.Drawing.Point(8, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(535, 331);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Magazzini";
            // 
            // gridM1
            // 
            this.gridM1.AllowUserToAddRows = false;
            this.gridM1.AllowUserToDeleteRows = false;
            this.gridM1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridM1.Location = new System.Drawing.Point(8, 47);
            this.gridM1.Margin = new System.Windows.Forms.Padding(4);
            this.gridM1.Name = "gridM1";
            this.gridM1.Size = new System.Drawing.Size(519, 277);
            this.gridM1.TabIndex = 0;
            // 
            // Assenze
            // 
            this.Assenze.Controls.Add(this.label9);
            this.Assenze.Controls.Add(this.groupBox6);
            this.Assenze.Location = new System.Drawing.Point(4, 25);
            this.Assenze.Margin = new System.Windows.Forms.Padding(4);
            this.Assenze.Name = "Assenze";
            this.Assenze.Size = new System.Drawing.Size(804, 482);
            this.Assenze.TabIndex = 2;
            this.Assenze.Text = "Assenze";
            this.Assenze.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(435, 27);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.MaximumSize = new System.Drawing.Size(347, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(346, 68);
            this.label9.TabIndex = 1;
            this.label9.Text = resources.GetString("label9.Text");
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dataGridViewAssenze);
            this.groupBox6.Location = new System.Drawing.Point(4, 4);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(423, 448);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Scorte assenti in alcuni Magazzini";
            // 
            // dataGridViewAssenze
            // 
            this.dataGridViewAssenze.AllowUserToAddRows = false;
            this.dataGridViewAssenze.AllowUserToDeleteRows = false;
            this.dataGridViewAssenze.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAssenze.Location = new System.Drawing.Point(8, 23);
            this.dataGridViewAssenze.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewAssenze.Name = "dataGridViewAssenze";
            this.dataGridViewAssenze.Size = new System.Drawing.Size(407, 417);
            this.dataGridViewAssenze.TabIndex = 0;
            // 
            // FormMagazzinieri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 572);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.backButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMagazzinieri";
            this.Text = "Progetto DB 2015 Bellini/Capponi - Magazzinieri";
            this.Load += new System.EventHandler(this.FormMagazzinieri_Load);
            this.tabControl1.ResumeLayout(false);
            this.Inventario.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInvAnno)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInvQuantità)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvM3)).EndInit();
            this.Magazzino.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridM1)).EndInit();
            this.Assenze.ResumeLayout(false);
            this.Assenze.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAssenze)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Magazzino;
        private System.Windows.Forms.TabPage Inventario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gridM1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonInserisci;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxIndirizzo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.DataGridView dataGridViewInvM3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxInvAnno;
        private System.Windows.Forms.ComboBox comboBoxInvMagazzino;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonInseriesciDettaglio;
        private System.Windows.Forms.ComboBox comboBoxInvProdottoID;
        private System.Windows.Forms.NumericUpDown numericUpDownInvQuantità;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox comboBoxInvMagazzino2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDownInvAnno;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage Assenze;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dataGridViewAssenze;
        private System.Windows.Forms.Label label9;
    }
}