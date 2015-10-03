using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProgettoDB15_Bellini_Capponi
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // bottone per avviare la schermata venditori
        private void buttonVenditori_Click(object sender, EventArgs e)
        {
            FormVenditori formVenditori = new FormVenditori(this);
            formVenditori.Activate();
            formVenditori.Show();
            this.Visible = false;

        }

        // bottone per avviare la schermata rappresentanti
        private void buttonRappresentanti_Click(object sender, EventArgs e)
        {
            FormRappresentanti formRappresentanti = new FormRappresentanti(this);
            formRappresentanti.Activate();
            formRappresentanti.Show();
            this.Visible = false;
        }

        // bottone per avviare la schermata magazzinieri
        private void buttonMagazzinieri_Click(object sender, EventArgs e)
        {
            FormMagazzinieri formMagazzinieri = new FormMagazzinieri(this);
            formMagazzinieri.Activate();
            formMagazzinieri.Show();
            this.Visible = false;
        }

        // bottone per avviare la schermata dirigente
        private void buttonDirigente_Click(object sender, EventArgs e)
        {
            FormDirigente formDirigente = new FormDirigente(this);
            formDirigente.Activate();
            formDirigente.Show();
            this.Visible = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }
    }
}
