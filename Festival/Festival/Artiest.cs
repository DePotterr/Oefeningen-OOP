using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Festival
{
    class Artiest : Persoon
    {
        public enum StijlenMuziek { RNB, Dance, Rock, DNB}

        public StijlenMuziek StijlMuziek { get; set; }

        public Artiest(string voornaam, string achternaam, StijlenMuziek stijlMuziek) : base(voornaam, achternaam)
        {
            StijlMuziek = stijlMuziek;
        }

        public override string ToString()
        {
            return base.ToString() + "\nStijl muziek: " + this.StijlMuziek;
        }
    }
}
