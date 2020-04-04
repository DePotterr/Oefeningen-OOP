using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OefPersoon;

namespace MinorsNotAllowd
{
    public partial class Form1 : Form
    {
        List<Persoon> personen = new List<Persoon>();
        public Form1()
        {
            InitializeComponent();
            geslachtComboBox.DataSource = Enum.GetValues(typeof(Persoon.Geslachten));
            geboortedatumDateTimePicker.MaxDate = DateTime.Today;
            geboortedatumDateTimePicker.Value = DateTime.Today.AddYears(-18);
            label1.Hide();
        }

        private void ToevoegenPersoonButton_Click(object sender, EventArgs e)
        {
            try
            {
                personen.Add(new Persoon(voornaamTextBox.Text, naamTextBox.Text, geboortedatumDateTimePicker.Value, (Persoon.Geslachten)geslachtComboBox.SelectedItem));
                ShowPersonen();
                label1.Hide();
            }
            catch(Exception)
            {
                label1.Text = "Je bent nog te jong";
                label1.Show();
            }
        }

        private void ShowPersonen()
        {
            personenListView.Clear();
            for (int i = 0; i < personen.Count; i++)
            {
                personenListView.Items.Add(personen[i] + "\n");
            }
        }
    }
}
