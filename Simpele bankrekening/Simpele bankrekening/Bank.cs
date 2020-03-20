using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simpele_bankrekening
{
    public partial class Bank : Form
    {
        Rekening bankrekening = new Rekening(500,DateTime.Today,123456);
        Klant klant = new Klant("Robin", "Glazenleeuwstraat", 44, "9120", "Beveren");
        public Bank()
        {
            InitializeComponent();
            Bedragweergeven();
            Naamweergeven();
            errorLabel.Hide();
        }
        private void BevestigButton_Click(object sender, EventArgs e)
        {
            int getal = 0;
            try
            {
                getal = int.Parse(bedragTextbox.Text);
            }
            catch
            {
                errorLabel.Text = "Gelieve een getal in te geven.";
            }
            if (bankrekening.Saldo + getal > 0)
            {

                bankrekening.GeldSotrtenOfAfhalen(getal);
                Bedragweergeven();
            }
            else
            {
                bankrekening.Saldo = 0;
                Bedragweergeven();
                errorLabel.Text = "Bankrekening staat op 0.";
                errorLabel.Show();

            }
        }
        public void Bedragweergeven()
        {
            walletLabel.Text = "Portemonnee: " + bankrekening.Saldo;
        }

        public void Naamweergeven()
        {
            naamLabel.Text = "Naam: " + klant.Naam;
        }

        private void Bank_Load(object sender, EventArgs e)
        {

        }
    }
}
