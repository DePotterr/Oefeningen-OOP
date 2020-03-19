using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjBank
{
    class Spaarrekening : Rekening
    {
        private DateTime getrouwheidDatum;
        private const double GETROUWHEIDSRENTE = 1.3;
        private const double INTRESTRENTE = 1.2;

        public DateTime GetrouwheidDatum
        {
            get { return getrouwheidDatum; }
            set { getrouwheidDatum = value; }
        }

        public Spaarrekening(double saldo, DateTime openingsdatum, int rekeningnummer) : base(saldo, openingsdatum, rekeningnummer)
        {
            SetGetrouwheidDatumVandaag();
        }

        public override double BerekenSaldo(DateTime datum)
        {
            int aantalJaar = datum.Year - DateTime.Today.Year;
            int aantalMaanden = (aantalJaar * 12) + (datum.Month - DateTime.Today.Month);
            double bedragGetrouwheidsrente = base.Saldo * GETROUWHEIDSRENTE;
            double bedragIntrestrente = base.Saldo * INTRESTRENTE;

            if (ValideerGetrouwheidsrente())
            {
                return base.Saldo + (bedragGetrouwheidsrente * aantalJaar) + (bedragIntrestrente * aantalMaanden);
            }
            else
            {
                return base.Saldo + (bedragIntrestrente * aantalMaanden);
            }
        }

        public bool ValideerGetrouwheidsrente()
        {
            bool intrest = false;
            if(GetrouwheidDatum >= DateTime.Today.AddYears(-1))
            {
                intrest = true;
            }
            return intrest;
        }

        public override void GeldStorten(double bedrag)
        {
            base.GeldStorten(bedrag);
            SetGetrouwheidDatumVandaag();
        }

        public override void GeldAfhalen(double bedrag)
        {
            base.GeldAfhalen(bedrag);
            SetGetrouwheidDatumVandaag();
        }

        public void SetGetrouwheidDatumVandaag()
        {
            GetrouwheidDatum = DateTime.Today;
        }
    }
}
