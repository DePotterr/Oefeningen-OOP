using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vlucht_met_passagiers
{
    class Program
    {
        static void Main(string[] args)
        {
            Persoon persoon = new Persoon("Robin", "de Potter");
            Persoon persoon1 = new Persoon("Talitha", "Smet");
            Vlucht vlucht = new Vlucht();

            vlucht.AddPerson(persoon);
            Console.WriteLine(vlucht);
            vlucht.AddPerson(persoon1);
            Console.WriteLine(vlucht);

            Persoon gevondenpersoon = vlucht.ZoekPersoon("Robin");

            Console.WriteLine(gevondenpersoon);
        }
    }
}
