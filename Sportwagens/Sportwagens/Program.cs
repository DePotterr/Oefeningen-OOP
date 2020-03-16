using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sportwagens
{
    class Program
    {
        static void Main(string[] args)
        {
            Sportwagen sportwagen = new Sportwagen(Wagen.Merken.BMW, Wagen.Types.GT, 0, DateTime.Today.AddYears(-8), "a1z1e2", 190, 6);
            Console.WriteLine(sportwagen);
            double resultaat = sportwagen.BerekenBrandstofverbruik(5);
            Console.WriteLine(resultaat);
        }
    }
}
