using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_school_meldingen
{
    class DatumInHetVerledenException : Exception
    {
        public DateTime DatumInHetVerleden { get; set; }
        public int AantalDagen { get; set; }
        public DatumInHetVerledenException(DateTime datum, int aantalDagen) : base(datum.ToShortDateString() + " ligt " + aantalDagen + " dagen in het verleden!")
        {
            DatumInHetVerleden = datum;
            AantalDagen = aantalDagen;
        }
    }
}
