using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankSysteem.Exceptions;
using BankSysteem.Klassen;

namespace BankSysteem.Klassen
{
    class Bank
    {
        public string Naam { get; set; }
        public string Adres { get; set; }
        public string Telefoonnummer { get; set; }
        public List<Klant> Klanten { get; set; }
        public Bank(string naam, string adres, string telefoonnummer)
        {
            Naam = naam;
            Adres = adres;
            Telefoonnummer = telefoonnummer;
            Klanten = new List<Klant>();
        }
        public void LeningUitkeren(Klant klant, double BedragPerMaand)
        {
            Lening lening = new Lening(BedragPerMaand);
            klant.Leningen.Add(lening);
        }
        public void LeningUitkeren(Klant klant)
        {
            LeningUitkeren(klant, klant.MaxAfbetalingsBedrag());
        }
        public override string ToString()
        {
            return Naam;
        }
    }
}
