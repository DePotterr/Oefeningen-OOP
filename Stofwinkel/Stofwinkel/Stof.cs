using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stofwinkel
{
    enum Kwaliteitlabels { A, B, C }
    class Stof
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
            return $"Naam: {this.Naam} Designlabel: {this.DesignLabel} Prijs per meter: {this.PrijsPerMeter} Krimp%: {this.KrimpPercentage} Kwaliteitslabel: {this.Kwaliteitlabel}";
        }
    }
}
