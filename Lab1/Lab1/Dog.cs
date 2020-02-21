using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Dog
    {
        public string Naam { get; set; }
        public Persoon Owner { get; set; }

        public Dog(string naam, Persoon owner)
        {
            this.Naam = naam;
            this.Owner = owner;
        }

        public override string ToString()
        {
            return "Naam: " + Naam + "\n\t" + Owner;
        }
    }
}
