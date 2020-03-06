using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Werknemers
{
    class Program
    {
        static void Main(string[] args)
        {
            Persoon p = new Persoon("r", "d");
            Werknemer w = new Werknemer(p);
            Console.WriteLine(w);
        }
    }
}
