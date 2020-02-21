using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefAuto
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto auto = new Auto();
            Console.WriteLine(auto);
            Auto auto1 = new Auto("Toyato","Yaris","5-AKF-785",16000);
            Console.WriteLine(auto1);
            auto1.BerekenAantalKilometers(1);
            Console.WriteLine(auto1);
            auto1.BerekenAantalKilometers(1);
            Console.WriteLine(auto1);
        }
    }
}
