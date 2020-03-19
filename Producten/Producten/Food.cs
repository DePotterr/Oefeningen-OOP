using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Producten
{
    class Food : Product
    {
        const double VERHOGINGPERKG = 1.2;
        public DateTime Vervaldatum { get; set; }
        public int Koeltemperatuur { get; set; }
        public double AantalKilogram { get; set; }

        public Food(string leverancier, string naam, double verkoopprijs, DateTime vervaldatum, int koeltemperatuur, double aantalKilogram) : base(leverancier, naam, verkoopprijs)
        {
            this.Vervaldatum = vervaldatum;
            this.Koeltemperatuur = koeltemperatuur;
            this.AantalKilogram = aantalKilogram;
            BerekenVerkoopprijs(verkoopprijs);
        }

        public override void BerekenVerkoopprijs(double verkoopprijs)
        {
            verkoopprijs = (verkoopprijs * VERHOGINGPERKG) * this.AantalKilogram;
            this.Verkoopprijs = verkoopprijs;
        }

        public override string ToString()
        {
            return "Food:\n\t" + base.ToString() + "\n\tVervaldatum: " + Vervaldatum + "\n\tKoeltemperatuur: " + Koeltemperatuur + "\n\tAantalKG: " + this.AantalKilogram;
        }
    }
}
