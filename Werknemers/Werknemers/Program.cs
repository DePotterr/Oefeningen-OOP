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
            Werknemer w = new Werknemer(p,2,Werknemer.Prestaties.Voldoende);
            Departement d = new Departement();
            d.ListEmployees.Add(w);
            d.ListEmployees.Add(w);
            Console.WriteLine(w);
            Console.WriteLine();
            Console.WriteLine(w.CalculateSalary());
            Console.WriteLine();
            Console.WriteLine(d.CalculateSalaries());
            Console.WriteLine(d);
        }
    }
}
