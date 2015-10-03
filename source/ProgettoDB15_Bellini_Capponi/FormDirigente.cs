using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ProgettoDB15_Bellini_Capponi
{
    public partial class FormDirigente : Form
    {
        private MainForm mf;
        private LinqToSQLClassDataContext db = new LinqToSQLClassDataContext();
        public FormDirigente(MainForm mf)
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

        enum tipoDipendenti
        {
            venditore,
            rappresentante,
            magazziniere,
            dirigente
        }

        // query D1: Visualizzazione di tutti i Dipendenti, divisi per ruolo.
        private void queryD1()
        {
            switch ((tipoDipendenti)comboBoxDipRuoli.SelectedValue)
            {
                case tipoDipendenti.venditore:
                    dataGridViewDipD1.DataSource = from d in db.DIPENDENTE
                                                   where d.tipo == comboBoxDipRuoli.SelectedValue.ToString()
                                                   select new
                                                   {
                                                       d.CODfiscale,
                                                       d.nome,
                                                       d.cognome,
                                                       d.numeroordinivendita
                                                   };
                    break;
                case tipoDipendenti.magazziniere:
                    dataGridViewDipD1.DataSource = from d in db.DIPENDENTE
                                                   where d.tipo == comboBoxDipRuoli.SelectedValue.ToString()
                                                   select new
                                                   {
                                                       d.CODfiscale,
                                                       d.nome,
                                                       d.cognome,
                                                       d.orelavorate,
                                                       d.pagaoraria,
                                                       Magazzino = d.MAGAZZINO.nome + " " + d.MAGAZZINO.indirizzo
                                                   };
                    break;
                case tipoDipendenti.rappresentante:
                    dataGridViewDipD1.DataSource = from d in db.DIPENDENTE
                                                   where d.tipo == comboBoxDipRuoli.SelectedValue.ToString()
                                                   select new
                                                   {
                                                       d.CODfiscale,
                                                       d.nome,
                                                       d.cognome,
                                                       d.numeroclienti,
                                                       d.commissione
                                                   };
                    break;
                case tipoDipendenti.dirigente:
                    dataGridViewDipD1.DataSource = from d in db.DIPENDENTE
                                                   where d.tipo == comboBoxDipRuoli.SelectedValue.ToString()
                                                   select new
                                                   {
                                                       d.CODfiscale,
                                                       d.nome,
                                                       d.cognome,
                                                       d.datainizio,
                                                       d.datafine
                                                   };
                    break;
            }

        }

        // Query D2: Aggiunta di un nuovo dipendente.
        private void queryD2()
        {

            DIPENDENTE dipendente = new DIPENDENTE
            {
                CODfiscale = textBoxInsDipCodFis.Text,
                nome = textBoxInsDipNome.Text,
                cognome = textBoxInsDipCognome.Text,
                tipo = ((tipoDipendenti)comboBoxInsDipTipoDip.SelectedValue).ToString()
            };
            Regex r = new Regex("[a-z]{6}[0-9]{2}[a-z][0-9]{2}[a-z][0-9]{3}[a-z]{1}", RegexOptions.Compiled | RegexOptions.IgnoreCase);

            if (this.textBoxInsDipCodFis.Text.Length != 16 || !r.IsMatch(this.textBoxInsDipCodFis.Text, 0))
            {
                MessageBox.Show("Codice fiscale non valido. Es: RSSMRA85T10A562S");
                return;
            }
            switch ((tipoDipendenti)comboBoxInsDipTipoDip.SelectedValue)
            {
                case tipoDipendenti.venditore:
                    break;
                case tipoDipendenti.dirigente:
                    dipendente.datainizio = dateTimePickerInsDipInizio.Value;
                    dipendente.datafine = dateTimePickerInsDipFine.Value;
                    if (dipendente.datainizio > dipendente.datafine)
                    {
                        MessageBox.Show("La data di inizio deve essere inferiore della data di fine");
                        return;
                    }
                    break;
                case tipoDipendenti.rappresentante:
                    dipendente.numeroclienti = 0;
                    dipendente.commissione = (float)numericUpDownInsDipCommissione.Value;
                    break;
                case tipoDipendenti.magazziniere:
                    dipendente.orelavorate = 0;
                    dipendente.pagaoraria = (float)numericUpDownInsDipPagaOraria.Value;
                    dipendente.MAGAZZINO = (MAGAZZINO)comboBoxInsDipMagazzino.SelectedValue;
                    break;
            }

            db.DIPENDENTE.InsertOnSubmit(dipendente);
            try
            {
                db.SubmitChanges();
            }
            catch (System.Data.Linq.DuplicateKeyException e)
            {
                db.DIPENDENTE.DeleteOnSubmit(dipendente);
                db.SubmitChanges();
                MessageBox.Show("Hai già inserito questo dipendente");
            }
            catch (Exception e)
            {
                db.DIPENDENTE.DeleteOnSubmit(dipendente);
                db.SubmitChanges();
                MessageBox.Show(e.GetType().ToString());
            }

            queryD1();
        }

        // query D3: visualizzazione di tutti i fornitori.
        private void queryD3()
        {
            dataGridViewD3.DataSource = from f in db.FORNITORE
                                        select f;
        }

        // query D4: Aggiunta di un nuovo fornitore
        private void queryD4()
        {

            FORNITORE fornitore = new FORNITORE
            {
                nome = textBoxInsFornNome.Text,
                cognome = textBoxInsFornCognome.Text,
                descrizione = textBoxInsFornDescrizione.Text
            };

            db.FORNITORE.InsertOnSubmit(fornitore);
            try
            {
                db.SubmitChanges();
            }
            catch (System.Data.Linq.DuplicateKeyException e)
            {
                db.FORNITORE.DeleteOnSubmit(fornitore);
                db.SubmitChanges();
                MessageBox.Show("Hai già inserito questo fornitore");
            }
            catch (Exception e)
            {
                db.FORNITORE.DeleteOnSubmit(fornitore);
                db.SubmitChanges();
                MessageBox.Show(e.GetType().ToString());
            }

            queryD3();
        }
        public class StringValue : System.Attribute
        {
            private string _value;

            public StringValue(string value)
            {
                _value = value;
            }

            public string Value
            {
                get { return _value; }
            }

        };
        public static class StringEnum
        {
            public static string GetStringValue(Enum value)
            {
                string output = null;
                Type type = value.GetType();

                //Check first in our cached results...

                //Look for our 'StringValueAttribute' 

                //in the field's custom attributes

                var fi = type.GetField(value.ToString());
                StringValue[] attrs =
                   fi.GetCustomAttributes(typeof(StringValue),
                                           false) as StringValue[];
                if (attrs.Length > 0)
                {
                    output = attrs[0].Value;
                }

                return output;
            }
        };
        private enum periodo
        {
            [StringValue("Ultimo Anno")]
            UltimoAnno,
            [StringValue("Ultimo Mese")]
            UltimoMese,
            [StringValue("Ultimo Settimana")]
            UltimaSettimana,
            [StringValue("Personalizzato")]
            Personalizzato
        };

        private enum campionatura
        {
            [StringValue("yyyy")]
            Annuale,
            [StringValue("MMM yyyy")]
            Mensile,
            //[StringValue("")]
            //Settimanale,
            [StringValue("d")]
            Giornaliera,
            [StringValue("g")]
            Oraria
        }

        /**
        * Query D5: Visualizzazione del profitto in un data specifica o periodo
        */
        private void queryD5()
        {
            if (comboBoxProCampionatura.SelectedValue == null || dateTimePickerProInizio.Value == null)
                return;
            string asd = StringEnum.GetStringValue((campionatura)comboBoxProCampionatura.SelectedValue);
            var query1 = from O in db.ORDINE
                         where O.data <= dateTimePickerProFine.Value &&
                                 O.data >= dateTimePickerProInizio.Value
                         select O;

            switch ((campionatura)comboBoxProCampionatura.SelectedValue)
            {
                case campionatura.Annuale:
                    this.dataGridViewD5.DataSource = query1.GroupBy(x => new { x.data.Year }).Select(x => new
                           {
                               Profitto = x.Sum(p => p.prezzo),
                               Da = x.Key.Year
                           });
                    break;
                case campionatura.Giornaliera:
                    this.dataGridViewD5.DataSource = query1.GroupBy(x => new { x.data.Year, x.data.Month, x.data.Day }).Select(x => new
                    {
                        Profitto = x.Sum(p => p.prezzo),
                        Da = x.Key.Year + "/" +
                        x.Key.Month + "/" +
                        x.Key.Day
                    });
                    break;
                case campionatura.Mensile:
                    this.dataGridViewD5.DataSource = query1.GroupBy(x => new { x.data.Year, x.data.Month }).Select(x => new
                    {
                        Profitto = x.Sum(p => p.prezzo),
                        Da = x.Key.Year + "/" +
                        x.Key.Month
                    });
                    break;
                case campionatura.Oraria:
                    this.dataGridViewD5.DataSource = query1.GroupBy(x => new { x.data.Year, x.data.Month, x.data.Day, x.data.Hour }).Select(x => new
                    {
                        Profitto = x.Sum(p => p.prezzo),
                        Da = x.Key.Year + "/" +
                        x.Key.Month + "/" +
                        x.Key.Day + " " +
                        x.Key.Hour + ":00"
                    });
                    break;
            }

        }

        /**
        * Query D6: Visualizzazione del miglior Venditore del mese(quello che ha venduto ricavando un profitto totale maggiore)
        */
        private void queryD6()
        {
            if (comboBoxMDPeriodo.SelectedValue == null || dateTimePickerMDinizio.Value == null)
                return;
            var query1 = from O in db.ORDINE
                         where O.data <= dateTimePickerMDfine.Value &&
                                 O.data >= dateTimePickerMDinizio.Value
                         group O by new
                         {
                             O.DIPENDENTE
                         } into x
                         orderby x.Sum(p => p.prezzo) descending
                         select new
                         {
                             Profitto = x.Sum(p => p.prezzo),
                             Dipendente = x.Key.DIPENDENTE.nome + " " + x.Key.DIPENDENTE.cognome
                         };
            dataGridViewD6.DataSource = query1;
        }

        /**
        * Query D7: Visualizzazione del miglior Venditore del mese(quello che ha venduto ricavando un profitto totale maggiore)
        */
        private void queryD7()
        {
            if (comboBoxMDPeriodo.SelectedValue == null || dateTimePickerMDinizio.Value == null)
                return;
            var query1 = from O in db.SUGGERIMENTO
                         where O.data <= dateTimePickerMDfine.Value &&
                                 O.data >= dateTimePickerMDinizio.Value
                         group O by new
                         {
                             O.DIPENDENTE
                         } into x
                         orderby x.Count() descending
                         select new
                         {
                             Profitto = x.Count(),
                             Dipendente = x.Key.DIPENDENTE.nome + " " + x.Key.DIPENDENTE.cognome
                         };
            dataGridViewD7.DataSource = query1;
        }

        private void queryCasaProd()
        {
            var query1 = from o in db.CASAPRODUTTRICE
                         select new
                         {
                             Marchio = o.marchio,
                             Descrizione = o.descrizione
                         };
            this.dataGridViewCaseProd.DataSource = null;
            this.dataGridViewCaseProd.Refresh();
            this.dataGridViewCaseProd.DataSource = query1;
        }

        private void unblocGroupBoxInsDip()
        {
            groupBoxDipInsDirigente.Enabled = false;
            groupBoxDipInsMagazziniere.Enabled = false;
            groupBoxDipInsRappresentante.Enabled = false;
            switch ((tipoDipendenti)comboBoxInsDipTipoDip.SelectedValue)
            {
                case tipoDipendenti.venditore:
                    break;
                case tipoDipendenti.dirigente:
                    groupBoxDipInsDirigente.Enabled = true;
                    break;
                case tipoDipendenti.rappresentante:
                    groupBoxDipInsRappresentante.Enabled = true;
                    break;
                case tipoDipendenti.magazziniere:
                    groupBoxDipInsMagazziniere.Enabled = true;
                    break;
            }
        }

        private void queryAddCasaProd()
        {
            CASAPRODUTTRICE casaProduttrice = new CASAPRODUTTRICE
            {
                marchio = this.textBoxInsCaseMarchio.Text,
                descrizione = this.textBoxInsCaseDesc.Text
            };

            db.CASAPRODUTTRICE.InsertOnSubmit(casaProduttrice);
            try
            {
                db.SubmitChanges();
            }
            catch (System.Data.Linq.DuplicateKeyException e)
            {
                db.CASAPRODUTTRICE.DeleteOnSubmit(casaProduttrice);
                db.SubmitChanges();
                MessageBox.Show("Hai già inserito una casa produttrice con lo stesso marchio");
            }
            catch (Exception e)
            {
                db.CASAPRODUTTRICE.DeleteOnSubmit(casaProduttrice);
                db.SubmitChanges();
                MessageBox.Show(e.GetType().ToString());
            }

            queryCasaProd();
        }

        private void refreshComboBoxDipRuoli()
        {
            var values = from tipoDipendenti enumValue in Enum.GetValues(typeof(tipoDipendenti))
                         select
                            new
                             KeyValuePair<tipoDipendenti, string>((enumValue), enumValue.ToString());

            comboBoxDipRuoli.DisplayMember = "Value";
            comboBoxDipRuoli.ValueMember = "Key";
            comboBoxDipRuoli.DataSource = values
                .OrderBy(x => x.Value)
                .ToList();
            comboBoxDipRuoli.SelectedValue = tipoDipendenti.venditore;

            comboBoxInsDipTipoDip.DisplayMember = "Value";
            comboBoxInsDipTipoDip.ValueMember = "Key";
            comboBoxInsDipTipoDip.DataSource = values
                .OrderBy(x => x.Value)
                .ToList();

            comboBoxInsDipTipoDip.SelectedValue = tipoDipendenti.venditore;
            unblocGroupBoxInsDip();
        }

        private void refreshComboBoxProPeriodo()
        {
            var values = from periodo enumValue in Enum.GetValues(typeof(periodo))
                         select
                            new
                             KeyValuePair<periodo, string>((enumValue), StringEnum.GetStringValue(enumValue));

            comboBoxProPeriodo.DisplayMember = "Value";
            comboBoxProPeriodo.ValueMember = "Key";
            comboBoxProPeriodo.DataSource = values
                .OrderBy(x => x.Value)
                .ToList();
            comboBoxProPeriodo.SelectedValue = periodo.UltimaSettimana;

        }

        private void refreshComboBoxMDPeriodo()
        {
            var values = from periodo enumValue in Enum.GetValues(typeof(periodo))
                         select
                            new
                             KeyValuePair<periodo, string>((enumValue), StringEnum.GetStringValue(enumValue));

            comboBoxMDPeriodo.DisplayMember = "Value";
            comboBoxMDPeriodo.ValueMember = "Key";
            comboBoxMDPeriodo.DataSource = values
                .OrderBy(x => x.Value)
                .ToList();
            comboBoxMDPeriodo.SelectedValue = periodo.UltimaSettimana;

        }

        private void refreshComboBoxProCampionatura()
        {
            var values = from campionatura enumValue in Enum.GetValues(typeof(periodo))
                         select
                            new
                             KeyValuePair<campionatura, string>((enumValue), enumValue.ToString());

            comboBoxProCampionatura.DisplayMember = "Value";
            comboBoxProCampionatura.ValueMember = "Key";
            comboBoxProCampionatura.DataSource = values
                .OrderBy(x => x.Value)
                .ToList();
            comboBoxProCampionatura.SelectedValue = campionatura.Giornaliera;

        }

        private void comboBoxDipRuoli_SelectedIndexChanged(object sender, EventArgs e)
        {
            queryD1();
        }

        private void FormDirigente_Load(object sender, EventArgs e)
        {
            // init comboBoxInsDipMagazzino
            comboBoxInsDipMagazzino.DisplayMember = "name";
            comboBoxInsDipMagazzino.ValueMember = "value";
            comboBoxInsDipMagazzino.DataSource = from o in db.MAGAZZINO
                                                 select new
                                                 {
                                                     value = o,
                                                     name = o.nome + " - " + o.indirizzo
                                                 };
            refreshComboBoxProPeriodo();
            refreshComboBoxProCampionatura();
            refreshComboBoxMDPeriodo();
            refreshComboBoxDipRuoli();
            queryD1();
            queryD3();
            queryCasaProd();
        }

        private void comboBoxInsDipTipoDip_SelectedIndexChanged(object sender, EventArgs e)
        {
            unblocGroupBoxInsDip();
        }

        private void buttonInsDip_Click(object sender, EventArgs e)
        {
            queryD2();
        }


        private void buttonInsFor_Click(object sender, EventArgs e)
        {
            queryD4();
            queryD3();
        }

        private void comboBoxProPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((periodo)comboBoxProPeriodo.SelectedValue == periodo.Personalizzato)
                groupBoxPersonalizzato.Enabled = true;
            else
                groupBoxPersonalizzato.Enabled = false;

            dateTimePickerProFine.Value = DateTime.Now.AddDays(1).AddMilliseconds(-1);
            switch ((periodo)comboBoxProPeriodo.SelectedValue)
            {
                case periodo.UltimoAnno:
                    dateTimePickerProInizio.Value = DateTime.Now.AddYears(-1);
                    break;
                case periodo.UltimaSettimana:
                    dateTimePickerProInizio.Value = DateTime.Now.AddDays(-7);
                    break;
                case periodo.UltimoMese:
                    dateTimePickerProInizio.Value = DateTime.Now.AddMonths(-1);
                    break;
                case periodo.Personalizzato:
                    break;
            }
            queryD5();
        }



        private void comboBoxProCampionatura_SelectedIndexChanged(object sender, EventArgs e)
        {
            queryD5();
        }

        private void dateTimePickerProFine_ValueChanged(object sender, EventArgs e)
        {
            queryD5();
        }

        private void dateTimePickerProInizio_ValueChanged(object sender, EventArgs e)
        {
            queryD5();
        }

        private void comboBoxMDPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((periodo)comboBoxMDPeriodo.SelectedValue == periodo.Personalizzato)
                groupBoxMDpersonalizzato.Enabled = true;
            else
                groupBoxMDpersonalizzato.Enabled = false;

            dateTimePickerMDfine.Value = DateTime.Now.AddDays(1).AddMilliseconds(-1);
            switch ((periodo)comboBoxMDPeriodo.SelectedValue)
            {
                case periodo.UltimoAnno:
                    dateTimePickerMDinizio.Value = DateTime.Now.AddYears(-1);
                    break;
                case periodo.UltimaSettimana:
                    dateTimePickerMDinizio.Value = DateTime.Now.AddDays(-7);
                    break;
                case periodo.UltimoMese:
                    dateTimePickerMDinizio.Value = DateTime.Now.AddMonths(-1);
                    break;
                case periodo.Personalizzato:
                    break;
            }
            queryD6();
            queryD7();
        }

        private void dateTimePickerMDinizio_ValueChanged(object sender, EventArgs e)
        {

            queryD6();
            queryD7();
        }

        private void dateTimePickerMDfine_ValueChanged(object sender, EventArgs e)
        {
            queryD6();
            queryD7();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mf.Visible = true;
            this.Close();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewCaseProd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonInsCase_Click(object sender, EventArgs e)
        {
            queryAddCasaProd();
        }
    }
}
