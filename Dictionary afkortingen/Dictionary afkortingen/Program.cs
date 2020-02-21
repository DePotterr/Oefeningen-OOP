using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_afkortingen
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("vnv", "vanavond");
            dictionary.Add("sws", "sowieso");
            dictionary.Add("hzo", "hoezo");
            dictionary.Add("slpwl", "slaapwel");
            Console.WriteLine(dictionary["vnv"]);

            foreach(KeyValuePair<string,string> pair in dictionary)
            {
                Console.WriteLine("Afkorting: {0}, betekenis: {1}", pair.Key, pair.Value);
            }
        }
    }
}
