using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareSysteem_robots
{
    class GrasmaaienRobot : Robot, Igrasmaaien
    {
        public bool OpvangbakVol { get; set; }
        public GrasmaaienRobot(string naam, bool opvangbak) : base(naam)
        {
            OpvangbakVol = opvangbak;
        }
        public override bool CheckKanOpstarten()
        {
            if (OpvangbakVol)
            {
                base.KanOpstarten = false;
                throw new CustumRobotException("Kan niet opstarten. Opvangbak is vol.");
            }
            else
            {
                base.KanOpstarten = true;
            }
            return base.KanOpstarten;
        }
        public string Grasmaaien()
        {
            return "gras maaien";
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
