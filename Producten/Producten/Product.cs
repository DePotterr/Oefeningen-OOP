using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Producten
{
    class Product
    {
        public string Leverancier { get; set; }
        public string Naam { get; set; }
        public double Verkoopprijs { get; set; }

        public Product(string leverancier, string naam, double verkoopprijs)
        {
            Leverancier = leverancier;
            Naam = naam;
            BerekenVerkoopprijs(verkoopprijs);
        }

        public virtual void BerekenVerkoopprijs(double verkoopprijs)
        {
            this.Verkoopprijs = verkoopprijs;
        }

        public override string ToString()
        {
            return "Naam: " + this.Naam + "\n\tLeverancier: " + this.Leverancier + "\n\tVerkoopprijs: " + this.Verkoopprijs;
        }
    }
}
