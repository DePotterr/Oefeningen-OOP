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
        Rekening bankrekening = new Rekening(500, DateTime.Today, 123456);
        Klant klant = new Klant("Robin", "Glazenleeuwstraat", 44, "9120", "Beveren");
        bool transactieGelukt = false;
        public Bank()
        {
            InitializeComponent();
            Bedragweergeven();
            Naamweergeven();
            messageLabel.Hide();
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
                messageLabel.Text = "Gelieve een getal in te geven.";
                messageLabel.Show();
            }
            if (bankrekening.Saldo + getal >= 0)
            {
                messageLabel.Hide();
                transactieGelukt = bankrekening.GeldSotrtenOfAfhalen(getal);
                if (transactieGelukt)
                {
                    messageLabel.Text = "Transactie gelukt!";
                }
                else
                {
                    messageLabel.Text = "Transactie mislukt.";
                }
                Bedragweergeven();
                messageLabel.Show();
            }
            else if (bankrekening.Saldo != 0)
            {
                Bedragweergeven();
                messageLabel.Text = "Te weinig saldo om af te halen.";
                messageLabel.Show();
            }
            else
            {
                Bedragweergeven();
                messageLabel.Text = "Bankrekening staat op 0.";
                messageLabel.Show();
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
            radioButton1.Hide();
            radioButton2.Hide();
        }
        /*
        private void CheckedChanged(object sender, EventArgs e)
        {
            int waarde = 0;
            switch (((RadioButton)sender).Text)
            {
                case "20":
                    waarde = 20;
                    if (bankrekening.Saldo - waarde >= 0 && radioButton1.Checked)
                    {
                        bankrekening.GeldAfhalen(waarde);
                    }
                    Bedragweergeven();
                    waarde = 0;
                    break;
                case "50":
                    waarde = 50;
                    if (radioButton2.Checked && bankrekening.Saldo - waarde >= 0)
                    {
                        bankrekening.GeldAfhalen(waarde);
                    }
                    Bedragweergeven();
                    waarde = 0;
                    break;
                default:
                    break;
            }
        }
        */
    }
}
