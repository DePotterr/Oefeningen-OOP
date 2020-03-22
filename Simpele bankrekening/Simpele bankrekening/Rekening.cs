using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simpele_bankrekening
{
    public class Rekening
    {
        public double Saldo { get; set; }
        public DateTime OpeningsDatum { get; set; }
        public int Rekeningnummer { get; set; }
        public bool Rekeningsstatus { get; set; }

        public Rekening(double saldo, DateTime openingsDatum, int rekeningnummer)
        {
            Saldo = saldo;
            OpeningsDatum = openingsDatum;
            Rekeningnummer = rekeningnummer;
            RekeningOpenen();
        }

        public virtual bool GeldAfhalen(double bedrag)
        {
            bool gelukt = false;
            if (bedrag <= 500 && bedrag >= 20)
            {
                this.Saldo -= bedrag;
                gelukt = true;
            }
            return gelukt;
        }
        public virtual bool GeldStorten(double bedrag)
        {
            bool gelukt = false;
            if (bedrag <= 500 && bedrag >= 20)
            {
                this.Saldo += bedrag;
                gelukt = true;
            }
            return gelukt;
        }

        public virtual bool GeldSotrtenOfAfhalen(double bedrag)
        {
            bool gelukt = false;
            if (bedrag <= 500 && bedrag >= 20 || bedrag >= -500 && bedrag <= -20)
            {
                this.Saldo += bedrag;
                gelukt = true;
            }
            return gelukt;
        }
        public void RekeningOpenen()
        {
            this.Rekeningsstatus = true;
        }
        public void RekeningSluiten()
        {
            this.Rekeningsstatus = false;
        }
        public bool StatusRekening()
        {
            return this.Rekeningsstatus;
        }
        public virtual double BerekenSaldo(DateTime datum)
        {
            return this.Saldo;
        }
        public override string ToString()
        {
            return "\n\t\tRekeningnummer: " + this.Rekeningnummer + "\n\t\tSaldo: " + this.Saldo + "\n\t\tOpeningsdatum: " + this.OpeningsDatum + "\n\t\tRekeningsstatus: " + this.Rekeningsstatus;
        }
    }
}
