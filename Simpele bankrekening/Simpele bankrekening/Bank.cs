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
        Bankrekening Bankrekening = new Bankrekening("Robin",500);
        public Bank()
        {
            InitializeComponent();
            Bedragweergeven();
            Naamweergeven();
        }

        private void OverschrijvenButton_Click(object sender, EventArgs e)
        {
            Bankrekening.Toevoegen(bedragNumericUpDown.Value);
            Bedragweergeven();
        }

        private void OpvragenButton_Click(object sender, EventArgs e)
        {
            if(Bankrekening.Rekening - bedragNumericUpDown.Value > 0)
            {
                Bankrekening.Afnemen(bedragNumericUpDown.Value);
                Bedragweergeven();
            }
            else
            {
                Bankrekening.Rekening = 0;
                Bedragweergeven();
                Popup popup = new Popup();
                popup.ShowDialog();
            }
        }

        public void Bedragweergeven()
        {
            walletLabel.Text = "Portemonnee: " + Bankrekening.Rekening;
        }

        public void Naamweergeven()
        {
            naamLabel.Text = "Naam: " + Bankrekening.NaamHouder;
        }
    }
}
