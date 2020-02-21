using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eigenaar_heeft_meerdere_auto_s
{
    class Persoon
    {
        public enum Geslachten { Man, Vrouw}
        public string Voornaam { get; set; }
        public string Naam { get; set; }
        public DateTime Geboortedatum { get; set; }
        public Geslachten Geslacht { get; set; }
        public List<Auto> Auto { get; set; }

        public Persoon(string voornaam, string naam, DateTime geboortedatum, Geslachten geslacht)//, List<Auto> auto)
        {
            this.Voornaam = voornaam;
            this.Naam = naam;
            this.Geboortedatum = geboortedatum;
            this.Geslacht = geslacht;
            this.Auto = new List<Auto>();//auto;
        }

        public Persoon(string voornaam, string naam) : this(voornaam, naam, new DateTime(2000, 1, 1), Geslachten.Vrouw)
        {}
        public int Berekenleeftijd(DateTime geboortedatum)
        {
            int leeftijd = DateTime.Today.Year - this.Geboortedatum.Year;
            DateTime Vergelijkinggeboortedatum = new DateTime(DateTime.Today.Year, geboortedatum.Month, geboortedatum.Day);
            if (Vergelijkinggeboortedatum > DateTime.Today)
            {
                leeftijd--;
            }
            return leeftijd;
        }
        public int Leeftijd()
        {
            return Berekenleeftijd(this.Geboortedatum);
        }

        public bool AutoToevoegen(Auto auto)
        {
            if (auto != null)
            {
                this.Auto.Add(auto);
                return true;
            }

            return false;
        }

        public bool AutoVerwijderen(Auto auto)
        {
            if (auto != null)
            {
                this.Auto.Remove(auto);
                return true;
            }

            return false;
        }
        public override string ToString()
        {
            string autoResultaat = "\nAuto's: ";
            if (this.Auto.Count != 0)
            {
                for (int i = 0; i < this.Auto.Count; i++)
                {
                    autoResultaat = autoResultaat + this.Auto[i];
                }
            }
            else
            {
                autoResultaat = autoResultaat + "Geen";
            }
        
            return "\nPersoon: \n\tVoornaam: " + this.Voornaam + "\n\tNaam: " + this.Naam + "\n\tLeeftijd: " + this.Leeftijd() + " jaar oud." + autoResultaat;
        }
    }
}
