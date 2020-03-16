using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dieren
{
    class Hond : Dier
    {
        private const string GELUID_HOND = "Woef woef";
        public enum SoortenOren { Lange, Korte}
        public SoortenOren SoortOor { get; set; }

        public Hond(string voornaam, int gewicht, int geboorteJaar, SoortenOren soortOor) : base(voornaam, gewicht, geboorteJaar)
        {
            this.SoortOor = soortOor;
            base.Geluid = GELUID_HOND;
        }

        //public override int BerekenLeeftijd()
        //{
        //    int reslutaat = base.BerekenLeeftijd();

        //    return reslutaat = reslutaat + 2;
        //}

        public override string ToString()
        {
            return "Hond: " + base.ToString() + "\n\tSoort oor: " + this.SoortOor;
        }
    }
}
