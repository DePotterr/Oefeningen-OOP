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
            Luchtvaartmaatschappij luchtvaartmaatschappij = new Luchtvaartmaatschappij();
        }
    }
}
