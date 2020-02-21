using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime vertrek = new DateTime(2020, 05, 20, 6, 30, 0);
            DateTime aankomst = new DateTime(2020, 05, 20, 7, 15, 0);
            Vlucht vlucht = new Vlucht(Vlucht.PlaatsenVertrek.België, Vlucht.Bestemmingen.Duitsland, vertrek, aankomst);
            Console.WriteLine(vlucht);
            Vlucht vlucht1 = new Vlucht();
            Console.WriteLine(vlucht1);
        }
    }
}
