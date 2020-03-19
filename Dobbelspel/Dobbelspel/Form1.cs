using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dobbelspel
{
    public partial class Form1 : Form
    {
        Dobbelsteen dobbelsteen = new Dobbelsteen();
        public const int WAARDE_WINST_EEN = 20;
        public const int WAARDE_WINST_ZES = 15;
        public const int WAARDE_VERLIES_REST = -10;
        public int bedrag = 100;
        public int winstVerlies;
        public Form1()
        {
            InitializeComponent();
            bedragLabel.Text = "Bedrag: " + bedrag;
        }

        private void GooiButton_Click(object sender, EventArgs e)
        {
            if(bedrag != 0)
            {
                dobbelsteen.Gooi();
                waardeLabel.Text = dobbelsteen.Zijde.ToString();

                switch (dobbelsteen.Zijde)
                {
                    case 1:
                        winstVerlies = WAARDE_WINST_EEN;
                        break;
                    case 6:
                        winstVerlies = WAARDE_WINST_ZES;
                        break;
                    default:
                        winstVerlies = WAARDE_VERLIES_REST;
                        break;
                }

                if (bedrag + winstVerlies > 0)
                {
                    bedrag = bedrag + winstVerlies;
                    if (winstVerlies >= 0)
                    {
                        resultaatLabel.Text = "U wint: " + winstVerlies;
                    }
                    else
                    {
                        resultaatLabel.Text = "U verliest: " + winstVerlies;
                    }
                }
                else
                {
                    bedrag = 0;
                    resultaatLabel.Text = "Spel afgelopen u heeft 0 euro";
                }
                bedragLabel.Text = "Bedrag: " + bedrag;
            }
            else
            {
                resultaatLabel.Text = "U kunt niet meer gooien. Spel is afgelopen!";
            }

        }

        private void WaardeLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
