using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sportwagens_GUI
{
    class Wagen
    {
        private const double VERBRUIK = 0.05;
        private const int GEM_AANTAL_KM_JAAR = 20000;
        public enum Merken { Volvo, BMW, Mercedes, Toyota, Ford, Peugeot }
        public enum Types { Mustang, Yaris, GT, AMG }
        public Merken Merk { get; set; }
        public Types Type { get; set; }
        public int KmTeller { get; set; }
        public DateTime InGebruikDatum { get; set; }
        private string nummerplaat;

        public string Nummerplaat
        {
            get { return nummerplaat; }
            set
            {
                if(value.Length >= 6 && value.Length <= 9)
                {
                    if (value[1] != '-')
                    {
                        value = value.Insert(1, "-");
                    }
                    if (value[5] != '-')
                    {
                        value = value.Insert(5, "-");
                    }
                    if(value.Length == 9)
                    {
                        nummerplaat = value;
                    }
                    else{
                        value = "fout!";
                    }
                }
                else
                {
                    value = "fout!";
                }
                value = value.ToUpper();
                nummerplaat = value;
            }
        }

        public double Brandstofverbruik { get; set; }

        public Wagen(Merken merk, Types type, int kmTeller, DateTime inGebruikDatum, string nummerplaat)
        {
            Merk = merk;
            Type = type;
            KmTeller = kmTeller;
            InGebruikDatum = inGebruikDatum;
            Nummerplaat = nummerplaat;
            Brandstofverbruik = BerekenBrandstofverbruik();
        }

        public virtual double BerekenBrandstofverbruik(int aantalJaar)
        {
            double verbruikKM = VERBRUIK;
            int gemAantalKmJaar = GEM_AANTAL_KM_JAAR / 100;
            return (verbruikKM * gemAantalKmJaar) * aantalJaar;
        }

        public virtual double BerekenBrandstofverbruik()
        {
            return BerekenBrandstofverbruik(LeeftijdAuto());
        }

        public int LeeftijdAuto()
        {
            return DateTime.Today.Year - this.InGebruikDatum.Year;
        }

        public override string ToString()
        {
            return " Merk: " + this.Merk + " Type: " + this.Type + " Km teller: " + this.KmTeller + " In gebruik datum: " + this.InGebruikDatum + " Nummerplaat: " + this.Nummerplaat + " Brandstofgebruik: " + this.Brandstofverbruik + "l";
        }

    }
}
