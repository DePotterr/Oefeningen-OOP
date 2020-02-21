using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eigenaar_heeft_meerdere_auto_s
{
    class Auto
    {
        private static int tellerAuto = 1;
        public const int AANTAL_KILOMETERS_ELK_JAAR = 20000;
        public string Merk { get; set; }
        public string Type { get; set; }
        public string Nummerplaat { get; set; }
        public int AantalKilometers { get; set; }
        public int TellerAuto { get; set; }

        public Auto(string merk, string type, string nummerplaat, int aantalkilometers)
        {
            this.Merk = merk;
            this.Type = type;
            this.Nummerplaat = nummerplaat;
            this.AantalKilometers = aantalkilometers;
            this.TellerAuto = tellerAuto++;
        }

        public Auto() : this("ONBEKEND", "ONBEKEND", "1-AAA-000", 0)
        {}

        public int BerekenAantalKilometers(int aantalJaar)
        {
            this.AantalKilometers = this.AantalKilometers + (aantalJaar * AANTAL_KILOMETERS_ELK_JAAR);
            return this.AantalKilometers;
        }

        public int BerekenAantalKilometers()
        {
            return BerekenAantalKilometers(10);
        }

        public override string ToString()
        {
            return "\nAuto " + this.TellerAuto + "\n\tMerk: " + this.Merk + "\n\tType: " + this.Type + "\n\tNummerplaat: " + this.Nummerplaat + "\n\tAantal kilometers: " + this.AantalKilometers;
        }
    }
}
