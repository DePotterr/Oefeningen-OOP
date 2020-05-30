using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herhalingsoef_2
{
    class AdministratiefPersoneel : Personeel
    {
        public AdministratiefPersoneel(string voornaam, string naam, DateTime startDatum, List<Vakantie> vakantiePeriodes, bool isBenoemd) : base(voornaam, naam, startDatum, vakantiePeriodes, isBenoemd)
        {

        }
        public AdministratiefPersoneel(string voornaam, string naam, DateTime startDatum, bool isBenoemd) : base(voornaam, naam, startDatum, isBenoemd)
        {

        }
        public override void VakantieNemen(Vakantie vakantie)
        {
            if(vakantie != null)
            {
                base.VakantiePeriodes.Add(vakantie);
            }
        }
        public override string ToString()
        {
            return "AT " + base.ToString();
        }
    }
}
