using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto auto = null;
            do
            {
                string merk;
                string type;
                string nummerplaat;
                int aantalKilometer;
                DateTime dateTime;
                try
                {
                    Console.WriteLine("Voer merk in.");
                    merk = Console.ReadLine();
                    Console.WriteLine("Voer type in.");
                    type = Console.ReadLine();
                    Console.WriteLine("Voer nummerplaat in");
                    nummerplaat = Console.ReadLine();
                    Console.WriteLine("Voer aantalkm in.");
                    aantalKilometer = int.Parse(Console.ReadLine());
                    Console.WriteLine("Voer ingebruikname in.");
                    dateTime = DateTime.Parse(Console.ReadLine());
                    auto = new Auto(merk, type, nummerplaat, aantalKilometer, dateTime);
                    Console.WriteLine(auto);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Zorg ervoor dat je het juiste formaat ingeeft");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (auto == null);

            Console.ReadKey();
        }
    }
}
