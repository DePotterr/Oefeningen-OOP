using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Undo_actie
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> letters = new List<string>();
            string letter = "";
            string tempory;
            do
            {
                tempory = Console.ReadLine();
                if(tempory != "")
                {
                    letter = tempory;
                }

                if (letter != "Z" && letter.Length > 0 && letter.Length < 2)
                {
                    letters.Add(letter);
                }

                else if (letter.Length > 0 && letter.Length < 2)
                {
                    letters.RemoveAt(letters.Count - 1);
                }
                Console.WriteLine();
                Console.WriteLine("Letters in lijst: "); 
                for (int i = 0; i < letters.Count; i++)
                {
                    Console.WriteLine(letters[i]);
                }
                Console.WriteLine();
            } while (letters.Count > 0);
        }
    }
}
