using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
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

            DateTime geboortedatum = new DateTime(2001, 09, 27);
            Persoon persoon = new Persoon("Robin", "de Potter", geboortedatum, Persoon.Geslachten.Man, vlucht1);
            Console.WriteLine(persoon);

            Auto auto = new Auto();
            Console.WriteLine(auto);
            Auto auto1 = new Auto("Toyato", "Yaris", "5-AKF-785", 16000);
            Console.WriteLine(auto1);
            auto1.BerekenAantalKilometers(1);
            Console.WriteLine(auto1);
            auto1.BerekenAantalKilometers(1);
            Console.WriteLine(auto1);

            Console.WriteLine();
            DateTime geboortedatumtalitha = new DateTime(2002, 03, 28);
            Persoon Talitha = new Persoon("Talitha", "Smet", geboortedatumtalitha, Persoon.Geslachten.Vrouw, vlucht);
            Dog dog = new Dog("Maurice", Talitha);
            Console.WriteLine(dog);
        }
    }
}
