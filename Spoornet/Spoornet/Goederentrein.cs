using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spoornet
{
    class Goederentrein : Trein
    {
        private double GEVAARLIJKPRODUCT_PROCENT = 0.20;
        public double Bruto { get; set; }
        public double Netto { get; set; }
        public bool IsGevaarlijkProduct { get; set; }
        public Goederentrein(string naam, Bestemmingen bestemming, DateTime tijdstip, double bruto, double netto, bool isGevaarlijkProduct) : base(naam, bestemming, tijdstip)
        {
            Bruto = bruto;
            Netto = netto;
            IsGevaarlijkProduct = isGevaarlijkProduct;
        }
        public Goederentrein(string naam, Bestemmingen bestemming, DateTime tijdstip, double bruto, double netto) : this(naam, bestemming, tijdstip, bruto, netto,false)
        {

        }
        public override void Vertraging(double minuten)
        {
            base.Vertraging(minuten + (minuten * GEVAARLIJKPRODUCT_PROCENT));
        }
        public double Tarragewicht(double bruto, double netto)
        {
            return bruto + netto;
        }
        public double Tarragewicht()
        {
            return Tarragewicht(Bruto, Netto);
        }
    }
}
