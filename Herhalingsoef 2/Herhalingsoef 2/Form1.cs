using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Herhalingsoef_2
{
    public partial class Form1 : Form
    {
        bool isAT;
        readonly BeheerPersoneel beheerPersoneel = new BeheerPersoneel(new List<Personeel>());

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = beheerPersoneel.Personeel;
            listBox2.DataSource = beheerPersoneel.OntslagenPersoneel;
        }

        private void ToevoegenButton_Click(object sender, EventArgs e)
        {
            if(atRadioButton.Checked || opRadioButton.Checked)
            {
                if (isAT)
                {
                    AdministratiefPersoneel personeel = new AdministratiefPersoneel(VoornaamTextBox.Text, naamTextBox.Text, startDateTimePicker.Value, benoemdCheckBox.Checked);
                    beheerPersoneel.Personeel.Add(personeel);
                }
                else
                {
                    OnderwijzendPersoneel personeel = new OnderwijzendPersoneel(VoornaamTextBox.Text, naamTextBox.Text, startDateTimePicker.Value, benoemdCheckBox.Checked);
                    beheerPersoneel.Personeel.Add(personeel);
                }
            }
            else
            {
                MessageBox.Show("Selecteer een type personeel.");
            }
            listBox1.DataSource = null;
            listBox1.DataSource = beheerPersoneel.Personeel;
        }

        private void VerwijderenButton_Click(object sender, EventArgs e)
        {
            try
            {
                string resultaat = "";
                List<Personeel> ontslagenPersoneel = beheerPersoneel.Ontslagen(int.Parse(verwijderenTextBox.Text));
                foreach (Personeel personeel in ontslagenPersoneel)
                {
                    resultaat += personeel.ToString() + "\n";
                }
                MessageBox.Show($"{resultaat} is ontslagen");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            listBox1.DataSource = null;
            listBox1.DataSource = beheerPersoneel.Personeel;
            listBox2.DataSource = null;
            listBox2.DataSource = beheerPersoneel.OntslagenPersoneel;
        }

        private void AtRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (atRadioButton.Checked)
            {
                isAT = true;
            }
            else
            {
                isAT = false;
            }
        }
    }
}
