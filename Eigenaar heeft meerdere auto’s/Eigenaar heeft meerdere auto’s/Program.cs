using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eigenaar_heeft_meerdere_auto_s
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto auto = new Auto();
            Auto auto1 = new Auto();
            Console.WriteLine(auto);
            Console.WriteLine("---------------------------------------------------------");
            Persoon persoon = new Persoon("Robin", "de Potter");
            Console.WriteLine(persoon);
            Console.WriteLine("---------------------------------------------------------");
            persoon.AutoToevoegen(auto);
            Console.WriteLine(persoon);
            Console.WriteLine("---------------------------------------------------------");
            auto.BerekenAantalKilometers(1);
            Console.WriteLine(persoon);
            Console.WriteLine("---------------------------------------------------------");
            persoon.AutoToevoegen(auto1);
            Console.WriteLine(persoon);
            Console.WriteLine("---------------------------------------------------------");
            persoon.AutoVerwijderen(auto);
            Console.WriteLine(persoon);
            Console.WriteLine("---------------------------------------------------------");
            persoon.AutoToevoegen(auto);
            Console.WriteLine(persoon);
        }
    }
}
