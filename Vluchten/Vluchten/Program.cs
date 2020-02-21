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
            List<Vlucht> vlucht = new List<Vlucht>();
            vlucht.Add(new Vlucht("B", "f"));
            Console.WriteLine(vlucht[0]);
            vlucht.Remove(vlucht[0]);
            vlucht.Add(new Vlucht("B", "f"));
            Console.WriteLine(vlucht[0]);
        }
    }
}
