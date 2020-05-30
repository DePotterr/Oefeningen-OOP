using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankSysteem.Exceptions;
using BankSysteem.Klassen;

namespace BankSysteem
{
    public partial class Form1 : Form
    {
        Bank bank = new Bank("Belfius","adres","9999/456-410");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                Klant klant = new Klant("Robin", "adres", true, 1000);
                Klant klant1 = new Klant("Brian", "adres", false, 500);
                Klant klant2 = new Klant("Glen", "adres", true, 1050);
                Klant klant3 = new Klant("Roos", "adres", false, 1000);
                Klant klant4 = new Klant("Vincent", "adres", true, 100);
                bank.Klanten.Add(klant);
                bank.Klanten.Add(klant1);
                bank.Klanten.Add(klant2);
                bank.Klanten.Add(klant3);
                bank.Klanten.Add(klant4);
                bank.Klanten.Sort();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            comboBox1.DataSource = bank.Klanten;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(textBox1.Text) < ((Klant)comboBox1.SelectedItem).MaxAfbetalingsBedrag())
                {
                    label1.Text = $"Het aangevraagde afbetalingsbedrag voor {((Klant)comboBox1.SelectedItem).Naam} is GOEDGEKEURD";
                }
                else
                {
                    AfbetalingException ex = new AfbetalingException((Klant)comboBox1.SelectedItem);
                    MessageBox.Show(ex.Message,"Afbetaling error");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Geef een cijfer in.","Format error");
            }
            catch (KredietWaardigException ex)
            {
                MessageBox.Show(ex.Message, "Kredietwaardig error");
            }

        }
    }
}
