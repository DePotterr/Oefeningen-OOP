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
            Festivalganger festivalganger = new Festivalganger(DateTime.Today, "Beveren", "OLF Beveren", "Robin", "de Potter", "Beveren", Artiest.StijlenMuziek.Dance, 18, false);
            Console.WriteLine(festivalganger);
        }
    }
}
