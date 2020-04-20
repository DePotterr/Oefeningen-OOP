using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herhalingsoef_met_GUI
{
    class DementeRusthuisBewoner : Rusthuisbewoner
    {
        public DementeRusthuisBewoner(string voornaam, string naam) : base(voornaam, naam, Verdiepen.Verdiep4)
        {

        }

        public override bool CheckVerdiep(Verdiepen verdiep)
        {
            bool result = true;
            if(verdiep != Verdiepen.Verdiep4)
            {
                result = false;
            }
            return result;
        }
        public override string ToevoegenActiviteit(Activiteit activiteit)
        {
            bool toegelaten = true;
            if (activiteit.Soort != Activiteit.Soorten.Handwerk)
            {
                toegelaten = false;
            }
            if (toegelaten)
            {
                return base.ToevoegenActiviteit(activiteit);
            }
            else
            {
                return "Demente bewoner mag enkel handwerk selecteren"; //throw new Exception...
            }
        }
        public override string ToString()
        {
            return "D-" + base.ToString();
        }
    }
}
