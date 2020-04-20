using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herhalingsoef_met_GUI
{
    class Rusthuisbewoner : Persoon
    {
        private static Random random = new Random();
        private Verdiepen verdiep;

        public enum Verdiepen { Verdiep1, Verdiep2, Verdiep3, Verdiep4}
        static private int kamernummer = 0;
        public int Kamernummer { get; set; }
        public List<Activiteit> activiteiten { get; set; }
        public Verdiepen Verdiep
        {
            get { return verdiep; }
            set
            {
                if (CheckVerdiep(value))
                {
                    verdiep = value;
                }
                else
                {
                    throw new Exception("Deze afdeling is enkel voor dementen.");
                }
            }
        }


        public Rusthuisbewoner(string voornaam, string naam, Verdiepen verdiep) : base(voornaam, naam)
        {
            this.Kamernummer = kamernummer++;
            this.Verdiep = verdiep;
            this.activiteiten = new List<Activiteit>();
        }

        public Rusthuisbewoner(string voornaam, string naam) : this(voornaam, naam, (Verdiepen)random.Next(3))
        {

        }
        public virtual bool CheckVerdiep(Verdiepen verdiep)
        {
            bool result = true;
            if(verdiep == Verdiepen.Verdiep4)
            {
                result = false;
            }
            return result;
        }

        public bool CheckActiviteit(Activiteit activiteit)
        {
            bool bestaalAl = false;
            foreach(Activiteit item in activiteiten)
            {
                if (activiteit.Soort == item.Soort && activiteit.DatumActiviteit == item.DatumActiviteit)
                {
                    bestaalAl = true;
                }
            }
            return bestaalAl;
        }
        public int TotaalKostprijsActiviteiten()
        {
            int totaal = 0;
            for (int i = 0; i < activiteiten.Count; i++)
            {
                totaal += activiteiten[i].Kostprijs;
            }
            return totaal;
        }

        public void VerwijderActiviteit(Activiteit activiteit)
        {
            List<Activiteit> lijstTeVerwijderenActiviteiten = new List<Activiteit>();
            for (int i = 0; i < this.activiteiten.Count; i++)
            {
                if(activiteit.Soort == activiteiten[i].Soort && activiteit.DatumActiviteit == activiteiten[i].DatumActiviteit)
                {
                    lijstTeVerwijderenActiviteiten.Add(activiteiten[i]);
                }
            }
            for (int i = 0; i < lijstTeVerwijderenActiviteiten.Count; i++)
            {
                activiteiten.Remove(lijstTeVerwijderenActiviteiten[i]);
            }
        }

        public virtual string ToevoegenActiviteit(Activiteit activiteit)
        {
            if(activiteit.DatumActiviteit < DateTime.Today)
            {
                return "Activiteiten mogen niet in het verleden liggen.";
            }
            else if (CheckActiviteit(activiteit))
            {
                return "Activiteit bestaat al.";
            }
            else
            {
                activiteiten.Add(activiteit);
                return "Activiteti toegevoegd";
            }
        }
        public override string ToString()
        {
            return this.Kamernummer + " " + base.ToString() + " " + this.Verdiep;
        }
    }
}
