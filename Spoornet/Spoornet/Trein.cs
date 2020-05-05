﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spoornet
{
    enum Bestemmingen { Brussel_zuid, Antwerpen_centraal, Mechelen}
    class Trein
    {
        private static int nummer;
        public int Nummer { get; set; }
        public string Naam { get; set; }
        public Bestemmingen Bestemming { get; set; }
        public DateTime Tijdstip { get; set; }
        public List<Passagier> Passagiers { get; set; }
        public Trein(string naam, Bestemmingen bestemming, DateTime tijdstip)
        {
            Nummer = ++nummer;
            Naam = naam;
            Bestemming = bestemming;
            Tijdstip = tijdstip;
            Passagiers = new List<Passagier>();
        }
        public string ZoekKLassePassagier(string rijkregisternummer)
        {
            string str = "Kon passagier niet vinden met dit rijkregisternummer.";
            for (int i = 0; i < Passagiers.Count; i++)
            {
                if(Passagiers[i].Rijkregisternummer == rijkregisternummer)
                {
                    str = Passagiers[i].Klasse.ToString();
                }
            }
            return str;
        }
        public virtual void Vertraging(double minuten)
        {
            Tijdstip.AddMinutes(-minuten);
        }
        public override string ToString()
        {
            return Nummer + " " + Naam + " Bestemming: " + Bestemming + " om: " + Tijdstip;
        }
    }
}
