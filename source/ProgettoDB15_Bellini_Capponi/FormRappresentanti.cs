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
    public partial class FormRappresentanti : Form
    {
        private MainForm mf;
        private LinqToSQLClassDataContext db = new LinqToSQLClassDataContext();

        public FormRappresentanti(MainForm mf)
        {
            InitializeComponent();
            this.mf = mf;
            this.radioButtonPrivato.Checked = true;
            this.radioButtonTubo.Checked = true;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            mf.Visible = true;
            this.Close();
        }

        // Query R1: Visualizzazione di tutti i clienti.
        private void queryR1()
        {
            db.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues, db.ORDINE);
            var queryR1 = from c in db.CLIENTE
                          select c;
            this.dataGridR1.DataSource = queryR1;
        }

        // Pulsante di aggiornamento per query R1
        private void buttonAggiorna_Click(object sender, EventArgs e)
        {
            this.queryR1();
        }

        // Query R2: Aggiunta di un nuovo cliente.
        private void queryR2()
        {
            CLIENTE cliente = new CLIENTE
            {
                descrizione = this.textBoxDescrizione.Text
            };
            if (this.radioButtonPrivato.Checked == true)
            {
                // Aggiunta di un nuovo cliente di tipo privato.
                cliente.tipo = "privato";
                cliente.nome = this.textBoxNome.Text;
                cliente.cognome = this.textBoxCognome.Text;
            }
            else
            {
                // Aggiunta di un nuovo cliente di tipo azienda.
                cliente.tipo = "azienda";
                cliente.denominazionesociale = this.textBoxDenominazione.Text;
            }

            db.CLIENTE.InsertOnSubmit(cliente);
            try
            {
                db.SubmitChanges();
            }
            catch (System.Data.Linq.DuplicateKeyException e)
            {
                db.CLIENTE.DeleteOnSubmit(cliente);
                db.SubmitChanges();
                MessageBox.Show("Hai già inserito questo cliente");
            }
            catch (Exception e)
            {
                db.CLIENTE.DeleteOnSubmit(cliente);
                db.SubmitChanges();
                MessageBox.Show(e.GetType().ToString());
            }
        }

        // Pulsante inserisci per query R2
        private void buttonInserisci_Click(object sender, EventArgs e)
        {
            this.queryR2();
        }

        // Query R3: Visualizzazione di tutti i prodotti.
        private void queryR3()
        {
            db.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues, db.ORDINE);
            var queryR3 = from p in db.PRODOTTO
                          orderby p.IDprodotto descending
                          select new
                          {
                              IDprodotto = p.IDprodotto,
                              Nome = p.nome,
                              Marchio = p.marchio,
                              TipoProdotto = p.tipoprodotto,
                              Prezzo = p.prezzo,
                              Lunghezza = p.TUBO == null ? "/" : p.TUBO.lunghezza.ToString(),
                              Diametro = p.TUBO == null ?
                                            (p.RACCORDO == null ? "/" : p.RACCORDO.diametro.ToString())
                                            : p.TUBO.diametro.ToString(),
                              Tipo = p.RUBINETTO == null ?
                                            (p.RACCORDO == null ? "/" : p.RACCORDO.tipo.ToString())
                                            : p.RUBINETTO.tipo.ToString(),
                              Descrizione = p.RUBINETTO == null ? "/" : p.RUBINETTO.descrizione.ToString()
                          };
            this.dataGridR3.DataSource = queryR3;
        }

        // Pulsante per visualizzare query R3.
        private void buttonAggiornaR3_Click(object sender, EventArgs e)
        {
            this.queryR3();
        }

        // Query R4:Aggiunta di un nuovo prodotto.
        private void queryR4()
        {
            // Inserimento di PRODOTTO
            PRODOTTO prodotto = new PRODOTTO
            {
                nome = this.textBoxNomeR4.Text,
                CASAPRODUTTRICE = (CASAPRODUTTRICE)this.comboBoxMarchio.SelectedValue,
                prezzo = Convert.ToInt32(this.textBoxPrezzo.Text)
            };
            if (this.radioButtonTubo.Checked == true)
            {
                prodotto.tipoprodotto = "tubo";
            }
            else if (this.radioButtonRubinetto.Checked == true)
            {
                prodotto.tipoprodotto = "rubinetto";
            }
            else if (this.radioButtonRaccordo.Checked == true)
            {
                prodotto.tipoprodotto = "raccordo";
            }

            db.PRODOTTO.InsertOnSubmit(prodotto);
            try
            {
                db.SubmitChanges();
            }
            catch (System.Data.Linq.DuplicateKeyException e)
            {
                db.PRODOTTO.DeleteOnSubmit(prodotto);
                db.SubmitChanges();
                MessageBox.Show("Hai già inserito questo prodotto");
            }
            catch (Exception e)
            {
                db.PRODOTTO.DeleteOnSubmit(prodotto);
                db.SubmitChanges();
                MessageBox.Show(e.GetType().ToString());
            }

            // Inserimento di TUBO o RUBINETTO o RACCORDO
            if (this.radioButtonTubo.Checked == true)
            {
                TUBO tubo = new TUBO
                {
                    IDprodotto = prodotto.IDprodotto,
                    lunghezza = Convert.ToInt32(this.textBoxLunghezza.Text),
                    diametro = Convert.ToInt32(this.textBoxDiametro.Text)
                };
                db.TUBO.InsertOnSubmit(tubo);
                try
                {
                    db.SubmitChanges();
                }
                catch (Exception e)
                {
                    db.TUBO.DeleteOnSubmit(tubo);
                    db.SubmitChanges();
                    MessageBox.Show(e.GetType().ToString());
                }
            }
            else if (this.radioButtonRubinetto.Checked == true)
            {
                RUBINETTO rubinetto = new RUBINETTO
                {
                    IDprodotto = prodotto.IDprodotto,
                    tipo = this.textBoxTipo.Text,
                    descrizione = this.textBoxDescrizioneR4.Text
                };
                db.RUBINETTO.InsertOnSubmit(rubinetto);
                try
                {
                    db.SubmitChanges();
                }
                catch (Exception e)
                {
                    db.RUBINETTO.DeleteOnSubmit(rubinetto);
                    db.SubmitChanges();
                    MessageBox.Show(e.GetType().ToString());
                }
            }
            else if (this.radioButtonRaccordo.Checked == true)
            {
                RACCORDO raccordo = new RACCORDO
                {
                    IDprodotto = prodotto.IDprodotto,
                    tipo = this.textBoxTipo.Text,
                    diametro = Convert.ToInt32(this.textBoxDiametro.Text)
                };
                db.RACCORDO.InsertOnSubmit(raccordo);
                try
                {
                    db.SubmitChanges();
                }
                catch (Exception e)
                {
                    db.RACCORDO.DeleteOnSubmit(raccordo);
                    db.SubmitChanges();
                    MessageBox.Show(e.GetType().ToString());
                }
            }
        }

        // Pulsante per visualizzare R4
        private void buttonInserisciR4_Click(object sender, EventArgs e)
        {
            this.queryR4();
        }

        // Query R5: Visualizzazione prodotto venduto dall’azienda a più clienti.
        private void queryR5()
        {
            db.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues, db.ORDINE);
            
            var queryR5 = (from s in (from d in db.DETTAGLIODORDINE
                                  join o in db.ORDINE on d.IDordine equals o.IDordine
                                  where o.tipo == "vendita"
                                  group d by new
                                  {
                                      d.PRODOTTO,
                                      o.CLIENTE
                                  } into q
                                  select new
                                  {
                                      Prodotto = q.Key.PRODOTTO,
                                      Cliente = q.Key.CLIENTE
                                  })
                           group s by s.Prodotto into z
                           orderby z.Count() descending
                           select new
                           {
                               Prodotto = z.Key.nome,
                               NClienti = z.Count()
                           }).Take(1).Single();

            this.labelR5.Text = " ' " + queryR5.Prodotto.ToString() + " ' " + " venduto a " 
                + queryR5.NClienti.ToString() + " clienti distinti.";
        }

        // Query R6: Visualizzazione dei dieci prodotti più venduti dall’azienda.
        private void queryR6()
        {
            db.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues, db.ORDINE);
            var queryR6 = (from d in db.DETTAGLIODORDINE
                           join o in db.ORDINE on d.IDordine equals o.IDordine
                           where o.tipo == "vendita"
                           group d by d.IDprodotto into q
                           orderby q.Sum(d => d.quantità) descending
                           select new
                           {
                               Prodotto = q.Key,
                               Quantità = q.Sum(d => d.quantità)
                           }).Take(10);
            this.dataGridR6.DataSource = queryR6;
        }

        // Totale delle vendite fatte ad ogni singolo cliente.
        private void queryR7()
        {
            db.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues, db.ORDINE);
            var queryR7 = from o in db.ORDINE
                          group o by o.CLIENTE into g
                          orderby g.Sum(o => o.prezzo) descending
                          select new
                          {
                              Tipo = g.Key.tipo,
                              Nome = g.Key.nome == null ? "/" : g.Key.nome.ToString(),
                              Cognome = g.Key.cognome == null ? "/" : g.Key.cognome.ToString(),
                              DenominazioneSociale = g.Key.denominazionesociale == null ? "/" : g.Key.denominazionesociale,
                              TotaleVendite = g.Sum(o => o.prezzo)
                          };
            this.dataGridR7.DataSource = queryR7;
        }

        // Disabilito text box di nome+cognome/denominazione per i clienti privati/azienda.
        private void radioButtonPrivato_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonPrivato.Checked == true)
            {
                this.textBoxNome.Enabled = true;
                this.textBoxCognome.Enabled = true;
                this.textBoxDenominazione.Text = "";
                this.textBoxDenominazione.Enabled = false;
            }
            else
            {
                this.textBoxNome.Enabled = false;
                this.textBoxNome.Text = "";
                this.textBoxCognome.Enabled = false;
                this.textBoxCognome.Text = "";
                this.textBoxDenominazione.Enabled = true;
            }
        }

        // caso di Radio Button Tubo enabled.
        private void radioButtonTubo_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonTubo.Checked == true)
            {
                this.radioButtonRubinetto.Checked = false;
                this.radioButtonRaccordo.Checked = false;
                this.textBoxDiametro.Enabled = true;
                this.textBoxLunghezza.Enabled = true;
                this.textBoxTipo.Enabled = false;
                this.textBoxDescrizioneR4.Enabled = false;
            }
        }

        // caso di Radio button Rubinetto enabled.
        private void radioButtonRubinetto_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonRubinetto.Checked == true)
            {
                this.radioButtonRaccordo.Checked = false;
                this.radioButtonTubo.Checked = false;
                this.textBoxDiametro.Enabled = false;
                this.textBoxLunghezza.Enabled = false;
                this.textBoxTipo.Enabled = true;
                this.textBoxDescrizioneR4.Enabled = true;
            }
        }

        // caso di Radio button Raccordo enabled.
        private void radioButtonRaccordo_CheckedChanged(object sender, EventArgs e)
        {
            this.radioButtonTubo.Checked = false;
            this.radioButtonRubinetto.Checked = false;
            this.textBoxDiametro.Enabled = true;
            this.textBoxLunghezza.Enabled = false;
            this.textBoxTipo.Enabled = true;
            this.textBoxDescrizioneR4.Enabled = false;
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

        private void dataGridR1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void FormRappresentanti_Load(object sender, EventArgs e)
        {
            // inizializzo combo box marchio
            this.comboBoxMarchio.DisplayMember = "name";
            this.comboBoxMarchio.ValueMember = "value";
            this.comboBoxMarchio.DataSource = from c in db.CASAPRODUTTRICE
                                              select new
                                              {
                                                  value = c,
                                                  name = c.marchio
                                              };
            // esecuzione in fase di caricamento delle query R1 R3 R5 R6 R7.
            this.queryR1();
            this.queryR3();
            this.queryR5();
            this.queryR6();
            this.queryR7();
        }
    }
}
