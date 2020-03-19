using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank Fortis = new Bank("Fortis", "bijlstraat", 45, "9120", "Beveren");
            Console.WriteLine(Fortis);
        }
    }
}
