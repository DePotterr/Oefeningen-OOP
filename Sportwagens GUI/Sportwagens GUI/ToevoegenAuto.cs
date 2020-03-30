using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Sportwagens_GUI
{
    public partial class ToevoegenAuto : Form
    {
        List<Sportwagen> sportwagens = new List<Sportwagen>();
        List<Gezinswagen> gezinswagens = new List<Gezinswagen>();
        bool isSport;
        public ToevoegenAuto()
        {
            InitializeComponent();
        }
        private void ToevoegenAuto_Load(object sender, EventArgs e)
        {
            HideAllElements();
            merkComboBox.Items.Add(Wagen.Merken.BMW);
            merkComboBox.Items.Add(Wagen.Merken.Ford);
            merkComboBox.Items.Add(Wagen.Merken.Mercedes);
            merkComboBox.Items.Add(Wagen.Merken.Peugeot);
            merkComboBox.Items.Add(Wagen.Merken.Toyota);
            merkComboBox.Items.Add(Wagen.Merken.Volvo);
            typeComboBox.Items.Add(Wagen.Types.AMG);
            typeComboBox.Items.Add(Wagen.Types.GT);
            typeComboBox.Items.Add(Wagen.Types.Mustang);
            typeComboBox.Items.Add(Wagen.Types.Yaris);
            IGDDateTimePicker.MaxDate = DateTime.Today;
            IGDDateTimePicker.MinDate = DateTime.Today.AddYears(-200);
            merkComboBox.SelectedItem = Wagen.Merken.BMW;
            typeComboBox.SelectedItem = Wagen.Types.GT;
            discriptionToolTip.ToolTipIcon = ToolTipIcon.Info;
            discriptionToolTip.ToolTipTitle = "Info";
            discriptionToolTip.SetToolTip(merkComboBox, "Selecteer merk.");
            discriptionToolTip.SetToolTip(typeComboBox, "Selecteer type.");
            discriptionToolTip.SetToolTip(kmTellerNumericUpDown, "Voer kilometer teller in.");
            discriptionToolTip.SetToolTip(IGDDateTimePicker, "Kies datum.");
            discriptionToolTip.SetToolTip(nummerplaatTextBox, "Voer nummerplaat in.");
            discriptionToolTip.SetToolTip(BrandstofverbruikNumericUpDown, "Voer brandstofverbruik in.");
            discriptionToolTip.SetToolTip(zitplaatsenNumericUpDown, "Voer aantal ztiplaatsen in.");
            discriptionToolTip.SetToolTip(koffervolumeNumericUpDown, "Voer koffervolume in.");
            discriptionToolTip.SetToolTip(pkNumericUpDown, "Voer pk van auto in.");
            discriptionToolTip.SetToolTip(aantalVitessenNumericUpDown, "Voer het aantal vitessen in.");
        }

        private void CheckedChanged(object sender, EventArgs e)
        {
            ShowAllElements();
            if (gezinswagenRadioButton.Checked == true)
            {
                isSport = false;
                pkNumericUpDown.Enabled = false;
                aantalVitessenNumericUpDown.Enabled = false;
                zitplaatsenNumericUpDown.Enabled = true;
                koffervolumeNumericUpDown.Enabled = true;
            }
            else
            {
                isSport = true;
                pkNumericUpDown.Enabled = true;
                aantalVitessenNumericUpDown.Enabled = true;
                zitplaatsenNumericUpDown.Enabled = false;
                koffervolumeNumericUpDown.Enabled = false;
            }
        }

        private void ToevoegenButton_Click(object sender, EventArgs e)
        {
            if (isSport)
            {
                Sportwagen sportwagen = new Sportwagen((Wagen.Merken)merkComboBox.SelectedItem, (Wagen.Types)typeComboBox.SelectedItem, int.Parse(kmTellerNumericUpDown.Value.ToString()), IGDDateTimePicker.Value, nummerplaatTextBox.Text, double.Parse(pkNumericUpDown.Value.ToString()), int.Parse(aantalVitessenNumericUpDown.Value.ToString()));
                sportwagens.Add(sportwagen);
                listView1.Items.Add(sportwagen.ToString());
            }
            else
            {
                Gezinswagen gezinswagen = new Gezinswagen((Wagen.Merken)merkComboBox.SelectedItem, (Wagen.Types)typeComboBox.SelectedItem, int.Parse(kmTellerNumericUpDown.Value.ToString()), IGDDateTimePicker.Value, nummerplaatTextBox.Text, int.Parse(zitplaatsenNumericUpDown.Value.ToString()), int.Parse(koffervolumeNumericUpDown.Value.ToString()));
                gezinswagens.Add(gezinswagen);
                listView1.Items.Add(gezinswagen.ToString());
            }
        }
        private void HideAllElements()
        {
            merkLabel.Hide();
            typeLabel.Hide();
            kmTellerLabel.Hide();
            label1.Hide();
            nummerplaatLabel.Hide();
            brandstofverbruikLabel.Hide();
            zitplaatsenLabel.Hide();
            koffervolumeLabel.Hide();
            pkLabel.Hide();
            aantalVitessenLabel.Hide();
            merkComboBox.Hide();
            typeComboBox.Hide();
            kmTellerNumericUpDown.Hide();
            IGDDateTimePicker.Hide();
            BrandstofverbruikNumericUpDown.Hide();
            nummerplaatTextBox.Hide();
            BrandstofverbruikNumericUpDown.Hide();
            zitplaatsenNumericUpDown.Hide();
            koffervolumeNumericUpDown.Hide();
            pkNumericUpDown.Hide();
            aantalVitessenNumericUpDown.Hide();
        }
        private void ShowAllElements()
        {
            merkLabel.Show();
            typeLabel.Show();
            kmTellerLabel.Show();
            label1.Show();
            nummerplaatLabel.Show();
            brandstofverbruikLabel.Show();
            zitplaatsenLabel.Show();
            koffervolumeLabel.Show();
            pkLabel.Show();
            aantalVitessenLabel.Show();
            merkComboBox.Show();
            typeComboBox.Show();
            kmTellerNumericUpDown.Show();
            IGDDateTimePicker.Show();
            BrandstofverbruikNumericUpDown.Show();
            nummerplaatTextBox.Show();
            BrandstofverbruikNumericUpDown.Show();
            zitplaatsenNumericUpDown.Show();
            koffervolumeNumericUpDown.Show();
            pkNumericUpDown.Show();
            aantalVitessenNumericUpDown.Show();
        }

        private void VerwijderenButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gezinswagens.Count; i++)
            {
                if(gezinswagens[i].Nummerplaat == verwijderenNummerplaatTextBox.Text)
                {
                    gezinswagens.RemoveAt(i);
                    listView1.Items.RemoveAt(i);
                }
            }

            for (int i = 0; i < sportwagens.Count; i++)
            {
                if (sportwagens[i].Nummerplaat == verwijderenNummerplaatTextBox.Text)
                {
                    sportwagens.RemoveAt(i);
                    listView1.Items.RemoveAt(i);
                }
            }
        }
    }
}
