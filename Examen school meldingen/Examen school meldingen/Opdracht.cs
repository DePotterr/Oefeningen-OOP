using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_school_meldingen
{
    class Opdracht : Melding
    {
        const int KRITIEK = 1;
        const int HOOG = 2;
        const int NORMAAL = 3;
        const int LAAG = 4;
        private DateTime datumDeadline;
        public DateTime DatumDeadline
        {
            get { return datumDeadline; }
            set
            {
                if(value < DateTime.Today)
                {
                    throw new DatumInHetVerledenException(value, BerekenAantalDagenInHetVerleden(value));
                }
                else if(value == DateTime.Today)
                {
                    datumDeadline = DateTime.Today.AddDays(7);
                }
                else
                {
                    datumDeadline = value;
                }
            }
        }

        public Opdracht(string titel, string beschrijving, DateTime datumDeadline) : base(titel, beschrijving)
        {
            try
            {
                DatumDeadline = datumDeadline;
            }
            catch (DatumInHetVerledenException ex)
            {
                throw ex;
            }
        }
        public override int BerekenSpoed()
        {
            int aantalDagen = BerekenDagenTotDeadline(DatumDeadline);
            if (aantalDagen >= 7)
            {
                return LAAG;
            }
            else if(aantalDagen > 3)
            {
                return NORMAAL;
            }
            else if(aantalDagen <= 3)
            {
                return HOOG;
            }
            else
            {
                return KRITIEK;
            }
        }
        public int BerekenAantalDagenInHetVerleden(DateTime datumVerleden)
        {
            return (DateTime.Today - datumVerleden).Days;
        }
        public int BerekenDagenTotDeadline(DateTime datumDeadline)
        {
            return (datumDeadline - DateTime.Today).Days;
        }
        public override string ToonInfo()
        {
            return base.ToonInfo() + Environment.NewLine + DatumDeadline.ToShortDateString();
        }
        public override string ToString()
        {
            return base.ToString() + $" OPD {DatumDeadline.ToShortDateString()}";
        }
    }
}
