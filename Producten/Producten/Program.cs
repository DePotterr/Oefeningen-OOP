using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Producten
{
    class Program
    {
        static void Main(string[] args)
        {
            Food product = new Food("nice","nice",500.20,DateTime.Today,1,5);
            Console.WriteLine(product);

            Non_Food non = new Non_Food("nice", "nice", 500.20, DateTime.Today, true, true);
            Console.WriteLine(non);
        }
    }
}
