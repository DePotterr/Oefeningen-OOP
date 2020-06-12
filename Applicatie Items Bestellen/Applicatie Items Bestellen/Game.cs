using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicatie_Items_Bestellen
{
    enum Edities { Standaard, GOTY, Deluxe}
    class Game : Item
    {
        const double EXTRA_KOSTEN_GOTY = 0.15;
        const double EXTRA_KOSTEN_DELUXE = 0.20;
        public Edities Editie { get; set; }
        public Game(string titel, double prijsPerStuk, int aantal, Edities editie) : base(titel, prijsPerStuk, aantal)
        {
            Editie = editie;
        }
        public Game(string titel, double prijsPerStuk, int aantal) : this(titel, prijsPerStuk, aantal, Edities.Standaard)
        {
        }
        public override double ExtraKostenBerekenen()
        {
            double extraKostenPercentage = 0;
            switch (this.Editie)
            {
                case Edities.Standaard:
                    break;
                case Edities.GOTY:
                    extraKostenPercentage = EXTRA_KOSTEN_GOTY;
                    break;
                case Edities.Deluxe:
                    extraKostenPercentage = EXTRA_KOSTEN_DELUXE;
                    break;
                default:
                    break;
            }
            return (base.PrijsPerStuk * base.Aantal) * extraKostenPercentage;
        }
        public override string ToString()
        {
            return base.ToString() + $" ({Editie})";
        }
    }
}
