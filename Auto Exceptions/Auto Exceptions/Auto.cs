﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_Exceptions
{
    class Auto
    {
        public const int AANTAL_KILOMETERS_ELK_JAAR = 20000;
        public string Merk { get; set; }
        public string Type { get; set; }
        public string Nummerplaat { get; set; }
        public int AantalKilometers { get; set; }
        public DateTime Ingebruikname { get; set; }

        public Auto(string merk, string type, string nummerplaat, int aantalkilometers, DateTime ingebruikname)
        {
            this.Merk = merk;
            this.Type = type;
            this.Nummerplaat = nummerplaat;
            this.AantalKilometers = aantalkilometers;
            this.Ingebruikname = ingebruikname;
        }

        public Auto() : this("ONBEKEND", "ONBEKEND", "1-AAA-000", 0, DateTime.Today)
        {}

        public int BerekenAantalKilometers(int aantalJaar)
        {
            this.AantalKilometers = this.AantalKilometers + (aantalJaar * AANTAL_KILOMETERS_ELK_JAAR);
            return this.AantalKilometers;
        }

        public int BerekenAantalKilometers()
        {
            return BerekenAantalKilometers(10);
        }

        public override string ToString()
        {
            return "De auto(" + this.Nummerplaat + ")heeft " + this.AantalKilometers + " kilometers.";
        }
    }
}
