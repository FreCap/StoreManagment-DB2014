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
    public partial class FormVenditori : Form
    {
        private LinqToSQLClassDataContext db = new LinqToSQLClassDataContext();
        private MainForm mf;

        // costruttore della classe
        public FormVenditori(MainForm mf)
        {
            InitializeComponent();
            this.mf = mf;
            this.radioButtonVendita.Checked = true;
        }

        // Query V1 e V2 per l'inserimento di un ordine.
        private void queryV1V2()
        {
            ORDINE ordine = new ORDINE
            {
                data = System.DateTime.Now,
                DIPENDENTE = (DIPENDENTE)this.comboBoxCODfiscale.SelectedValue,
                prezzo = 0
            };
            if (this.radioButtonVendita.Checked == true)
            {
                // Query V1:  Aggiunta di un nuovo ordine di vendita.
                ordine.tipo = "vendita";
                ordine.CLIENTE = (CLIENTE)this.comboBoxIDCliente.SelectedValue;
            }
            else
            {
                // Query V2: Aggiunta di un nuovo ordine di acquisto.
                ordine.tipo = "acquisto";
                ordine.FORNITORE = (FORNITORE)this.comboBoxIDFornitore.SelectedValue;
            }

            // inserimento nel database
            db.ORDINE.InsertOnSubmit(ordine);
            try
            {
                db.SubmitChanges();
            }
            catch (System.Data.Linq.DuplicateKeyException e)
            {
                db.ORDINE.DeleteOnSubmit(ordine);
                db.SubmitChanges();
                MessageBox.Show("Hai già inserito questo ordine");
            }
            catch (Exception e)
            {
                db.ORDINE.DeleteOnSubmit(ordine);
                db.SubmitChanges();
                MessageBox.Show(e.GetType().ToString());
            }

            // avvio la form per l'inserimento dei dettagli d'ordine relativi a questo ordine
            DettaglioOrdine dettaglio = new DettaglioOrdine(ordine);
            dettaglio.Activate();
            dettaglio.Show();
        }

        // Query V3: Visualizzazione di tutti gli ordini fatti dal venditore stesso.
        private void queryV3()
        {
            db.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues, db.ORDINE);
            DIPENDENTE venditoreCorrente = (DIPENDENTE)this.comboBoxCODvenditore.SelectedValue;
            var query3 = from o in db.ORDINE
                         where o.DIPENDENTE == venditoreCorrente
                         select o;
            this.gridV3.DataSource = query3;
        }

        // Query V4: Visualizzazione di tutti gli ordini dell’azienda conseguiti nell’ultimo mese.
        private void queryV4()
        {
            var today = System.DateTime.Now;
            var lastMonth = System.DateTime.Today.AddMonths(-1).Date;

            var query4 = from o in db.ORDINE
                         where o.data <= today && o.data > lastMonth
                         orderby o.data descending
                         select new
                         {
                             IDordine = o.IDordine,
                             data = o.data,
                             tipo = o.tipo,
                             prezzo = o.prezzo,
                             venditore = o.CODfiscale,
                             fornitore = o.FORNITORE.nome + " " + o.FORNITORE.cognome,
                             cliente = o.CLIENTE.tipo == "azienda" ? o.CLIENTE.denominazionesociale
                                            : o.CLIENTE.nome + " " + o.CLIENTE.cognome
                         };
            this.dataGridV4.DataSource = query4;
        }

        // Button per l'aggiornamento delle query fatte sul DB.
        private void eseguiButton_Click(object sender, EventArgs e)
        {
            this.queryV3();
            this.gridV3.Columns.Remove(gridV3.Columns[gridV3.Columns.Count - 1]);
            this.gridV3.Columns.Remove(gridV3.Columns[gridV3.Columns.Count - 1]);
            this.gridV3.Columns.Remove(gridV3.Columns[gridV3.Columns.Count - 1]);
        }

        // Press del bottone Inserisci per inserire un nuovo Ordine nel DB.
        private void buttonInserisci_Click(object sender, EventArgs e)
        {
            this.queryV1V2();
        }

        // Press del bottone 'aggiorna' per eseguire la query V4.
        private void buttonAggiorna_Click(object sender, EventArgs e)
        {
            this.queryV4();
        }

        // Button indietro per tornare alla mainForm.
        private void backButton_Click(object sender, EventArgs e)
        {
            mf.Visible = true;
            this.Close();
        }

        // Disabilito text box di idcliente/fornitore per gli ordini di acquisto/vendita.
        private void radioButtonVendita_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonVendita.Checked == true)
            {
                this.comboBoxIDCliente.Enabled = true;
                this.comboBoxIDFornitore.Enabled = false;
            }
            else
            {
                this.comboBoxIDCliente.Enabled = false;
                this.comboBoxIDFornitore.Enabled = true;
            }
        }

        private void FormVenditori_Load(object sender, EventArgs e)
        {
            // inizializzo codice venditore combo box
            comboBoxCODvenditore.DisplayMember = "name";
            comboBoxCODvenditore.ValueMember = "value";
            comboBoxCODvenditore.DataSource = from d in db.DIPENDENTE
                                              where d.tipo == "venditore"
                                              select new
                                              {
                                                  value = d,
                                                  name = d.CODfiscale
                                              };

            // inizalizzo cod fiscale venditore combo box
            comboBoxCODfiscale.DisplayMember = "name";
            comboBoxCODfiscale.ValueMember = "value";
            comboBoxCODfiscale.DataSource = from d in db.DIPENDENTE
                                            where d.tipo == "venditore"
                                            select new
                                            {
                                                value = d,
                                                name = d.CODfiscale
                                            };

            // inizializzo combo box id cliente
            comboBoxIDCliente.DisplayMember = "name";
            comboBoxIDCliente.ValueMember = "value";
            comboBoxIDCliente.DataSource = from o in db.CLIENTE
                                           select new
                                           {
                                               value = o,
                                               name = o.tipo == "azienda" ? o.denominazionesociale : o.nome + " " + o.cognome
                                           };

            // inizializzo combo box id fornitore
            comboBoxIDFornitore.DisplayMember = "name";
            comboBoxIDFornitore.ValueMember = "value";
            comboBoxIDFornitore.DataSource = from d in db.FORNITORE
                                             select new
                                             {
                                                 value = d,
                                                 name = d.nome + " " + d.cognome
                                             };

            // esecuzione in fase di load di query V3 e V4
            queryV3();
            queryV4();
        }

        // Metodo per prevenire la chiusura accidentale della finestra con la 'X'
        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle = cp.ClassStyle | CP_NOCLOSE_BUTTON;
                return cp;
            }
        }

        private void gridV3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
