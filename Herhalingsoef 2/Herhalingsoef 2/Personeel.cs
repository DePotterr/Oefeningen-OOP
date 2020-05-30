using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herhalingsoef_2
{
    abstract class Personeel
    {
        private static int personeelID;
        public string Voornaam { get; set; }
        public string Naam { get; set; }
        public int PersoneelID { get; set; }
        public DateTime StartDatum { get; set; }
        public List<Vakantie> VakantiePeriodes { get; set; }
        public bool IsBenoemd { get; set; }
        public int Opzegtermijn { get; set; }

        protected Personeel(string voornaam, string naam, DateTime startDatum, List<Vakantie> vakantiePeriodes, bool isBenoemd)
        {
            Voornaam = voornaam;
            Naam = naam;
            PersoneelID = ++personeelID;
            StartDatum = startDatum;
            VakantiePeriodes = vakantiePeriodes;
            IsBenoemd = isBenoemd;
        }
        protected Personeel(string voornaam, string naam, DateTime startDatum, bool isBenoemd) : this(voornaam, naam, startDatum, new List<Vakantie>(), isBenoemd)
        {
        }
        abstract public void VakantieNemen(Vakantie vakantie);
        public int BerekenAantalJaarInDienst()
        {
            return DateTime.Today.Year - StartDatum.Year;
        }
        public override string ToString()
        {
            return $"{PersoneelID}  {Voornaam}  {Naam}";
        }
    }
}
