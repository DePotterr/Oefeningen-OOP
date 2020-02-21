using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vluchten
{
    class Program
    {
        static void Main(string[] args)
        {
            Vlucht vlucht = new Vlucht("Brussel", "Dublin");
            Vlucht vlucht1 = new Vlucht("Antwerpen", "Dublin");
            Luchtvaartmaatschappij luchtvaartmaatschappij = new Luchtvaartmaatschappij("Brussels Airlines");
            luchtvaartmaatschappij.AddVlucht(vlucht);
            Console.WriteLine(luchtvaartmaatschappij);
            luchtvaartmaatschappij.AddVlucht(vlucht1);
            Console.WriteLine(luchtvaartmaatschappij);

        }
    }
}
