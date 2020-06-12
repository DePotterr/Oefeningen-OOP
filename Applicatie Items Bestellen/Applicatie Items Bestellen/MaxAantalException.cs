using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicatie_Items_Bestellen
{
    class MaxAantalException : Exception
    {
        public MaxAantalException() : base("Je kan maar maximaal 10 producten per item bestellen.")
        {

        }
    }
}
