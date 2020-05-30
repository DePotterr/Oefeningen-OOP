using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herhalingsoef_2
{
    class BeheerPersoneel
    {
        public List<Personeel> Personeel { get; set; }
        public List<Personeel> OntslagenPersoneel { get; set; }
        public BeheerPersoneel(List<Personeel> personeel)
        {
            Personeel = personeel;
            OntslagenPersoneel = new List<Personeel>();
        }
        public override string ToString()
        {
            string personeel = "";
            for (int i = 0; i < Personeel.Count; i++)
            {
                personeel = Personeel[i].ToString();
            }
            return personeel;
        }
        public List<Personeel> Ontslagen(int personeelID)
        {
            bool isGevonden = false;
            List<Personeel> teOntsalgenPersoneel = new List<Personeel>();
            foreach (Personeel personeel in Personeel)
            {
                if(personeel.PersoneelID == personeelID)
                {
                    teOntsalgenPersoneel.Add(personeel);
                    isGevonden = true;
                }
            }
            if (!isGevonden)
            {
                throw new Exception("Kon personeel niet vinden.");
            }
            foreach (Personeel personeel in teOntsalgenPersoneel)
            {
                personeel.Opzegtermijn = BerekenOpzegtermijn(personeel);
                this.OntslagenPersoneel.Add(personeel);
                this.Personeel.Remove(personeel);
            }
            return teOntsalgenPersoneel;
        }
        public int BerekenOpzegtermijn(Personeel personeel)
        {
            if(typeof(AdministratiefPersoneel) == personeel.GetType())
            {
                return 6;
            }
            else
            {
                if(personeel.BerekenAantalJaarInDienst() < 5)
                {
                    return 3;
                }
                else if(personeel.BerekenAantalJaarInDienst() < 10)
                {
                    return 6;
                }
                else
                {
                    return 12;
                }
            }
        }
    }
}
