using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spoornet
{
    class Passagier
    {
        public enum Klassen { Eerste_klas, Tweede_klas}
        private string rijkregisternummer;
        public string VoorNaam { get; set; }
        public string Naam { get; set; }
        public string Adres { get; set; }

        public string Rijkregisternummer
        {
            get { return rijkregisternummer; }
            set
            {
                if (value == String.Format("#.#.# #-#"))
                {

                    rijkregisternummer = value;
                }
                else
                {
                    rijkregisternummer = "0.0.0 0-0";
                }
            }
        }

        public Klassen Klasse { get; set; }

        public Passagier(string voorNaam, string naam, string adres, string rijkregisternummer, Klassen klasse)
        {
            VoorNaam = voorNaam;
            Naam = naam;
            Adres = adres;
            Rijkregisternummer = rijkregisternummer;
            Klasse = klasse;
        }
        public override string ToString()
        {
            return Naam + "Klasse: " + Klasse;
        }
    }
}
