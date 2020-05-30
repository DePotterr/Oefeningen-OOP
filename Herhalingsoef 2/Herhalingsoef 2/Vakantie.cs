using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herhalingsoef_2
{
    class Vakantie
    {
        public DateTime BeginDatum { get; set; }
        public DateTime EindDatum { get; set; }
        public Vakantie(DateTime beginDatum, DateTime eindDatum)
        {
            BeginDatum = beginDatum;
            EindDatum = eindDatum;
        }
        public override string ToString()
        {
            return BeginDatum.ToShortDateString() + " - " + EindDatum.ToShortDateString();
        }
    }
}
