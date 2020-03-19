using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjBank
{
    class Rekening
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

        public virtual void GeldAfhalen(double bedrag)
        {
            this.Saldo -= bedrag;
        }
        public virtual void GeldStorten(double bedrag)
        {
            this.Saldo += bedrag;
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
            return "Rekeningnummer: " + this.Rekeningnummer + "\nSaldo: " + this.Saldo + "\nOpeningsdatum: " + this.OpeningsDatum + "\nRekeningsstatus: " + this.Rekeningsstatus;
        }
    }
}
