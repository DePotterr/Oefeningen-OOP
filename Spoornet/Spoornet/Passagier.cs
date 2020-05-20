using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spoornet
{
    class Passagier : IComparable, ICloneable
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
                if (value == String.Format("#.#.# #-#",value))
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
            return VoorNaam + "Klasse: " + Klasse;
        }

        public int CompareTo(object obj)
        {
            if (obj == null)
                return 1;
            Passagier passagier = obj as Passagier;
            if (passagier == null)
                return 1;
            int resultPassagier = passagier.VoorNaam.CompareTo(this.VoorNaam);
            if (resultPassagier != 0)
            {
                return resultPassagier;
            }
            else
            {
                return passagier.Rijkregisternummer.CompareTo(this.Rijkregisternummer);
            }
        }

        public object Clone()
        {
            Passagier nieuwPassagier = (Passagier)this.MemberwiseClone();
            return nieuwPassagier;
        }
    }
}
