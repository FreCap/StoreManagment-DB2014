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
    public partial class DettaglioOrdine : Form
    {
        private ORDINE ordine;
        LinqToSQLClassDataContext db = new LinqToSQLClassDataContext();

        public DettaglioOrdine(ORDINE IDordine)
        {
            InitializeComponent();
            this.ordine = IDordine;
        }

        private void DettaglioOrdine_Load(object sender, EventArgs e)
        {
            this.labelIDordine.Text = this.ordine.IDordine.ToString();

            // inizializzazione combo box con i prodotti presenti nel DB
            comboBox.DisplayMember = "name";
            comboBox.ValueMember = "value";
            comboBox.DataSource = from o in db.PRODOTTO
                                               select new
                                               {
                                                   value = o,
                                                   name = o.IDprodotto + " - " + o.nome + " - " + o.marchio
                                               };
        }

        // Inserimento di un dettaglio d'ordine.
        private void query()
        {
            DETTAGLIODORDINE dettaglioGiacenza = new DETTAGLIODORDINE
            {
                IDordine = this.ordine.IDordine,
                PRODOTTO = (PRODOTTO)this.comboBox.SelectedValue,
                quantità = Convert.ToInt32(this.textBoxQuantita.Text)
            };

            db.DETTAGLIODORDINE.InsertOnSubmit(dettaglioGiacenza);

            // Update del prezzo dell'ordine all'inserimento di un nuovo dettaglio
            var ordineCorrente =
               ( from ord in db.ORDINE
                where ord.IDordine == this.ordine.IDordine
                select ord).Single();
            ordineCorrente.prezzo += dettaglioGiacenza.PRODOTTO.prezzo * dettaglioGiacenza.quantità;
         
            try
            {
                db.SubmitChanges();
            }
            catch (System.Data.Linq.DuplicateKeyException e)
            {
                db.DETTAGLIODORDINE.DeleteOnSubmit(dettaglioGiacenza);
                ordineCorrente.prezzo -= dettaglioGiacenza.PRODOTTO.prezzo * dettaglioGiacenza.quantità;
           
                db.SubmitChanges();
                MessageBox.Show("Hai già inserito questo dettaglio d'ordine nell'ordine!");
            }
            catch (Exception e)
            {
                db.DETTAGLIODORDINE.DeleteOnSubmit(dettaglioGiacenza);
                ordineCorrente.prezzo -= dettaglioGiacenza.PRODOTTO.prezzo * dettaglioGiacenza.quantità;
                db.SubmitChanges();
                MessageBox.Show(e.GetType().ToString());
            }

        }

        // Bottone per l'inserimento di un nuovo dettaglio d'ordine.
        private void buttonInserisci_Click(object sender, EventArgs e)
        {
            this.query();
            this.textBoxQuantita.Text = "";
        }

        //  Button per terminare l'inserimento.
        private void buttonFine_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
