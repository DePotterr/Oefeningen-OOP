using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankSysteem.Exceptions;
using BankSysteem.Klassen;

namespace BankSysteem.Klassen
{
    class Lening
    {
        public double BedragPerMaand { get; set; }
        public Lening(double bedragPerMaand)
        {
            BedragPerMaand = bedragPerMaand;
        }
        public override string ToString()
        {
            return BedragPerMaand.ToString();
        }
    }
}
