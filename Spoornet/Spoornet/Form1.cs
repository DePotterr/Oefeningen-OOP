using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spoornet
{
    public partial class Form1 : Form
    {
        List<Trein> treinen = new List<Trein>();
        public Form1()
        {
            InitializeComponent();
            treinen.Add(new Trein("IC", Bestemmingen.Antwerpen_centraal, DateTime.Now.AddHours(1)));
            treinen.Add(new Trein("UC", Bestemmingen.Antwerpen_centraal, DateTime.Now.AddHours(2)));
            treinen[0].Passagiers.Add(new Passagier("Robin", "de Potter", "mooi", "0.0.0 0-8", Passagier.Klassen.Eerste_klas));
            treinen[0].Passagiers.Add(new Passagier("AZER", "de Potter", "mooi", "0.0.0 0-8", Passagier.Klassen.Eerste_klas));
            treinen.Add((Trein)treinen[0].Clone());
            treinen[0].Passagiers[1].VoorNaam = "aangepast";
            listBox1.Items.Add(treinen[0]);
            listBox1.Items.Add(treinen[1]);
            listBox1.Items.Add(treinen[2]);
            comboBox1.DataSource = treinen;
            MessageBox.Show(GenereerRijkregisternummer(new DateTime(2020,12,12)));
        }

        private void ListBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(((Trein)listBox1.SelectedItem).ToString());
        }

        private void ZoekButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(((Trein)comboBox1.SelectedItem).ZoekKLassePassagier(maskedTextBox1.Text.ToString()));
        }
        public string GenereerRijkregisternummer(DateTime datum)
        {
            string eersteGroep = String.Format("{0:yyyy.M.d}", datum);
            return eersteGroep;
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.DataSource = ((Trein)listBox1.SelectedItem).Passagiers;
        }

        private void CloneButton_Click(object sender, EventArgs e)
        {
            Trein clonedTrein = null;
            bool gecloned = false;
            foreach (Trein trein in treinen)
            {
                if(trein.Naam == cloneTextBox.Text)
                {
                    clonedTrein = (Trein)trein.Clone();
                    gecloned = true;
                }
            }
            if (gecloned && clonedTrein != null)
            {
                treinen.Add(clonedTrein);
                listBox1.Items.Add(clonedTrein);
                MessageBox.Show("Succes");
            }
            else
            {
                MessageBox.Show("Er is iets misgelopen. Controleer de naam van de trein.");
            }
        }
        private void UpdateListBox()
        {
            listBox1.Items.Clear();
            treinen.Sort();
            foreach (Trein trein in treinen)
            {
                listBox1.Items.Add(trein);
            }
        }
        private void SortButton_Click(object sender, EventArgs e)
        {
            UpdateListBox();
        }
    }
}
