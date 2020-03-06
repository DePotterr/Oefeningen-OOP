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
            //List<string> letters = new List<string>();
            char letter;
            Stack<char> letters = new Stack<char>();
            while (true)
            {
                try
                {
                    // LIST
                    //Console.Write("Voer een letter in: ");
                    //letter = Console.ReadLine();
                    //if (letter.Length > 0 && letter.Length < 2)
                    //{
                    //    if(letter != "Z" && letter != null && letter != " ")
                    //    {
                    //        letters.Add(letter);
                    //    }
                    //    else if(letter == "Z")
                    //    {
                    //        letters.RemoveAt(letters.Count() - 1);
                    //    }
                    //}
                    //Console.WriteLine();
                    //Console.WriteLine("Letters in lijst: ");
                    //for (int i = 0; i < letters.Count; i++)
                    //{
                    //    Console.WriteLine(letters[i]);
                    //}
                    //Console.WriteLine();

                    Console.Write("Voer een letter in: ");
                    letter = char.Parse(Console.ReadLine());
                    if (char.IsLetter(letter) && letter != 'Z')
                    {
                        letters.Push(letter);
                    }
                    else if (letter == 'Z')
                    {
                        letters.Pop();
                    }
                    Console.WriteLine(letters.Peek());
                }
                catch(InvalidOperationException)
                {
                    Console.WriteLine("Stack is leeg.");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Gelieve een letter in te geven.");
                }
                //catch (ArgumentOutOfRangeException)
                //{
                //    //    Console.WriteLine("\nGeen undo meer mogelijk!\n");
                //}
                catch (Exception)
                {
                    Console.WriteLine("\nEr is iets misgegaan!\n");
                }
            }

        }
    }
}
