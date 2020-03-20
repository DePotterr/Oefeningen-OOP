using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simpele_bankrekening
{
    public class Beleggingsrekening : Rekening
    {
        private const double INTRESTRENTE = 0.2;
        public DateTime VervalDatum { get; set; }

        public Beleggingsrekening(double saldo, DateTime openingsdatum, int rekeningnummer, DateTime vervalDatum) : base(saldo, openingsdatum, rekeningnummer)
        {
            this.VervalDatum = vervalDatum;
        }

        public override double BerekenSaldo(DateTime datum)
        {
            int aantalJaar = datum.Year - DateTime.Today.Year;
            int aantalMaanden = (aantalJaar * 12) + (datum.Month - DateTime.Today.Month);
            return base.Saldo + ((base.Saldo * INTRESTRENTE) * aantalMaanden);
        }
        public bool ValideerVervalDatum()
        {
            if(DateTime.Today >= VervalDatum)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void GeldStorten(double bedrag)
        {
            if (ValideerVervalDatum())
            {
                base.GeldStorten(bedrag);
            }
        }
        public override void GeldAfhalen(double bedrag)
        {
            if (ValideerVervalDatum())
            {
                base.GeldAfhalen(bedrag);
            }
        }
        public override void GeldSotrtenOfAfhalen(double bedrag)
        {
            if (ValideerVervalDatum())
            {
                base.GeldSotrtenOfAfhalen(bedrag);
            }
        }
        public override string ToString()
        {
            return base.ToString() + "\n\t\tVervalDatum: " + this.VervalDatum;
        }
    }
}
