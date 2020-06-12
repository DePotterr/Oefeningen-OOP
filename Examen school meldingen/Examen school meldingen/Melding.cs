using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_school_meldingen
{
    enum Statussen { Open, Gesloten}
    abstract class Melding : IComparable
    {
        private static int meldingID = 0;
        public string Titel { get; set; }
        public string Beschrijving { get; set; }
        public int MeldingID { get; set; }
        public Statussen Status { get; set; }

        protected Melding(string titel, string beschrijving)
        {
            Titel = titel;
            Beschrijving = beschrijving;
            Status = Statussen.Open;
            MeldingID = ++meldingID;
        }

        abstract public int BerekenSpoed();
        virtual public string ToonInfo()
        {
            return $"{MeldingID}:{Titel}" + Environment.NewLine + $"Status:{Status}" + Environment.NewLine + Beschrijving;
        }
        public override string ToString()
        {
            return MeldingID.ToString();
        }

        public int CompareTo(object obj)
        {
            if(obj == null)
            {
                return 1;
            }
            Melding melding = obj as Melding;
            if(melding == null)
            {
                return 1;
            }
            if(melding.BerekenSpoed() > this.BerekenSpoed())
            {
                return -1;
            }
            else if (melding.BerekenSpoed() < this.BerekenSpoed())
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
