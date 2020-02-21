using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Vlucht
    {
        public enum Bestemmingen { Frankrijk, Engeland, Duitsland };
        public enum PlaatsenVertrek { België };
        static private int teller = 1;
        public int Vluchtnummer { get; set; }

        public Bestemmingen PlaatsBestemming { get; set; }
        public PlaatsenVertrek PlaatsVertrek { get; set; }
        public DateTime DatumVertrek { get; set; }
        public DateTime DatumAankomst { get; set; }

        public Vlucht(PlaatsenVertrek plaatsVertrek, Bestemmingen plaatsBestemming, DateTime datumVertrek, DateTime datumAankomst)
        {
            this.Vluchtnummer = teller++;
            this.PlaatsVertrek = plaatsVertrek;
            this.PlaatsBestemming = plaatsBestemming;
            this.DatumVertrek = datumVertrek;
            this.DatumAankomst = datumAankomst;
        }

        public Vlucht() : this(PlaatsenVertrek.België, Bestemmingen.Frankrijk, new DateTime(DateTime.Today.Year, 05, 12), new DateTime(DateTime.Today.Year, 05, 15))
        { }

        public TimeSpan Vluchtduur()
        {
            TimeSpan tijdAankomst = new TimeSpan(this.DatumAankomst.Hour, this.DatumAankomst.Minute, this.DatumAankomst.Second);
            TimeSpan tijdVertrek = new TimeSpan(this.DatumVertrek.Hour, this.DatumVertrek.Minute, this.DatumVertrek.Second);
            TimeSpan vluchtduur = tijdAankomst - tijdVertrek;
            return vluchtduur;
        }

        public override string ToString()
        {
            return "Vlucht: " + this.Vluchtnummer + "\n\tVliegt van " + this.PlaatsVertrek + " naar " + this.PlaatsBestemming + "\n\tVluchtduur: " + Vluchtduur();
        }

    }
}
