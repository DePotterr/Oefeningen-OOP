using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Festival
{
    class Program
    {
        static void Main(string[] args)
        {
            Evenement evenement = new Evenement(DateTime.Today.AddDays(5),"Beveren","OLF BEVEREN", 500);
            Festivalganger festivalganger = new Festivalganger("Robin", "de Potter", "Beveren",18, false, evenement);
            Console.WriteLine(festivalganger);
        }
    }
}
