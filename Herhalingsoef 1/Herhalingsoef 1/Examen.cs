using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herhalingsoef_1
{
    public class Examen
    {
        public double Tijdsduur { get; set; }
        public Examen(double tijdsduur)
        {
            Tijdsduur = tijdsduur;
        }
        public double BerekenTijdsduurStudent(Student student)
        {
            double extraTijd = 0;
            if (typeof(FaciliteitStudet) == student.GetType())
            {
                if (((FaciliteitStudet)student).Faciliteit == Faciliteiten.Extra_examentijd)
                {
                    if (Tijdsduur <= 2)
                    {
                        extraTijd = 0.25;
                    }
                    else
                    {
                        extraTijd = 0.5;
                    }
                }
            }
            return Tijdsduur + extraTijd;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
