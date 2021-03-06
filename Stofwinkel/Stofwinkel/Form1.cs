﻿using System;
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
        private void InputLeegmaken()
        {
            naamTextbox.Clear();
            designlabelTextbox.Clear();

        }
        private void UpdateListBox()
        {
            stoffenListBox.Items.Clear();
            stofWinkel.Stoffen.Sort();
            foreach (Stof stof in stofWinkel.Stoffen)
            {
                stoffenListBox.Items.Add(stof);
            }
        }
        private void ToevoegenButton_Click(object sender, EventArgs e)
        {
            if (isKatoen)
            {
                try
                {
                    Katoenenstoffen katoenenstof = new Katoenenstoffen(naamTextbox.Text, designlabelTextbox.Text, (double)PrijsPerMeternumericUpDown.Value, (double)krimpPerNumericUpDown.Value, (Kwaliteitlabels)kwaliteitsComboBox.SelectedItem, bioCheckBox.Checked);
                    stofWinkel.StofToevoegen(katoenenstof);
                    //stoffenListBox.Items.Add(naamTextbox.Text);//hier zal je enkel de naam van uw stof weergeven. De rest (inclusief de naam) heb reeds aan uw lijst toegevoegd
                    InputLeegmaken();
                    MessageBox.Show(stofWinkel.Stoffen[stofWinkel.Stoffen.Count - 1].ToString(),"Katoenstof is toegevoegd.");
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
                    Stretchstoffen stretchstof = new Stretchstoffen(naamTextbox.Text, designlabelTextbox.Text, (double)PrijsPerMeternumericUpDown.Value, (double)krimpPerNumericUpDown.Value, (Kwaliteitlabels)kwaliteitsComboBox.SelectedItem, (double)stretchPercNumericUpDown.Value, droogkastCheckBox.Checked);
                    stofWinkel.StofToevoegen(stretchstof);
                    //stoffenListBox.Items.Add(naamTextbox.Text);
                    InputLeegmaken();
                    MessageBox.Show("Stretchstof is toegevoegd.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            UpdateListBox();
        }
    }
}
