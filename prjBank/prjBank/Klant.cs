using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjBank
{
    class Klant
    {
        private string postcode;

        public string Naam { get; set; }
        public string Straat { get; set; }
        public int Huisnummer { get; set; }

        public string Postcode
        {
            get { return postcode; }
            set
            {
                if (TelLetters(value) < 4)
                {
                    postcode = value;
                }
                else
                {
                    postcode = "9120";
                }
            }
        }
        public string Gemeente { get; set; }
        public List<Spaarrekening> Spaarrekeningen { get; set; }
        public List<Beleggingsrekening> Beleggingsrekeningen { get; set; }
        public Klant(string naam, string straat, int huisnummer, string postcode, string gemeente)
        {
            Naam = naam;
            Straat = straat;
            Huisnummer = huisnummer;
            Postcode = postcode;
            Gemeente = gemeente;
            this.Spaarrekeningen = new List<Spaarrekening>();
            this.Beleggingsrekeningen = new List<Beleggingsrekening>();
        }

        public int TelLetters(string woord)
        {
            int count = 0;
            for (int i = 0; i < woord.Length; i++)
            {
                count++;
            }
            return count;
        }
        public override string ToString()
        {
            string adres = "\n\t\t" + this.Straat + " nr: " + this.Huisnummer;
            return "\n\t\tNaam klant:" + this.Naam + adres + "\n\t\tPostcode: " + this.Postcode + "\n\t\tGemeente: " + this.Gemeente + "\n\t\tSpaarrekeningen: " + this.Spaarrekeningen + "\n\t\tBeleggingsrekeningen: " + this.Beleggingsrekeningen;
        }
    }
}
