using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stofwinkel
{
    public enum Kwaliteitlabels { A, B, C }
    public abstract class Stof : IComparable
    {
        public string Naam { get; set; }
        public string DesignLabel { get; set; }
        public double PrijsPerMeter { get; set; }
        public double KrimpPercentage { get; set; }
        public Kwaliteitlabels Kwaliteitlabel { get; set; }
        public string Ticket { get; set; }

        public Stof(string naam, string designLabel, double prijsPerMeter, double krimpPercentage, Kwaliteitlabels kwaliteitlabel)
        {
            Ticket = $"{naam} {designLabel} {prijsPerMeter}";
            Naam = naam;
            DesignLabel = designLabel;
            PrijsPerMeter = prijsPerMeter;
            KrimpPercentage = krimpPercentage;
            Kwaliteitlabel = kwaliteitlabel;
        }
        public Stof(string naam, string designLabel, double prijsPerMeter, double krimpPercentage) : this(naam, designLabel, prijsPerMeter, krimpPercentage, Kwaliteitlabels.A)
        {
        }
        public Stof(string naam, string designLabel, double prijsPerMeter, Kwaliteitlabels kwaliteitlabel) : this(naam, designLabel, prijsPerMeter, 0, kwaliteitlabel)
        {
        }
        public Stof(string naam, string designLabel, double prijsPerMeter) : this(naam, designLabel, prijsPerMeter, 0, Kwaliteitlabels.A)
        {
        }
        public override string ToString()
        {
            return $"{this.Naam} {this.DesignLabel} prijs = {PrijsPerMeter}";
        }

        public int CompareTo(object obj)
        {
            if(obj == null)
            {
                return 1;
            }
            Stof stof = obj as Stof;
            if(stof == null)
            {
                return 1;
            }
            if (stof.PrijsPerMeter > this.PrijsPerMeter)
                return 1;
            else if (stof.PrijsPerMeter < this.PrijsPerMeter)
                return -1;
            else
            {
                if(stof.Naam.CompareTo(this.Naam) == 1)
                {
                    return -1;
                }
                else if(stof.Naam.CompareTo(this.Naam) == -1)
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
}
