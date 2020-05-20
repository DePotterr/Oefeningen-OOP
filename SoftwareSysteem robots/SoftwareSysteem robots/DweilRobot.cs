using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareSysteem_robots
{
    class DweilRobot : Robot, IDweilen
    {
        public bool WaterAanwezig { get; set; }
        public bool ZeepAanwezig { get; set; }
        public DweilRobot(string naam, bool waterAanwezig, bool zeepAanwezig) : base(naam)
        {
            WaterAanwezig = waterAanwezig;
            ZeepAanwezig = zeepAanwezig;
        }
        public override bool CheckKanOpstarten()
        {
            if (WaterAanwezig == false || ZeepAanwezig == false)
            {
                base.KanOpstarten = false;
                if (!WaterAanwezig)
                {
                    throw new CustumRobotException("Water is niet aanwezig.");
                }
                else
                {
                    throw new CustumRobotException("Zeep is niet aanwezig.");
                }
            }
            else
            {
                base.KanOpstarten = true;
            }
            return base.KanOpstarten;
        }
        public string Dweilen()
        {
            return "dweilen";
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
