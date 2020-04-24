using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stofwinkel
{
    class Winkel
    {
        public List<Stof> Stoffen { get; set; }

        public Winkel()
        {
            Stoffen = new List<Stof>();
        }
        public bool StofToevoegen(Stof stof)
        {
            bool isGelukt = false;
            try
            {
                Stoffen.Add(stof);
                isGelukt = true;
            }
            catch (Exception)
            {

                throw new Exception("Kon stof niet toevoegen.");
            }
            return isGelukt;
        }
        public bool StofVerwijderen(Stof teVerwijderenTof)
        {
            bool isGelukt = false;
            try
            {
                List<Stof> TeVerwijderenStoffen = new List<Stof>();
                foreach (Stof stof in this.Stoffen)
                {
                    if (stof == teVerwijderenTof)
                    {
                        TeVerwijderenStoffen.Add(stof);
                    }
                }
                foreach (Stof stof in TeVerwijderenStoffen)
                {
                    if (this.Stoffen.Contains(stof))
                    {
                        this.Stoffen.Remove(stof);
                    }
                }
                isGelukt = true;
            }
            catch (Exception)
            {

                throw new Exception("Kon stof niet verwijderen.");
            }
            return isGelukt;
        }
        public override string ToString()
        {
            string stoffen = "";
            for (int i = 0; i < Stoffen.Count; i++)
            {
                stoffen += Stoffen[i] + "\n";
            }
            return stoffen;
        }
    }
}
