using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra_oef_1
{
    class Klant
    {
        
        private static int klantNr = 0;

        private List<Product> winkelmand;

        public string KlantNr { get; set; }
        public string Naam { get; set; }
        public string Voornaam { get; set; }
        public Klant(string voornaam, string naam)
        {
            KlantNr = DateTime.Today.ToShortDateString() + ++klantNr;
            winkelmand = new List<Product>();
            Naam = naam;
            Voornaam = voornaam;
        }
        public void ProductToevoegen(Product product)
        {
            if(product.ControleerVoorraad() > 0)
            {
                winkelmand.Add(product);
                product.VoorraadAfnemen(1);
            }
            else
            {
                throw new UitverkochtException(product);
            }
        }
        public double Betalen()
        {
            if (winkelmand.Count != 0)
            {
                double totalePrijs = SubTotaal();
                winkelmand.Clear();
                return totalePrijs;
            }
            else
            {
                throw new Exception("Winkelmand is leeg.");
            }
        }
        public double SubTotaal()
        {
            double subTotaal = 0;
            foreach (Product product in winkelmand)
            {
                subTotaal += product.Prijs;
            }
            return subTotaal;
        }
        public string DrukWinkelkarAf()
        {
            string resultaat = "";
            foreach (Product product in winkelmand)
            {
                resultaat += product.PrintNaamEnPrijs() + Environment.NewLine;
            }
            return resultaat;
            //return winkelmand;
        }
        public void SorteerWinkelmandNaam()
        {
            winkelmand.Sort();
        }
        public string PrintAlleInformatie()
        {
            return $"{KlantNr} Naam: {Naam} Voornaam: {Voornaam}";
        }
        public override string ToString()
        {
            return Naam;
        }
    }
}
