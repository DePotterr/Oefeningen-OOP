using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Producten
{
    class Non_Food : Product
    {
        public DateTime GarantiePeriode { get; set; }
        public bool Fragiel { get; set; }
        public bool Batterijen { get; set; }

        public Non_Food(string leverancier, string naam, double verkoopprijs, DateTime garantieperiode, bool fragiel, bool batterijen) : base(leverancier, naam, verkoopprijs)
        {
            this.GarantiePeriode = garantieperiode;
            this.Fragiel = fragiel;
            this.Batterijen = batterijen;
        }
        public override string ToString()
        {
            string fragiel;
            if (Fragiel)
            {
                fragiel = "Ja";
            }
            else
            {
                fragiel = "Nee";
            }
            string batterijen;
            if (Batterijen)
            {
                batterijen = "Ja";
            }
            else
            {
                batterijen = "Nee";
            }
            return "Non-Food:\n\t" + base.ToString() + "\n\tGarantiePeriode: " + this.GarantiePeriode + "\n\tFragiel: " + fragiel + "\n\tBatterijen: " + batterijen;
        }
    }
}
