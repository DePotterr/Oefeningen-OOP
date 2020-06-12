using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_school_meldingen
{
    enum Prioriteitlagen { Laag, Normaal, Hoog, Kritiek}
    class Defect : Melding
    {
        public Prioriteitlagen Prioriteitlaag { get; set; }
        public Defect(string titel, string beschrijving, Prioriteitlagen prioriteitlaag) : base(titel, beschrijving)
        {
            Prioriteitlaag = prioriteitlaag;
        }
        public override string ToonInfo()
        {
            return base.ToonInfo() + Environment.NewLine + Prioriteitlaag;
        }
        public override int BerekenSpoed()
        {
            int resultaat = 0;
            switch (Prioriteitlaag)
            {
                case Prioriteitlagen.Laag:
                    resultaat = 4;
                    break;
                case Prioriteitlagen.Normaal:
                    resultaat = 3;
                    break;
                case Prioriteitlagen.Hoog:
                    resultaat = 2;
                    break;
                case Prioriteitlagen.Kritiek:
                    resultaat = 1;
                    break;
                default:
                    break;
            }
            return resultaat;
        }
        public override string ToString()
        {
            return base.ToString() + " DEF " + Prioriteitlaag;
        }
    }
}
