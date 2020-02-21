using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefPersoon
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime geboortedatum = new DateTime(2001, 09, 27);
            Persoon persoon = new Persoon("Robin", "de Potter", geboortedatum, Persoon.Geslachten.Man);
            Console.WriteLine(persoon);
        }
    }
}
