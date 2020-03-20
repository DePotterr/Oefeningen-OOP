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

            Klant klant = new Klant("Robin de Potter", "Glazenleeuwstraat", 44, "9120", "Beveren");
            Fortis.Klanten.Add(klant);

            Klant klant1 = new Klant("test", "Glazenleeuwstraat", 44, "blablabla", "Beveren");
            Fortis.Klanten.Add(klant1);

            Spaarrekening spaarrekening = new Spaarrekening(500, DateTime.Today.AddYears(-5), 123456789);
            klant.Spaarrekeningen.Add(spaarrekening);

            Beleggingsrekening beleggingsrekening = new Beleggingsrekening(10000, DateTime.Today.AddMonths(-11), 99999, DateTime.Today.AddYears(1));
            klant.Beleggingsrekeningen.Add(beleggingsrekening);
            Console.WriteLine(Fortis);
        }
    }
}
