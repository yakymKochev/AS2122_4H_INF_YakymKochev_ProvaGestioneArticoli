using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AS2122_4H_INF_Prof_ProvaGestioneArticoli
{
    public partial class frmArticolo : Form
    {
        DialogResult status = DialogResult.Cancel;

        // TODO: (5) aggiungere attributi privati dei dati inseriti nella frmArticoli
        // ...
        private string _descrizione;
        private string _unitaMisura;
        private double _prezzo;
        public DialogResult Status { get { return status; } }

        // TODO: (6) aggiungere property di sola lettura dei dati inseriti nella frmArticoli per l'utilizzo in frmMain
        // ...
        public string descrizione { get { return _descrizione; } }
        public string unitaMisura { get { return _unitaMisura; } }
        public double prezzo { get { return _prezzo; } }

        public frmArticolo()
        {
            InitializeComponent();
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            // TODO: (7) passaggio all' attributo/property dei dati inseriti nella frmArticoli con controllo di valorizzazione del dato
            // ... descrizione, unitaMisura, prezzo
            try
            {
                status = DialogResult.OK;
                if (Status == DialogResult.Cancel) return;

                _descrizione = txtDescrizione.Text;
                _unitaMisura = cmbUnitaMisura.SelectedText;
                _prezzo = int.Parse(txtPrezzo.Text);

                var articolo = new Articolo(12231, descrizione, unitaMisura, prezzo);

            } catch(Exception ex)
            {
                MessageBox.Show($"Error: {ex}");
            }

            Close();
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            status = DialogResult.Cancel;
            Close();
        }
    }
}
