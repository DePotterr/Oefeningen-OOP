using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra_oef_1
{
    class PCWinkel
    {
        public List<Klant> Klanten { get; set; }
        public List<Product> Producten { get; set; }

        public PCWinkel()
        {
            this.Klanten = new List<Klant>();
            this.Producten = new List<Product>();
        }
        public void ProductToevoegen(Product product)
        {
            Producten.Add(product);
        }
        public void ProductVerwijderen(Product product)
        {
            List<Product> teVerwijderenProducten = new List<Product>();
            foreach (Product item in Producten)
            {
                if(item == product)
                {
                    teVerwijderenProducten.Add(item);
                }
            }
            foreach (Product item in teVerwijderenProducten)
            {
                Producten.Remove(item);
            }
        }
        public string KlantToevoegen(Klant klant)
        {
            if (CheckKlantBestaat(klant))
            {
                throw new KlantBestaatAlException(klant);
            }
            else
            {
                Klanten.Add(klant);
                return klant.KlantNr;
            }

        }
        private bool CheckKlantBestaat(Klant nieuweKlant)
        {
            foreach (Klant klant in Klanten)
            {
                if (klant.Naam == nieuweKlant.Naam
                    && klant.Voornaam == nieuweKlant.Voornaam)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
