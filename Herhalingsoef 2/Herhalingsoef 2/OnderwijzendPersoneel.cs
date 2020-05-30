using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herhalingsoef_2
{
    class OnderwijzendPersoneel : Personeel
    {
        public OnderwijzendPersoneel(string voornaam, string naam, DateTime startDatum, bool isBenoemd) : base(voornaam, naam, startDatum, isBenoemd)
        {
            VakantiePeriodes = VakantiePeriode();
        }
        public override void VakantieNemen(Vakantie vakantie)
        {
            throw new Exception("Onderwijzend personeel kan geen vakantie nemen.");
        }
        private List<Vakantie> VakantiePeriode()
        {
            List<Vakantie> vakantieperiodes = new List<Vakantie>();
            DateTime beginZomer = new DateTime(2020, 07, 01);
            DateTime eindZomer = new DateTime(2020, 08, 31);
            vakantieperiodes.Add(new Vakantie(beginZomer, eindZomer));
            return vakantieperiodes;
        }
        public override string ToString()
        {
            return "OP " +base.ToString();
        }
    }
}
