using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicatie_Items_Bestellen
{
    abstract class Item : IComparable
    {
        private int aantal;

        public string Titel { get; set; }
        public double PrijsPerStuk { get; set; }
        public int Aantal
        {
            get { return aantal; }
            set
            {
                if(value > 0 && value <= 10)
                {
                    aantal = value;
                }
                else
                {
                    throw new MaxAantalException();
                }
            }
        }

        protected Item(string titel, double prijsPerStuk, int aantal)
        {
            Titel = titel;
            PrijsPerStuk = prijsPerStuk;
            Aantal = aantal;
        }
        public double PrijsBerekenen()
        {
            return PrijsPerStuk * Aantal + ExtraKostenBerekenen();
        }
        public abstract double ExtraKostenBerekenen();
        public override string ToString()
        {
            return $"{Aantal} x {Titel}";
        }
        public int CompareTo(object obj)
        {
            if(obj == null)
            {
                return 1;
            }
            Item item = obj as Item;
            if(item == null)
            {
                return 1;
            }
            return Titel.CompareTo(item.Titel);
        }
    }
}
