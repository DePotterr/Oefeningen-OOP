using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDB
{
    class Program
    {
        static private void WriteException(Exception e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(e.Message);
            Console.ResetColor();
        }
        static void Main(string[] args)
        {
            Film avengers = new Film("Avengers", "?", "?", Film.Gernes.Action);
            
            try
            {
                
                Console.WriteLine(avengers);
                
                
            }
            catch (Exception e)
            {
                WriteException(e);
            }
            avengers.AddRating(1);
            try
            {
                Console.WriteLine(avengers);
            }
            catch (Exception e)
            {
                WriteException(e);
            }
            
        }
    }
}
