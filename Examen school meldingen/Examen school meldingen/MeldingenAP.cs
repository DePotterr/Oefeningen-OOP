using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_school_meldingen
{
    public partial class MeldingenAP : Form
    {
        //
        //Fields
        //
        bool isOpdracht = false;
        List<Medewerker> medewerkers = new List<Medewerker>();
        //
        //Form
        //
        public MeldingenAP()
        {
            InitializeComponent();
        }
        //
        //Events
        //
        private void MeldingenAP_Load(object sender, EventArgs e)
        {
            try
            {
                TestdataToevoegen();
                medewerkerComboBox.DataSource = medewerkers;
                prioriteitComboBox.DataSource = Enum.GetValues(typeof(Prioriteitlagen));
                meldingenComboBox.DataSource = ((Medewerker)medewerkerComboBox.SelectedItem).Meldingen;
                meldingInfoTextBox.Text = ((Melding)meldingenComboBox.SelectedItem).ToonInfo();
                UpdateMeldingen();
                opdrachtRadioButton.Checked = true;
            }
            catch (NullReferenceException)
            {
            }
        }
        private void OpdrachtRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (opdrachtRadioButton.Checked)
            {
                isOpdracht = true;
                datumDeadlineLabel.Show();
                deadlineMaskedTextBox.Show();
                prioriteitLabel.Hide();
                prioriteitComboBox.Hide();
            }
            else
            {
                isOpdracht = false;
                prioriteitLabel.Show();
                prioriteitComboBox.Show();
                datumDeadlineLabel.Hide();
                deadlineMaskedTextBox.Hide();
            }
        }
        private void MedewerkerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateMeldingen();
        }
        private void ToevoegenButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (isOpdracht)
                {
                    Opdracht opdracht = new Opdracht(titelTextBox.Text, beschrijvingTextBox.Text, DateTime.Parse(deadlineMaskedTextBox.Text));
                    ((Medewerker)medewerkerComboBox.SelectedItem).MeldingToevoegen(opdracht);
                }
                else
                {
                    Defect defect = new Defect(titelTextBox.Text, beschrijvingTextBox.Text, (Prioriteitlagen)prioriteitComboBox.SelectedItem);
                    ((Medewerker)medewerkerComboBox.SelectedItem).MeldingToevoegen(defect);
                }
            }
            catch (DatumInHetVerledenException ex)
            {
                MessageBox.Show(ex.Message, "Fout Datum");
            }
            catch (FormatException)
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Probleem",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            UpdateMeldingen();
        }
        private void WisGeslotenButton_Click(object sender, EventArgs e)
        {
            ((Medewerker)medewerkerComboBox.SelectedItem).Meldingen.Clear();
            UpdateMeldingen();
        }
        private void SluitenButton_Click(object sender, EventArgs e)
        {
            try
            {
                ((Melding)meldingenComboBox.SelectedItem).Status = Statussen.Gesloten;
                UpdateMeldingen();
            }
            catch (NullReferenceException)
            {
            }
        }
        private void MeldingenComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateInfo();
        }
        //
        //Functies
        //
        public void UpdateMeldingen()
        {
            try
            {
                meldingenComboBox.DataSource = null;
                meldingInfoTextBox.Text = "";
                ((Medewerker)medewerkerComboBox.SelectedItem).Meldingen.Sort();
                meldingenComboBox.DataSource = ((Medewerker)medewerkerComboBox.SelectedItem).Meldingen;
                meldingInfoTextBox.Text = ((Melding)meldingenComboBox.SelectedItem).ToonInfo();
            }
            catch (NullReferenceException)
            {
            }
        }
        public void UpdateMedewerkers()
        {
            try
            {
                medewerkerComboBox.DataSource = null;
                medewerkerComboBox.DataSource = medewerkers;
            }
            catch (NullReferenceException)
            {

                throw;
            }
        }
        public void TestdataToevoegen()
        {
            try
            {
                medewerkers.Add(new Medewerker("Robin", "01.09.27-000-00"));
                medewerkers.Add(new Medewerker("Jos", "99.05.10-000-00"));
                Opdracht ramenKuisen = new Opdracht("Ramen kuisen", "Kuisen van de ramen", DateTime.Today);
                Opdracht wcSchoonmaken = new Opdracht("wc schoonmaken", "wc dweilen en stofzuigen", DateTime.Today.AddDays(4));
                Defect beamerKapot = new Defect("Beamer kapot", "Beamer geeft geen output signaal", Prioriteitlagen.Kritiek);
                Defect deurKapot = new Defect("Deur kapot", "de deur gaat niet meer open.", Prioriteitlagen.Kritiek);
                wcSchoonmaken.Status = Statussen.Gesloten;
                medewerkers[0].MeldingToevoegen(ramenKuisen);
                medewerkers[0].MeldingToevoegen(wcSchoonmaken);
                medewerkers[0].MeldingToevoegen(beamerKapot);
                medewerkers[1].MeldingToevoegen(deurKapot);
            }
            catch (DatumInHetVerledenException ex)
            {
                MessageBox.Show(ex.Message, "Probleem");
            }
        }
        public void UpdateInfo()
        {
            try
            {
                meldingInfoTextBox.Text = ((Melding)meldingenComboBox.SelectedItem).ToonInfo();
            }
            catch (Exception)
            {
            }
        }
    }
}
