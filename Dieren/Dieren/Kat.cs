using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dieren
{
    class Kat : Dier
    {
        private const string GELUID_KAT = "Maiw miauw";
        public enum SoortenVacht { Korte_vacht, Lange_vacht}
        public SoortenVacht SoortVacht { get; set; }

        public Kat(string voornaam, int gewicht, int geboorteJaar, SoortenVacht soortVacht) : base(voornaam, gewicht, geboorteJaar)
        {
            this.SoortVacht = soortVacht;
            this.Geluid = GELUID_KAT;
        }

        public override string ToString()
        {
            return "Kat: " + base.ToString() + "\n\tSoort vacht: " + this.SoortVacht;
        }
    }
}
