using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Herhalingsoef_met_GUI
{
    public partial class Form1 : Form
    {
        List<Rusthuisbewoner> rusthuisbewoner = new List<Rusthuisbewoner>();
        public Form1()
        {
            InitializeComponent();
        }

        private void ToevoegenButton_Click(object sender, EventArgs e)
        {
            try
            {
                Rusthuisbewoner selectedRusthuisbewoner = (Rusthuisbewoner)bewonersComboBox.SelectedItem;
                DateTime selectedDatum = DateTime.Parse(dateMaskedTextBox.Text);
                Activiteit.Soorten activiteitSoort = (Activiteit.Soorten)activitetienComboBox.SelectedItem;

                Activiteit nieuweActiviteit = new Activiteit(activiteitSoort, selectedDatum);
                string feedback = selectedRusthuisbewoner.ToevoegenActiviteit(nieuweActiviteit);
                MessageBox.Show(feedback);
            }
            catch (FormatException)
            {

                MessageBox.Show("Gelieve een geldige datum in te vullen");
            }
            catch (Exception)
            {
                MessageBox.Show("Er is iets misgelopen.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rusthuisbewoner.Add(new Rusthuisbewoner("Robin", "de Potter"));
            rusthuisbewoner.Add(new DementeRusthuisBewoner("dement", "dement"));
            //try
            //{
            //    rusthuisbewoner.Add(new Rusthuisbewoner("Robin", "de Potter", Rusthuisbewoner.Verdiepen.Verdiep4));
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message); 
            //}
            try
            {
                rusthuisbewoner[0].Verdiep = Rusthuisbewoner.Verdiepen.Verdiep4;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            bewonersComboBox.DataSource = rusthuisbewoner;
            activitetienComboBox.DataSource = Enum.GetValues(typeof(Activiteit.Soorten));
        }


    }
}
