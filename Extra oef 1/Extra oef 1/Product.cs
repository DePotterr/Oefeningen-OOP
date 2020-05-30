using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra_oef_1
{
    abstract class Product : IComparable
    {
        const int STANDAARD_GARANTIE = 2;
        const int EXTRA_GARANTIE = 3;
        private int voorraadProduct;
        private int aantalJarenGarantie;
        public string Naam { get; set; }
        public double Prijs { get; set; }

        public int VoorraadProduct
        {
            get { return voorraadProduct; }
            set
            {
                if(value > 100 || value < 0)
                {
                    throw new Exception("Voorraad is max 100 en min 1");
                }
                else
                {
                    voorraadProduct = value;
                }
            }
        }

        public bool ExtraGarantie { get; set; }

        public int AantalJarenGarantie
        {
            get { return aantalJarenGarantie; }
            set
            {
                if (ExtraGarantie)
                {
                    aantalJarenGarantie = EXTRA_GARANTIE;
                }
                else
                {
                    aantalJarenGarantie = STANDAARD_GARANTIE;
                }
            }
        }


        public Product(string naam, double prijs, int voorraadProduct, bool extraGarantie)
        {
            Naam = naam;
            Prijs = prijs;
            VoorraadProduct = voorraadProduct;
            ExtraGarantie = extraGarantie;
            AantalJarenGarantie = 0;
            Prijs = BerekenVerkoopprijs();
        }
        public double BerekenVerkoopprijs()
        {
            return Prijs + ExtraBetalenBijPrijs();
        }

        public abstract double ExtraBetalenBijPrijs();
        public int ControleerVoorraad()
        {
            return VoorraadProduct;
        }
        public void VoorraadBijvullen(int aantal)
        {
            VoorraadProduct = VoorraadProduct + aantal;
        }
        public void VoorraadAfnemen(int aantal)
        {
            VoorraadProduct = VoorraadProduct - aantal;
        }
        public override string ToString()
        {
            return $"Naam: {Naam} Prijs: {Prijs} EUR Voorraad: {VoorraadProduct} Garantie: {AantalJarenGarantie}";
        }
        public string PrintNaamEnPrijs()
        {
            return $"Naam: {Naam} Prijs: {Prijs} EUR";
        }

        public int CompareTo(object obj)
        {
            if (obj == null)
            {
                return 1;
            }
            Product p = obj as Product;
            if (p == null)
            {
                return 1;
            }
            int result = Naam.CompareTo(p.Naam);
            if (result == 0)
            {
                result = Prijs.CompareTo(p.Prijs);
            }
            return result;
        }
    }
}
