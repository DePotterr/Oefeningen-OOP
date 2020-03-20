using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Festival
{
    class Festivalganger : Persoon
    {
        public const double KORTING = 0.5;
        public int Leeftijd { get; set; }
        public double Inkomstprijs { get; set; }
        public bool Handicap { get; set; }
        public string Woonplaats { get; set; }
        public Evenement MijnFestival { get; set; }
        public Festivalganger(string voornaam, string achternaam, string woonplaats , int leeftijd, bool handicap, Evenement festival) : base(voornaam, achternaam)
        {
            this.Leeftijd = leeftijd;
            this.Handicap = handicap;
            this.Woonplaats = woonplaats;
            MijnFestival = festival;
            BerekenInkom();
        }
        private void BerekenInkom()
        {
            double basisprijs = MijnFestival.Inkom;
            if(MijnFestival.PlaatsEvenement != this.Woonplaats)
            {
                if (this.Leeftijd > 60 || this.Leeftijd < 25 || this.Handicap)
                {
                    this.Inkomstprijs = basisprijs - (basisprijs * KORTING);
                }
                else
                {
                    this.Inkomstprijs = basisprijs;
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
