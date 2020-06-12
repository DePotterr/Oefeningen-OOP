using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_school_meldingen
{
    class Medewerker
    {
        const int MAX_AANTAL_MELDINGEN = 7;
        private List<Melding> meldingen;
        readonly string rijkregisternummer;
        public string Naam { get; set; }
        public List<Melding> Meldingen
        {
            get { return meldingen; }
            set
            {
                if (CheckAantalMeldingen(value))
                {
                    meldingen = value;
                }
                else
                {
                    throw new Exception("Er is iets foutgegaan.");
                }
            }
        }

        public Medewerker(string naam, string rijkregisternummer)
        {
            Naam = naam;
            this.rijkregisternummer = rijkregisternummer;
            Meldingen = new List<Melding>();
        }
        public void MeldingToevoegen(Melding melding)
        {
            if (CheckAantalMeldingen())
            {
                try
                {
                    Meldingen.Add(melding);
                }
                catch (DatumInHetVerledenException ex)
                {
                    throw ex;
                }
            }
            else
            {
                throw new Exception("Er is iets foutgegaan.");
            }
        }
        public bool CheckAantalMeldingen(List<Melding> meldingen)
        {
            if (meldingen.Count > MAX_AANTAL_MELDINGEN - 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool CheckAantalMeldingen()
        {
            return CheckAantalMeldingen(this.Meldingen);
        }
        public override string ToString()
        {
            return Naam;
        }
    }
}
