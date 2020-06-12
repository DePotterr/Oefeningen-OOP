using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Applicatie_Items_Bestellen
{
    public partial class Form1 : Form
    {
        //
        //Fields
        //
        bool isGame = false;
        List<Item> items = new List<Item>();
        List<Item> bestelbon = new List<Item>();
        //
        //Form
        //
        public Form1()
        {
            InitializeComponent();
        }
        //
        //Events
        //
        private void Form1_Load(object sender, EventArgs e)
        {
            gameRadioButton.Checked = true;
            bestelbonTextBox.Text = UpdateBestelbon();
            UpdateTotaalBedrag();
            editieComboBox.DataSource = Enum.GetValues(typeof(Edities));
        }
        private void GameRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (gameRadioButton.Checked)
            {
                isGame = true;
            }
            else
            {
                isGame = false;
            }
            UpdateItemKeuze();
        }
        private void ToevoegenButton_Click(object sender, EventArgs e)
        {
            ItemToevoegen();
        }
        private void BetaalButton_Click(object sender, EventArgs e)
        {
            bestelbon.Clear();
            items.Clear();
            bestelbonTextBox.Text = UpdateBestelbon();
            UpdateTotaalBedrag();
            MessageBox.Show("Bestelling is geplaatst.");
        }
        //
        //Functies
        //
        public void ItemAanmaken()
        {
            Item newItem;
            try
            {
                if (isGame)
                {
                    newItem = new Game(titelTextBox.Text, double.Parse(prijsTextBox.Text), int.Parse(aantalTextBox.Text), (Edities)editieComboBox.SelectedItem);
                    items.Add(newItem);
                }
                else
                {
                    newItem = new Boek(titelTextBox.Text, double.Parse(prijsTextBox.Text), int.Parse(aantalTextBox.Text), acteurTextBox.Text, int.Parse(paginasTextBox.Text));
                    items.Add(newItem);
                }
            }
            catch (OverflowException)
            {

            }
            catch(MaxAantalException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("Er iets is foutgelopen.", "Foutmelding!");
            }
        }
        public void ItemToevoegen()
        {
            ItemAanmaken();
            bestelbonTextBox.Text = UpdateBestelbon();
            UpdateTotaalBedrag();
        }
        public void UpdateItemKeuze()
        {
            if (isGame)
            {
                acteurTextBox.Enabled = false;
                paginasTextBox.Enabled = false;
                editieComboBox.Enabled = true;
            }
            else
            {
                acteurTextBox.Enabled = true;
                paginasTextBox.Enabled = true;
                editieComboBox.Enabled = false;
            }
        }
        public string UpdateBestelbon()
        {
            bestelbon = items;
            string bestelbonText = "";
            bestelbon.Sort();
            for (int i = 0; i < bestelbon.Count; i++)
            {
                bestelbonText += bestelbon[i].ToString() + Environment.NewLine;
            }
            return bestelbonText;
        }
        public void UpdateTotaalBedrag()
        {
            double totaal = 0;
            for (int i = 0; i < bestelbon.Count; i++)
            {
                totaal += bestelbon[i].PrijsBerekenen();
            }
            bedragTextBox.Text = totaal.ToString();
        }
    }
}
