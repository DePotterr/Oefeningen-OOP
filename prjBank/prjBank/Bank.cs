using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjBank
{
    class Bank
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
                if(TelLetters(value) < 4)
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
        public List<Klant> Klanten { get; set; }

        public Bank(string naam, string straat, int huisnummer, string postcode, string gemeente)
        {
            Naam = naam;
            Straat = straat;
            Huisnummer = huisnummer;
            Postcode = postcode;
            Gemeente = gemeente;
            this.Klanten = new List<Klant>();
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
            string klantenstr = "";
            for (int i = 0; i < this.Klanten.Count; i++)
            {
                klantenstr += this.Klanten[i];
            }
            if(this.Klanten.Count == 0)
            {
                klantenstr = "Geen klanten";
            }
            string adres = "\n" + this.Straat + " nr: " + this.Huisnummer;
            return "Naam bank: " + this.Naam + adres + "\nPostcode: " + this.Postcode + "\nGemeente: " + this.Gemeente + "\nKlanten: " + klantenstr;
        }
    }
}
