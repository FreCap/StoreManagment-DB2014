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
    public partial class FormMagazzinieri : Form
    {

        private LinqToSQLClassDataContext db = new LinqToSQLClassDataContext();
        private MainForm mf;

        private MAGAZZINO magazzinoCorrente;
        private INVENTARIO inventarioCorrente;

        public FormMagazzinieri(MainForm mf)
        {
            InitializeComponent();
            this.mf = mf;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            mf.Visible = true;
            this.Close();
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

        /**
        * Query M1: Visualizzazione di tutti i magazzini.
        */
        private void queryM1()
        {
            var query1 = from o in db.MAGAZZINO
                         select o;
            this.gridM1.DataSource = query1;
        }

        /**
       * Query M2: Aggiunta di un nuovo cliente.
       */
        private void queryM2()
        {
            MAGAZZINO magazzino = new MAGAZZINO
            {
                nome = this.textBoxNome.Text,
                indirizzo = this.textBoxIndirizzo.Text
            };

            db.MAGAZZINO.InsertOnSubmit(magazzino);
            try
            {
                db.SubmitChanges();
            }
            catch (System.Data.Linq.DuplicateKeyException e)
            {
                db.MAGAZZINO.DeleteOnSubmit(magazzino);
                db.SubmitChanges();
                MessageBox.Show("Hai già inserito un entry per questo dato");
            }
            catch (Exception e)
            {
                db.MAGAZZINO.DeleteOnSubmit(magazzino);
                db.SubmitChanges();
                MessageBox.Show(e.GetType().ToString());
            }

            refreshAll();
        }


        /**
      * Query M3: Visualizzazione degli inventari relativi ad un magazzino.
      */
        private void queryM3()
        {
            if (inventarioCorrente == null)
                return;
            var query1 = from o in db.DETTAGLIOGIACENZA
                         where o.IDinventario == inventarioCorrente.IDinventario
                         select new
                         {
                             Nome = o.PRODOTTO.nome + " - " + o.PRODOTTO.marchio,
                             Quantità = o.quantità
                         };
            this.dataGridViewInvM3.DataSource = null;
            this.dataGridViewInvM3.Refresh();
            this.dataGridViewInvM3.DataSource = query1;
        }

        /**
            * Query M4: Aggiunta di un nuovo cliente.
            */
        private void queryM4()
        {

            DETTAGLIOGIACENZA dettaglioGiacenza = new DETTAGLIOGIACENZA
            {
                IDinventario = inventarioCorrente.IDinventario,
                IDprodotto = ((PRODOTTO)comboBoxInvProdottoID.SelectedValue).IDprodotto,
                quantità = Convert.ToInt32(this.numericUpDownInvQuantità.Value)
            };

            db.DETTAGLIOGIACENZA.InsertOnSubmit(dettaglioGiacenza);
            try
            {
                db.SubmitChanges();
            }
            catch (System.Data.Linq.DuplicateKeyException e)
            {
                db.DETTAGLIOGIACENZA.DeleteOnSubmit(dettaglioGiacenza);
                db.SubmitChanges();
                MessageBox.Show("Hai già inserito un entry per questo dato");
            }
            catch (Exception e)
            {
                db.DETTAGLIOGIACENZA.DeleteOnSubmit(dettaglioGiacenza);
                db.SubmitChanges();
                MessageBox.Show(e.GetType().ToString());
            }

            queryM3();
        }
        /**
        * Query M4V2: Aggiunta di un nuovo inventario.
        */
        private void queryM4V2()
        {

            INVENTARIO inventario = new INVENTARIO
            {

                MAGAZZINO = (MAGAZZINO)comboBoxInvMagazzino2.SelectedValue,
                anno = Convert.ToInt32(this.numericUpDownInvAnno.Value)
            };

            db.INVENTARIO.InsertOnSubmit(inventario);
            try
            {
                db.SubmitChanges();
            }
            catch (System.Data.Linq.DuplicateKeyException e)
            {
                db.INVENTARIO.DeleteOnSubmit(inventario);
                db.SubmitChanges();
                MessageBox.Show("Hai già inserito questo inventario");
            }
            catch (Exception e)
            {
                db.INVENTARIO.DeleteOnSubmit(inventario);
                db.SubmitChanges();
                MessageBox.Show(e.GetType().ToString());
            }

            queryM3();
        }

        /**
       * Query M5: Visualizzazione della lista di prodotto che sono presenti in alcuni magazzini, ma che altri magazzini ne sono sprovvisti
       */
        private void queryM5()
        {
            var query = from P in
                            (
                                (from D2 in db.DETTAGLIOGIACENZA
                                 join I2 in db.INVENTARIO on D2.IDinventario equals I2.IDinventario
                                 where
                                   I2.anno == 2015
                                 group D2 by new
                                 {
                                     D2.PRODOTTO
                                 } into g
                                 where g.Count() <
                                     (from INVENTARIO in db.INVENTARIO
                                      where
                                        INVENTARIO.anno == 2015
                                      select new
                                      {
                                          INVENTARIO
                                      }).Count()
                                 select new
                                 {
                                     PRODOTTO = g.Key.PRODOTTO
                                 }))
                        from M in db.MAGAZZINO
                        where
                        !((from D3 in db.DETTAGLIOGIACENZA
                           join I3 in db.INVENTARIO on D3.IDinventario equals I3.IDinventario
                           where
                             I3.anno == 2015 &&
                             I3.IDmagazzino == M.IDmagazzino &&
                             D3.IDprodotto == P.PRODOTTO.IDprodotto
                           select new
                           {
                               Column1 = (string)null
                           }).Single() != null)
                        select new
                        {
                            Prodotto = P.PRODOTTO.IDprodotto + " - " + P.PRODOTTO.nome + " - " + P.PRODOTTO.marchio,
                            Magazzino = M.nome + " - " + M.indirizzo
                        };
            dataGridViewAssenze.DataSource = query;
        }

        private void refreshComboBoxInvMagazzino()
        {
            // init comboBoxInvMagazzino
            comboBoxInvMagazzino.DisplayMember = "name";
            comboBoxInvMagazzino.ValueMember = "value";
            comboBoxInvMagazzino.DataSource = from o in db.MAGAZZINO
                                              select new
                                              {
                                                  value = o,
                                                  name = o.nome + " - " + o.indirizzo
                                              };
            magazzinoCorrente = (MAGAZZINO)comboBoxInvMagazzino.SelectedValue;

        }
        private void refreshComboBoxInvMagazzino2()
        {
            // init comboBoxInvMagazzino
            comboBoxInvMagazzino2.DisplayMember = "name";
            comboBoxInvMagazzino2.ValueMember = "value";
            comboBoxInvMagazzino2.DataSource = from o in db.MAGAZZINO
                                               select new
                                               {
                                                   value = o,
                                                   name = o.nome + " - " + o.indirizzo
                                               };

        }

        private void refreshComboBoxInvAnno()
        {

            // init comboBoxInvMagazzino
            comboBoxInvAnno.DataSource = null;
            comboBoxInvAnno.DisplayMember = "name";
            comboBoxInvAnno.ValueMember = "value";
            comboBoxInvAnno.DataSource = from o in db.INVENTARIO
                                         where o.MAGAZZINO == magazzinoCorrente
                                         select new
                                         {
                                             value = o,
                                             name = o.anno
                                         };
            inventarioCorrente = (INVENTARIO)comboBoxInvAnno.SelectedValue;
        }

        private void refreshComboBoxInvProdottoID()
        {
            // init comboBoxInvMagazzino
            comboBoxInvProdottoID.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxInvProdottoID.DataSource = null;
            comboBoxInvProdottoID.DisplayMember = "name";
            comboBoxInvProdottoID.ValueMember = "value";
            comboBoxInvProdottoID.DataSource = from o in db.PRODOTTO
                                               select new
                                               {
                                                   value = o,
                                                   name = o.IDprodotto + " - " + o.nome + " - " + o.marchio
                                               };
        }

        private void refreshAll()
        {
            refreshComboBoxInvMagazzino();
            refreshComboBoxInvAnno();
            refreshComboBoxInvProdottoID();
            refreshComboBoxInvMagazzino2();
            queryM1();
            queryM3();
            queryM5();
        }

        private void FormMagazzinieri_Load(object sender, EventArgs e)
        {
            refreshAll();
        }

        private void buttonInserisci_Click(object sender, EventArgs e)
        {
            queryM2();
            queryM1();
        }

        private void buttonInseriesciDettaglio_Click(object sender, EventArgs e)
        {
            queryM4();
        }

        private void comboBoxInvMagazzino_SelectedIndexChanged(object sender, EventArgs e)
        {
            magazzinoCorrente = (MAGAZZINO)comboBoxInvMagazzino.SelectedValue;
            refreshComboBoxInvAnno();
            queryM3();
        }

        private void comboBoxInvAnno_SelectedIndexChanged(object sender, EventArgs e)
        {
            inventarioCorrente = (INVENTARIO)comboBoxInvAnno.SelectedValue;
            queryM3();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            queryM4V2();
            refreshAll();
        }

        private void dataGridViewInvM3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
