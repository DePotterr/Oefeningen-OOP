using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankSysteem.Exceptions;
using BankSysteem.Klassen;

namespace BankSysteem.Klassen
{
    class Klant : IComparable
    {
        readonly double salaris;
        private string telefoonnummer;
        public string Naam { get; set; }
        public string Adres { get; set; }
        public string Telefoonnummer
        {
            get { return telefoonnummer; }
            set
            {
                if(value == null)
                {
                    telefoonnummer = "0000/000-000";
                }
                else
                {
                    telefoonnummer = value;
                }
            }
        }
        public bool KredietWaardig { get; set; }
        public List<Lening> Leningen { get; set; }

        public Klant(string naam, string adres, string telefoonnumer, bool kredietWaardig, double salaris)
        {
            Naam = naam;
            Adres = adres;
            Telefoonnummer = telefoonnumer;
            KredietWaardig = kredietWaardig;
            this.salaris = salaris;
            Leningen = new List<Lening>();
        }
        public Klant(string naam, string adres, bool kredietWaardig, double salaris) : this(naam, adres, null ,kredietWaardig, salaris)
        {
        }
        public double CheckSalaris()
        {
            return this.salaris;
        }
        public virtual double MaxAfbetalingsBedrag()
        {
            if (this.KredietWaardig)
            {
                return CheckSalaris() / 3;
            }
            else
            {
                throw new KredietWaardigException(this);
            }
        }
        public override string ToString()
        {
            return $"{Naam} ({CheckSalaris()})";
        }

        public int CompareTo(object obj)
        {
            if(obj == null)
            {
                return 1;
            }
            Klant klant = (Klant)obj;
            if(klant == null)
            {
                return 1;
            }
            if(this.salaris > klant.CheckSalaris())
            {
                return -1;
            }
            else if(this.salaris < klant.CheckSalaris())
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
