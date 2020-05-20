using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto_GUI_Exceptions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string merk = merkTextBox.Text;
                string type = typeTextBox.Text;
                string nummerplaat = nummerplaatTextBox.Text;
                int aantalkm = int.Parse(aantalkmTextBox.Text);
                DateTime datum = DateTime.Parse(datumTextBox.Text);
                Auto auto = new Auto(merk, type, nummerplaat, aantalkm, datum);
                MessageBox.Show("Auto is aangemaakt\n" + auto.ToString(), "Succes");
            }
            catch (FormatException)
            {
                MessageBox.Show("1 of meerdere velden zijn in het verkeerde formaat.","Fout!");
            }
            catch (OverflowException)
            {
                MessageBox.Show("1 of meerdere velden hebben een te grote waarde.", "Fout!");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ik heb geen idee wa gij hebt verkeerd gedaan maar hier heb je u exception\n" + ex,"lol");
            }
        }
    }
}
