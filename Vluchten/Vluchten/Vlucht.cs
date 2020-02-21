using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vluchten
{
    class Vlucht
    {
        private static int teller = 1;
        public string Vertrek { get; set; }
        public string Bestemming { get; set; }
        public int Teller { get; set; }
        public Vlucht(string vertrek, string bestemming)
        {
            this.Teller = teller++;
            this.Vertrek = vertrek;
            this.Bestemming = bestemming;
        }
        public override string ToString()
        {
            return this.Teller + "| Vertrek: " + this.Vertrek + " Bestemming: " + this.Bestemming;
        }
    }
}
