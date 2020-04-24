using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
namespace Stofwinkel
{
    public partial class Form1 : Form
    {
        Winkel stofWinkel = new Winkel();
        bool isKatoen;
        
        public Form1()
        {
            InitializeComponent();
            kwaliteitsComboBox.DataSource = Enum.GetValues(typeof(Kwaliteitlabels));
            stoffenListBox.DataSource = stofWinkel.Stoffen;
        }

        private void CheckedChanged(object sender, EventArgs e)
        {
            if (katoenstofRadioButoon.Checked)
            {
                //Bool op true zetten
                isKatoen = true;
                //Eigenschappen van katoen op true zetten
                bioCheckBox.Enabled = true;
                //De rest op false
                droogkastCheckBox.Enabled = false;
                stretchPercNumericUpDown.Enabled = false;
            }
            else
            {
                //Bool op false zetten
                isKatoen = false;
                //Eigenscchappen van stretch op true zetten
                droogkastCheckBox.Enabled = true;
                stretchPercNumericUpDown.Enabled = true;
                //De rest op false
                bioCheckBox.Enabled = false;
            }
        }

        private void ToevoegenButton_Click(object sender, EventArgs e)
        {
            if (isKatoen)
            {
                try
                {
                    stofWinkel.StofToevoegen(new Katoenenstoffen(naamTextbox.Text, designlabelTextbox.Text, (double)PrijsPerMeternumericUpDown.Value, (double)krimpPerNumericUpDown.Value, (Kwaliteitlabels)kwaliteitsComboBox.SelectedItem, bioCheckBox.Checked));
                    stoffenListBox.DataSource = stofWinkel.Stoffen;
                    MessageBox.Show("Katoenstof is toegevoegd.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                try
                {
                    stofWinkel.StofToevoegen(new Stretchstoffen(naamTextbox.Text, designlabelTextbox.Text, (double)PrijsPerMeternumericUpDown.Value, (double)krimpPerNumericUpDown.Value, (Kwaliteitlabels)kwaliteitsComboBox.SelectedItem, (double)stretchPercNumericUpDown.Value, droogkastCheckBox.Checked));
                    stoffenListBox.DataSource = stofWinkel.Stoffen;
                    MessageBox.Show("Stretchstof is toegevoegd.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
