using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDB
{
    class Program
    {
        static void Main(string[] args)
        {
            Film Avengers = new Film("Avengers", "?", "?", Film.Gernes.Action);
            Console.WriteLine(Avengers);
            Avengers.AddRating(2);
            Console.WriteLine(Avengers);
            Serie HIMYM = new Serie("How I met your mother", 9);
            Console.WriteLine(HIMYM);
            KeyValuePair<int,string> keyValuePair = new KeyValuePair<int, string>(1,"a");
            Console.WriteLine(keyValuePair);
        }
    }
}
