using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herhalingsoef_1
{
    public enum Faciliteiten { Extra_examentijd, Digitaal_examen }
    class FaciliteitStudet : Student
    {
        public Faciliteiten Faciliteit { get; set; }
        public FaciliteitStudet(string voornaam, string naam, string adres, Geslachten geslacht, Faciliteiten faciliteit) : base(voornaam, naam, adres, geslacht)
        {
            Faciliteit = faciliteit;
        }
        public override string ToString()
        {
            return "F" + base.ToString();
        }
    }
}
