using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geef_een_getal_in
{
    public partial class Getal : Form
    {
        private const int AANTAL_GETALLEN = 3;
        private int count = 0;
        private int uitkomst = 0;
        public Getal()
        {
            InitializeComponent();
            outputLabel.Hide();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            try
            {
                int getal = int.Parse(getalTextBox.Text);
                outputLabel.Text = getal.ToString();
                uitkomst += getal;
                count++;
                if(count == AANTAL_GETALLEN)
                {
                    getalTextBox.Enabled = false;
                    enterButton.Enabled = false;
                    outputLabel.Text += "\n\nUw uitkomt is: " + uitkomst;
                }
                outputLabel.Show();
            }
            catch (FormatException)
            {
                outputLabel.Text = "Je mag enkel cijfers gebruiken.";
            }
            catch (OverflowException)
            {
                outputLabel.Text = "Je getal is te groot";
            }
            catch (Exception)
            {
                outputLabel.Text = "Er is iets misgelopen.";
            }
        }
    }
}
