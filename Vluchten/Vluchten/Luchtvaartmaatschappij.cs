using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vluchten
{
    class Luchtvaartmaatschappij
    {
        public Dictionary<int,Vlucht> Vluchten { get; set; }

        public void AddVlucht(Vlucht vlucht)
        {
            this.Vluchten.Add(vlucht.Vluchtnummer, vlucht);
        }
        public void RemoveVlucht(Vlucht vlucht)
        {
            this.Vluchten.Remove(vlucht.Vluchtnummer);
        }

        public override string ToString()
        {
            string allevluchten = "";
            for (int i = 0; i < this.Vluchten.Count; i++)
            {
                allevluchten = allevluchten + "\nVlucht: " + this.Vluchten[i];
            }
            return "alle vluchten: " + allevluchten;
        }
    }
}
