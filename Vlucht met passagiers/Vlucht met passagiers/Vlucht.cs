using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vlucht_met_passagiers
{
    class Vlucht
    {
        public enum Bestemmingen { Frankrijk, Engeland, Duitsland};
        public enum PlaatsenVertrek { België};
        static private int teller = 1;
        public int Vluchtnummer { get; set; }

        public Bestemmingen PlaatsBestemming { get; set; }
        public PlaatsenVertrek PlaatsVertrek { get; set; }
        public DateTime DatumVertrek { get; set; }
        public DateTime DatumAankomst { get; set; }
        public List<Persoon> Persoon { get; set; }

        public Vlucht(PlaatsenVertrek plaatsVertrek, Bestemmingen plaatsBestemming, DateTime datumVertrek, DateTime datumAankomst)
        {
            this.Vluchtnummer = teller++;
            this.PlaatsVertrek = plaatsVertrek;
            this.PlaatsBestemming = plaatsBestemming;
            this.DatumVertrek = datumVertrek;
            this.DatumAankomst = datumAankomst;
            this.Persoon = new List<Persoon>();
        }

        public Vlucht() : this(PlaatsenVertrek.België, Bestemmingen.Frankrijk, new DateTime(DateTime.Today.Year, 05, 12), new DateTime(DateTime.Today.Year, 05, 15))
        {}

        public TimeSpan Vluchtduur()
        {
            TimeSpan tijdAankomst = new TimeSpan(this.DatumAankomst.Hour, this.DatumAankomst.Minute, this.DatumAankomst.Second);
            TimeSpan tijdVertrek = new TimeSpan(this.DatumVertrek.Hour, this.DatumVertrek.Minute, this.DatumVertrek.Second);
            TimeSpan vluchtduur = tijdAankomst - tijdVertrek;
            return vluchtduur;
        }

        public bool AddPerson(Persoon persoon)
        {
            if (persoon != null)
            {
                this.Persoon.Add(persoon);
                return true;
            }

            return false;
        }

        public bool RemovePerson(Persoon persoon)
        {
            if (persoon != null)
            {
                this.Persoon.Remove(persoon);
                return true;
            }

            return false;
        }

        public Persoon ZoekPersoon(string voorNaam)
        {
            for (int i = 0; i < this.Persoon.Count; i++)
            {
                if (voorNaam == this.Persoon[i].Voornaam)
                {
                    return this.Persoon[i];
                }
            }
            return null;
        }

        public override string ToString()
        {
            string personen = "\nPersonen: ";
            foreach(Persoon persoon in this.Persoon)
            {
                personen = personen + persoon;
            }
            return "Vlucht: " + this.Vluchtnummer + "\nVliegt van " + this.PlaatsVertrek + " naar " + this.PlaatsBestemming + "\nVluchtduur: " + Vluchtduur() + personen;
        }

    }
}
