using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dieren
{
    class Program
    {
        static void Main(string[] args)
        {
            Dier dier = new Hond("Jef", 50, 2018, Hond.SoortenOren.Korte);
            Console.WriteLine(dier);

            Dier dier1 = new Kat("iets", 60, 2019, Kat.SoortenVacht.Korte_vacht);
            Console.WriteLine(dier1);

            Dier dier2 = new Dier("een dier", 10, 2020);
            Console.WriteLine(dier2);

            Console.WriteLine(dier.BerekenLeeftijd());
            Console.WriteLine(dier1.BerekenLeeftijd());
            Console.WriteLine(dier2.BerekenLeeftijd());
        }
    }
}
