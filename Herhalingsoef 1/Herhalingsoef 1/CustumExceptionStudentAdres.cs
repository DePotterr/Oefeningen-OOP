using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herhalingsoef_1
{
    class CustumExceptionStudentAdres : Exception
    {
        public CustumExceptionStudentAdres() : base("ERROR[" + DateTime.Now.ToLocalTime() + "] : De student die je probeerde aan te maken heeft speciale karakters in het adres. Pas aan en probeer opnieuw.")
        {
        }
    }
}
