using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herhalingsoef_1
{
    class CustumExceptionStudentNaam : Exception
    {
        public CustumExceptionStudentNaam() : base("ERROR[" + DateTime.Now.ToLocalTime() + "] : De student die je probeerde aan te maken heeft speciale karakters in naam of voornaam. Pas aan en probeer opnieuw.")
        {
        }
    }
}
