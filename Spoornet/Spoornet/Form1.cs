using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            treinen[0].Passagiers.Add(new Passagier("Robin", "de Potter", "mooi", "0.0.0 0-0", Passagier.Klassen.Eerste_klas));
            listBox1.DataSource = treinen;
            comboBox1.DataSource = treinen;
        }

        private void ListBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(((Trein)listBox1.SelectedItem).ToString());
        }

        private void ZoekButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(((Trein)comboBox1.SelectedItem).ZoekKLassePassagier(maskedTextBox1.Text.ToString()));
        }
    }
}
