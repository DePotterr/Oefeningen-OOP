using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicatie_Items_Bestellen
{
    class Boek : Item
    {
        const double EXTRAKOSTENPAGINAS = 0.10;
        public string Acteur { get; set; }
        public int AantalPaginas { get; set; }
        public Boek(string titel, double prijsPerStuk, int aantal, string acteur, int aantalPaginas) : base(titel, prijsPerStuk, aantal)
        {
            Acteur = acteur;
            AantalPaginas = aantalPaginas;
        }
        public override double ExtraKostenBerekenen()
        {
            double extraKosten = 0;
            if(this.AantalPaginas > 500)
            {
                extraKosten = (base.PrijsPerStuk * base.Aantal) * EXTRAKOSTENPAGINAS;
            }
            return extraKosten;
        }
        public override string ToString()
        {
            return base.ToString() + $" - {AantalPaginas}";
        }
    }
}
