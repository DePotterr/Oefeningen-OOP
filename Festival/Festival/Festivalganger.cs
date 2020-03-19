using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Festival
{
    class Festivalganger : Artiest
    {
        public const double KORTING = 0.5;
        public int Leeftijd { get; set; }
        public double Inkomstprijs { get; set; }
        public bool Handicap { get; set; }
        public string Woonplaats { get; set; }
        public Festivalganger(DateTime datumEvenement, string plaatsEvenement, string naamEvenement, string voornaam, string achternaam, string woonplaats , StijlenMuziek stijlenMuziek, int leeftijd, bool handicap) : base(voornaam, achternaam, stijlenMuziek,datumEvenement,plaatsEvenement,naamEvenement)
        {
            this.Leeftijd = leeftijd;
            this.Handicap = handicap;
            this.Woonplaats = woonplaats;
            BerekenInkom();
        }
        private void BerekenInkom()
        {
            if(base.PlaatsEvenement != this.Woonplaats)
            {
                if (this.Leeftijd > 60 || this.Leeftijd < 25 || this.Handicap)
                {
                    this.Inkomstprijs = base.Inkom - (base.Inkom * KORTING);
                }
                else
                {
                    this.Inkomstprijs = base.Inkom;
                }
            }
            else
            {
                this.Inkomstprijs = 0;
            }

        }
        public override string ToString()
        {
            return base.ToString() + "\nLeeftijd: " + this.Leeftijd + "\nWoonplaats: " + this.Woonplaats + "\nHandikap: " + this.Handicap + "\nInkom: " + this.Inkomstprijs;
        }
    }
}
