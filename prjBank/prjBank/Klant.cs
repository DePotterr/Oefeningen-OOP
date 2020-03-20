using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjBank
{
    class Klant
    {
        private static int klantennummer = 1;
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
        public int Klantennummer { get; set; }
        public Klant(string naam, string straat, int huisnummer, string postcode, string gemeente)
        {
            Naam = naam;
            Straat = straat;
            Huisnummer = huisnummer;
            Postcode = postcode;
            Gemeente = gemeente;
            this.Spaarrekeningen = new List<Spaarrekening>();
            this.Beleggingsrekeningen = new List<Beleggingsrekening>();
            Klantennummer = klantennummer++;
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
            string spaarrekeningen = "";
            string beleggingsrekening = "";
            if(this.Spaarrekeningen.Count > 0)
            {
                for (int i = 0; i < this.Spaarrekeningen.Count; i++)
                {
                    spaarrekeningen += this.Spaarrekeningen[i];
                }
            }
            else
            {
                beleggingsrekening = "Er zijn nog geen spaarrekeningen.";
            }

            if (this.Beleggingsrekeningen.Count > 0)
            {
                for (int i = 0; i < this.Beleggingsrekeningen.Count; i++)
                {
                    beleggingsrekening += this.Beleggingsrekeningen[i];
                }
            }
            else
            {
                beleggingsrekening = "Er zijn nog geen beleggingsrekeningen.";
            }

            string adres = "\n\t" + this.Straat + " nr: " + this.Huisnummer;
            return "\n\tKlantennummer: " + this.Klantennummer + "\n\tNaam klant:" + this.Naam + adres + "\n\tPostcode: " + this.Postcode + "\n\tGemeente: " + this.Gemeente + "\n\tSpaarrekeningen: " + spaarrekeningen + "\n\tBeleggingsrekeningen: " + beleggingsrekening + "\n";
        }
    }
}
